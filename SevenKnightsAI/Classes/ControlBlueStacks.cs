/*
 * This file just for exit bluestacks, run app, etc. Which don't need to read Control_Handle_Title & Handle_Title
 */
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace SevenKnightsAI.Classes
{
    public class ControlBluestacks
    {
        private static readonly string PACKAGE_NAME = "com.netmarble.sknightsgb";

        private static readonly string ACTIVITY_NAME = ControlBluestacks.PACKAGE_NAME + "/com.netmarble.sknightsgb.MainActivity";

        private static readonly string ACTIVITY_NAME_2 = "com.netmarble.sknightsgb.MainActivity";

        public static readonly int DELAY_BS_EXIT = 12000;

        public static readonly int DELAY_BS_START = 60000;

        RegistryKey HKCU = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);

        private string Adb(string command)
        {
            Process process = this.CreateProcess(this.AdbPath, command);
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
        }

        private string LDConsole(string command)
        {
            Process process = this.CreateProcess(this.LDConsolePath, command);
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
        }

        public void KillADB()
        {
            Process process = this.CreateProcess("cmd.exe", "taskkill /IM adb.exe /F");
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
            return this.Adb("shell dumpsys window windows | grep mCurrentFocus").Contains(ControlBluestacks.ACTIVITY_NAME);
        }

        public bool IsGameInstalled()
        {
            return this.Adb("shell pm list packages " + ControlBluestacks.PACKAGE_NAME).Contains(ControlBluestacks.PACKAGE_NAME);
        }

        public void Kill()
        {
            this.LDConsole("quit --name LDPlayer --packagename");
        }

        public void LaunchGame()
        {
            this.Adb("shell am start -n " + ControlBluestacks.ACTIVITY_NAME);
        }

        public void LaunchADB()
        {
            Process process = this.CreateProcess("cmd.exe", this.AdbPath);
            process.Start();
            process.WaitForExit();
        }

        public void RestartBluestacks()
        {
            this.Kill();
            Thread.Sleep(12000);
            this.RunLDPlayer();
            Thread.Sleep(12000);
            this.RunApp();
            Thread.Sleep(5000);
        }

        public void RunApp()
        {
            this.LDConsole("runapp --name LDPlayer --packagename "+ ControlBluestacks.ACTIVITY_NAME);
        }

        public void RunLDPlayer()
        {
            this.LDConsole("launch --name LDPlayer");
        }

        public void RestartADB()
        {
            this.KillADB();
            Thread.Sleep(500);
            this.LaunchADB();
        }

        public bool RestartGame(int maxAttempts = 5)
        {
            this.TerminateGame();
            Thread.Sleep(200);
            this.LaunchGame();
            Thread.Sleep(2000);
            int i = 0;
            while (i <= maxAttempts)
            {
                bool flag = this.IsGameActive();
                if (flag)
                {
                    return true;
                }
                i++;
                Thread.Sleep(800);
                this.LaunchGame();
            }
            return false;
        }

        public void Screenshot()
        {
            this.Adb("shell /system/bin/screencap -p /sdcard/screen.png");
            Thread.Sleep(3000);
            this.Adb("pull /sdcard/screen.png C:\\screen.png");
        }

        public void TerminateGame()
        {
            this.Adb("shell am force-stop " + ControlBluestacks.PACKAGE_NAME);
        }

        private string AdbPath
        {
            get
            {
                return this.InstallPath + "adb.exe";
            }
        }

        private string LDConsolePath
        {
            get
            {
                return this.InstallPath + "dnconsole.exe";
            }
        }

        private string LauncherPath
        {
            get
            {
                return this.InstallPath + "dnplayer.exe";
            }
        }

        private string InstallPath
        {
            get
            {
                return this.RegistryKey.GetValue("InstallDir") as string;
            }
        }

        private RegistryKey RegistryKey
        {
            get
            {
                return HKCU.OpenSubKey("SOFTWARE\\Changzhi\\dnplayer-en", true);
            }
        }
    }
}