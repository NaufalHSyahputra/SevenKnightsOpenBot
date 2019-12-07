/*
 * This file just for exit bluestacks, run app, etc. Which don't need to read Control_Handle_Title & Handle_Title
 */
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace SevenKnightsAI.Classes
{
    public class ControlBluestacks
    {
        private static readonly string PACKAGE_NAME = "com.netmarble.sknightsgb";

        private static readonly string ACTIVITY_NAME = ControlBluestacks.PACKAGE_NAME + "/com.netmarble.sknightsgb.MainActivity";

        public static readonly int DELAY_BS_EXIT = 12000;

        public static readonly int DELAY_BS_START = 60000;

        private readonly string LD_TITLE;

        private RegistryKey HKCU = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);

        public ControlBluestacks(string title)
        {
            LD_TITLE = title;
        }

        private string Adb(string command)
        {
            Process process = CreateProcess(AdbPath, command);
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
        }

        private string LDConsole(string command)
        {
            Process process = CreateProcess(LDConsolePath, command);
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
        }

        public void KillADB()
        {
            Process process = CreateProcess("cmd.exe", "taskkill /IM adb.exe /F");
            process.Start();
            process.WaitForExit();
        }

        private Process CreateProcess(string path, string arguments = null)
        {
            return new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                }
            };
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        public bool IsGameActive()
        {
            return Adb("shell dumpsys window windows | grep mCurrentFocus").Contains(ControlBluestacks.ACTIVITY_NAME);
        }

        public bool IsGameInstalled()
        {
            return Adb("shell pm list packages " + ControlBluestacks.PACKAGE_NAME).Contains(ControlBluestacks.PACKAGE_NAME);
        }

        public void Kill()
        {
            LDConsole(string.Format("quit --name {0}", LD_TITLE));
        }

        public void LaunchGame()
        {
            Adb("shell am start -n " + ControlBluestacks.ACTIVITY_NAME);
        }

        public void LaunchADB()
        {
            Process process = CreateProcess("cmd.exe", AdbPath);
            process.Start();
            process.WaitForExit();
        }

        public void RestartLDPlayer()
        {
            LDConsole(String.Format("reboot --name {0}", LD_TITLE));
        }

        public void RunLDPlayer()
        {
            LDConsole(String.Format("launch --name {0}", LD_TITLE));
        }

        public void RunApp()
        {
            LDConsole(string.Format("runapp --name {0} --packagename {1}", LD_TITLE, ControlBluestacks.PACKAGE_NAME));
        }

        public void KillApp()
        {
            LDConsole(string.Format("killapp --name {0} --packagename {1}", LD_TITLE, ControlBluestacks.PACKAGE_NAME));
        }

        public void KillAppWithADB()
        {
           Adb("shell am force-stop " + ControlBluestacks.PACKAGE_NAME);
        }

        public bool CheckLDPlayer()
        {
            return LDConsole("runninglist").Contains(LD_TITLE);
        }

        public void KillServerAdb()
        {
            Process process = CreateProcess(AdbPath, "kill-server");
            process.Start();
            process.WaitForExit();
        }

        public void DevicesAdb()
        {
            Process process = CreateProcess(AdbPath, "devices");
            process.Start();
            process.WaitForExit();
        }

        public bool RestartADB()
        {
            if (CheckLDPlayer())
            {
                KillServerAdb();
                DevicesAdb();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RestartGame(int maxAttempts = 5)
        {
            KillApp();
            Thread.Sleep(1000);
            RunApp();
            Thread.Sleep(2000);
            int i = 0;
            while (i <= maxAttempts)
            {
                bool flag = IsGameActive();
                if (flag)
                {
                    return true;
                }
                i++;
                Thread.Sleep(800);
                LaunchGame();
            }
            return false;
        }

        public void Screenshot()
        {
            Adb("shell /system/bin/screencap -p /sdcard/screen.png");
            Thread.Sleep(3000);
            Adb("pull /sdcard/screen.png C:\\screen.png");
        }

        private string AdbPath => InstallPath + "adb.exe";

        private string LDConsolePath => InstallPath + "ldconsole.exe";

        private string LauncherPath => InstallPath + "dnplayer.exe";

        private string InstallPath => RegistryKey.GetValue("InstallDir") as string;

        private RegistryKey RegistryKey => HKCU.OpenSubKey("SOFTWARE\\Changzhi\\LDPlayer", true);
    }
}