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

        public static readonly int LD_HEIGHT = 533;

        public static readonly int LD_WIDTH = 818;

        private static readonly string CONTROL_HANDLE_TITLE = "TheRender";

        private static readonly string HANDLE_TITLE = "LDPlayer";

        public static readonly int OFFSET_X = 1;

        public static readonly int OFFSET_Y = 29;

        public static readonly int DELAY_BS_EXIT = 12000;

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

        public Bitmap CaptureFrame(bool backgroundMode)
        {
            return this.MainWindowAS.CaptureFrame(backgroundMode, true);
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

        public string GetExePath()
        {
            uint num = 0u;
            BlueStacks.GetWindowThreadProcessId(this.MainWindowAS.Handle, out num);
            if (num == 0u)
            {
                return null;
            }
            Process processById = Process.GetProcessById((int)num);
            return processById.MainModule.FileName;
        }

        public uint GetProcessID()
        {
            uint num = 0u;
            BlueStacks.GetWindowThreadProcessId(this.MainWindowAS.Handle, out num);
            if(num == 0u)
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
            Point mousePos = this.MainWindowAS.GetMousePos();
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
                result = this.MainWindowAS.GetPixel(x + BlueStacks.OFFSET_X, y + BlueStacks.OFFSET_Y);
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public Size GetWindowSize()
        {
            Size test = this.MainWindowAS.GetControlSize();
            return test;
        }
        public Size GetWindowSize2()
        {
            Size test = this.MainWindowAS.GetControlSize2();
            return test;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        public void Hide(bool useOpacity = true)
        {
            this.HideMainWindow(useOpacity);
            Thread.Sleep(50);
            this.IsHidden = true;
        }

        public void HideMainWindow(bool useOpacity = true)
        {
            if (useOpacity)
            {
                this.MainWindowOpacity(0);
                return;
            }
            this.MainWindowAS.Hide();
        }

        public bool Hook()
        {
            bool result;
            try
            {
                this.MainWindowAS = new AutoSpy(AutoSpy.GetHandle(BlueStacks.HANDLE_TITLE, null), AutoSpy.GetControlHandle(BlueStacks.HANDLE_TITLE, BlueStacks.CONTROL_HANDLE_TITLE));
                this.Show(true);
                result = true;
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show(ex.Message, ex.Message, 10000);
                result = false;
            }
            return result;
        }

        public bool IsGameActive()
        {
            return this.Adb("shell dumpsys window windows | grep mCurrentFocus").Contains(BlueStacks.ACTIVITY_NAME);
        }

        public bool IsGameInstalled()
        {
            return this.Adb("shell pm list packages " + BlueStacks.PACKAGE_NAME).Contains(BlueStacks.PACKAGE_NAME);
        }

        public void Kill()
        {
            this.LDConsole("quit --name LDPlayer");
        }

        public void LaunchGame()
        {
            this.Adb("shell am start -n " + BlueStacks.ACTIVITY_NAME);
        }

        public void LaunchEmulator()
        {
            this.LDConsole("launch --name LDPlayer");
        }

        public void MainWindowOpacity(int value)
        {
            this.MainWindowAS.Opacity(value);
        }

        public bool NeedWindowResize()
        {
            if (this.GetWindowSize().Width != 802 && this.GetWindowSize().Height != 490)
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
            this.MainWindowOpacity(value);
        }

        public void ResizeWindow()
        {
            this.Kill();
            Thread.Sleep(1000);
            this.LDConsole("modify --name LDPlayer --resolution 800,452,160");
            Thread.Sleep(500);
            this.LaunchEmulator();
        }

        public bool RestartAndroid()
        {
            this.Kill();
            Thread.Sleep(2000);
            this.LaunchEmulator();
            return true;
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

        public void Show(bool useOpacity = true)
        {
            this.ShowMainWindow(useOpacity);
            Thread.Sleep(50);
            this.IsHidden = false;
        }

        public void ShowMainWindow(bool useOpacity = true)
        {
            if (useOpacity)
            {
                this.MainWindowOpacity(-1);
                return;
            }
            this.MainWindowAS.Show();
        }

        public void TerminateGame()
        {
            this.Adb("shell am force-stop " + BlueStacks.PACKAGE_NAME);
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

        private RegistryKey RegistryKey
        {
            get
            {
                return HKCU.OpenSubKey("SOFTWARE\\Changzhi\\dnplayer-en", true);
            }
        }
    }
}