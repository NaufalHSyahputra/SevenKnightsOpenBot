using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace SevenKnightsAI.Classes
{
    internal class BlueStacks
    {
        private static readonly string PACKAGE_NAME = "com.netmarble.sknightsgb";

        private static readonly string ACTIVITY_NAME = BlueStacks.PACKAGE_NAME + "/com.netmarble.sknightsgb.MainActivity";

        public static readonly int LD_HEIGHT = 578;

        public static readonly int LD_WIDTH = 962;

        private static readonly string CONTROL_HANDLE_TITLE = "TheRender";

        public string HANDLE_TITLE = "LDPlayer";

        public static readonly int OFFSET_X = 1;

        public static readonly int OFFSET_Y = 29;

        public static readonly int DELAY_BS_EXIT = 12000;
        private RegistryKey HKCU = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);

        public void setHandleTitle(string h)
        {
            if (h != "")
            {
                HANDLE_TITLE = h;
            }
            else
            {
                HANDLE_TITLE = "LDPlayer";
            }
        }

        private string Adb(string command)
        {
            Process process = CreateProcess(AdbPath, command);
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
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

        private string LDConsole(string command)
        {
            Process process = CreateProcess(LDConsolePath, command);
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
        }

        public Bitmap CaptureFrame(bool backgroundMode)
        {
            return MainWindowAS.CaptureFrame(backgroundMode, true);
        }

        public void KillADB()
        {
            foreach (Process process in Process.GetProcessesByName("adb"))
            {
                process.Kill();
            }
        }

        public bool RunAdb()
        {
            return Adb("version").Contains("Android Debug Bridge");
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

        public string GetExePath()
        {
            BlueStacks.GetWindowThreadProcessId(MainWindowAS.Handle, out uint num);
            if (num == 0u)
            {
                return null;
            }
            Process processById = Process.GetProcessById((int)num);
            return processById.MainModule.FileName;
        }

        public uint GetProcessID()
        {
            BlueStacks.GetWindowThreadProcessId(MainWindowAS.Handle, out uint num);
            if (num == 0u)
            {
                return (int)0u;
            }
            else
            {
                return num;
            }
        }

        public Point GetMousePos()
        {
            Point mousePos = MainWindowAS.GetMousePos();
            return mousePos;
        }

        public int GetPixel(Point pos)
        {
            return GetPixel(pos.X, pos.Y);
        }

        public int GetPixel(int x, int y)
        {
            int result;
            try
            {
                result = MainWindowAS.GetPixel(x + BlueStacks.OFFSET_X, y + BlueStacks.OFFSET_Y);
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public Size GetWindowSize()
        {
            Size test = MainWindowAS.GetControlSize();
            return test;
        }
        public Size GetWindowSize2()
        {
            Size test = MainWindowAS.GetControlSize2();
            return test;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        public void Hide(bool useOpacity = true)
        {
            HideMainWindow(useOpacity);
            Thread.Sleep(50);
            IsHidden = true;
        }

        public void HideMainWindow(bool useOpacity = true)
        {
            if (useOpacity)
            {
                MainWindowOpacity(0);
                return;
            }
            MainWindowAS.Hide();
        }

        public bool Hook()
        {
            bool result;
            try
            {
                MainWindowAS = new AutoSpy(AutoSpy.GetHandle(HANDLE_TITLE, null), AutoSpy.GetControlHandle(HANDLE_TITLE, BlueStacks.CONTROL_HANDLE_TITLE));
                Show(true);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool IsGameActive()
        {
            return Adb("-e shell dumpsys window windows | grep mCurrentFocus").Contains(BlueStacks.ACTIVITY_NAME);
        }

        public bool IsGameInstalled()
        {
            return Adb("-e shell pm list packages " + BlueStacks.PACKAGE_NAME).Contains(BlueStacks.PACKAGE_NAME);
        }

        public void Kill()
        {
            LDConsole("quit --name LDPlayer");
        }

        public void LaunchGame()
        {
            Adb("-e shell am start -n " + BlueStacks.ACTIVITY_NAME);
        }

        public void LaunchEmulator()
        {
            LDConsole("launch --name LDPlayer");
        }

        public void LaunchADB()
        {
            Process process = CreateProcess("cmd.exe", AdbPath);
            process.Start();
            process.WaitForExit();
        }

        public void MainWindowOpacity(int value)
        {
            MainWindowAS.Opacity(value);
        }

        public bool NeedWindowResize()
        {
            if (GetWindowSize().Width != BlueStacks.LD_WIDTH && GetWindowSize().Height != BlueStacks.LD_HEIGHT)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Opacity(int value)
        {
            MainWindowOpacity(value);
        }

        public void ResizeWindow()
        {
            Kill();
            Thread.Sleep(1500);
            LDConsole("modify --name LDPlayer --resolution 960,540,160");
            Thread.Sleep(1000);
            LaunchEmulator();
        }

        public bool RestartAndroid()
        {
            Kill();
            Thread.Sleep(2000);
            LaunchEmulator();
            return true;
        }

        public void RestartADB()
        {
            KillADB();
            Thread.Sleep(500);
            LaunchADB();
        }

        public bool RestartGame(int maxAttempts = 5)
        {
            TerminateGame();
            Thread.Sleep(1000);
            LaunchGame();
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

        public void Show(bool useOpacity = true)
        {
            ShowMainWindow(useOpacity);
            Thread.Sleep(50);
            IsHidden = false;
        }

        public void ShowMainWindow(bool useOpacity = true)
        {
            if (useOpacity)
            {
                MainWindowOpacity(-1);
                return;
            }
            MainWindowAS.Show();
        }

        public void TerminateGame()
        {
            Adb("-e shell am force-stop " + BlueStacks.PACKAGE_NAME);
        }

        public string ValidateResolution()
        {
            return Adb("-e shell wm size");
        }

        private string AdbPath => InstallPath + "adb.exe";

        private string LDConsolePath => InstallPath + "ldconsole.exe";

        private string LauncherPath => InstallPath + "dnplayer.exe";

        private string InstallPath => RegistryKey.GetValue("InstallDir") as string;

        public bool IsHidden
        {
            get;

            private set;
        }

        public AutoSpy MainWindowAS
        {
            get;

            private set;
        }

        private RegistryKey RegistryKey => HKCU.OpenSubKey("SOFTWARE\\Changzhi\\LDPlayer", true);
    }
}