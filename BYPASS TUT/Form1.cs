using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Memory;
using Beyondmem;

namespace BYPASS_TUT
{
    public partial class Form1 : Form
    {
        MemMirza memory = new MemMirza();
        public Form1()
        {
            InitializeComponent();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string search1 = "3c 51 88 e5 00 70 94 e5 cc 50 96 e5 00 00 57";
            string replace1 = "40 51 88 e5 00 70 94 e5 cc 50 96 e5 00 00 57";
            string search2 = "1c 00 85 e5 00 70 94 e5 c0 50 96 e5 00 00 57 e3 01 00";
            string replace2 = "1d 00 85 e5 00 70 94 e5 c0 50 96 e5 00 00 57 e3";
            string search3 = "28 01 87 e5 00 70 94 e5 01 10 9f e7 00 00 91 e5 bf 10 d0 e5 02 00 11 e3 03 00 00 0a 70 10 90 e5";
            string replace3 = "30 01 87 e5 00 70 94 e5 01 10 9f e7 00 00 91 e5";
            string search4 = "0a 00 a0 e3 00 10 a0 e3 08 00 85 e5 04 00 a0 e1 de 4c ff eb 68 00 9f e5 c0 3d 0b e3 f0 3f";
            string replace4 = "00 f0 20 e3 00 10 a0 e3 08 00 85 e5 04 00 a0 e1";
            string search5 = "0a 00 a0 e3 1c 30 8d e2 24 00 8d e5 04 00 a0 e1 07 10 a0 e1 07 20 a0 e1 20 50 8d e5 28 50";
            string replace5 = "00 f0 20 e3 1c 30 8d e2 24 00 8d e5 04 00 a0 e1";
            string search6 = "0a 00 a0 e3 28 00 8d e5 28 00 8d e2 04 10 a0 e1 07 20 a0 e1 5b ff ff eb 00 50 a0 e1 00 00";
            string replace6 = "00 f0 20 e3 28 00 8d e5 28 00 8d e2 04 10 a0 e1";
            string search7 = "0a 00 a0 e3 b2 01 c4 e1 01 60 9f e7 04 10 a0 e3 00 00 95 e5 5c 00 90 e5 04 40 80 e5 00 00";
            string replace7 = "00 f0 20 e3 b2 01 c4 e1 01 60 9f e7 04 10 a0 e3";
            string search8 = "0a 00 a0 e3 06 ff ff ea 09 00 a0 e3 04 ff ff ea 0a 70 d5 e5 0b 30 d5 e5 1c 80 8d e2 07 74";
            string replace8 = "00 f0 20 e3 06 ff ff ea 09 00 a0 e3 04 ff ff ea";
            string search9 = "0a 00 a0 e3 80 da fd ea 66 cf fd ea 04 30 9f e5 03 30 9f e7 0e d9 fd ea 1c 82 16 00 04 20";
            string replace9 = "00 f0 20 e3 80 da fd ea 66 cf fd ea 04 30 9f e5";
            string search10 = "0a 00 a0 e3 7c fb ff eb 04 00 8d e2 04 10 a0 e1 05 20 a0 e1 00 50 8d e5 7f fc ff eb 04 00";
            string replace10 = "00 f0 20 e3 7c fb ff eb 04 00 8d e2 04 10 a0 e1";
            string search11 = "0a 00 a0 e3 02 3c a0 e3 00 c0 94 e5 04 c3 8d e5 81 99 ff eb 00 00 50 e3 0b 00 a0 03 07 00";
            string replace11 = "00 f0 20 e3 02 3c a0 e3 00 c0 94 e5 04 c3 8d e5";
            string search12 = "0a 00 a0 e3 fc b4 ff eb 48 4b 16 e5 04 a0 8b e2 04 00 a0 e1 43 b5 ff eb af 2d 8d e2 00 00";
            string replace12 = "00 f0 20 e3 fc b4 ff eb 48 4b 16 e5 04 a0 8b e2";
            string search13 = "0a 00 a0 e3 af 8d 8d e2 44 1b 16 e5 04 a0 88 e2 48 2b 16 e5 00 30 9a e5 61 b3 ff eb 48 6b";
            string replace13 = "00 f0 20 e3 af 8d 8d e2 44 1b 16 e5 04 a0 88 e2";
            string search14 = "0a 00 a0 e3 28 00 8d e5 0a 10 a0 e3 04 00 a0 e1 71 a1 ff eb 00 20 a0 e1 e2 0f 8d e2 04 10";
            string replace14 = "00 f0 20 e3 28 00 8d e5 0a 10 a0 e3 04 00 a0 e1";
            string search15 = "0a 00 a0 e3 03 10 a0 e3 a4 00 84 e5 04 00 a0 e1 0a 20 a0 e3 28 01 00 eb 00 10 a0 e1 04 00";
            string replace15 = "00 f0 20 e3 03 10 a0 e3 a4 00 84 e5 04 00 a0 e1";
            string search16 = "49 44 48 48 42 47 42 4e 48 4d 44 00 49 4c 48 4e 43 47 50 4c 4a 41 41 00 44 4d 43 42 50 41";
            string replace16 = "50 4b 45 4a 42 4c 4e 42 41 48 48 00 49 4c 48 4e";
            string search17 = "49 44 48 48 42 47 42 4e 48 4d 44 00 49 4c 48 4e 43 47 50 4c 4a 41 41 00 44 4d 43 42 50 41";
            string replace17 = "50 4b 45 4a 42 4c 4e 42 41 48 48 00 49 4c 48 4e";
            string search18 = "00 48 2d e9 0d b0 a0 e1 18 d0 4d e2 04 00 0b e5 08 10 0b e5 0c 20 8d e5 04 00 1b e5 08 10";
            string replace18 = "1e ff 2f e1 0d b0 a0 e1 18 d0 4d e2 04 00 0b e5";

            bool k = false;

            if (Process.GetProcessesByName("HD-Player").Length == 0)
            {
                // error
                status.Text = ("Process not Detected");
                Console.Beep(240, 300);
            }
            else
            {
                Int32 proc = Process.GetProcessesByName("HD-Player")[0].Id;
                memory.OpenProcess(proc);
                // Applying
                status.Text = ("Injecting");//Error//Applying
                int i2 = 22000000;


                var searchPatterns = new[] { search1, search2, search3, search4, search5, search6, search7, search8, search9, search10, search11, search12, search13, search14, search15, search16, search17, search18 };
                var replacePatterns = new[] { replace1, replace2, replace3, replace4, replace5, replace6, replace7, replace8, replace9, replace10, replace11, replace12, replace13, replace14, replace15, replace16, replace17, replace18 };

                foreach (var search in searchPatterns)
                {
                    IEnumerable<long> wl = await memory.AoBScan2(search, writable: true);

                    if (wl.Any())
                    {
                        foreach (var address in wl)
                        {
                            memory.WriteMemory(address.ToString("X"), "bytes", replacePatterns[Array.IndexOf(searchPatterns, search)]);
                        }
                        k = true;
                    }
                }

                if (k)
                {
                    // Applied
                    status.Text = ("Injected");
                    Console.Beep(1000, 500);
                }
                else
                {
                    status.Text = ("Injection Failed");

                }
            }
        }
        public void ExecuteCommand(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using (Process process = new Process
            {
                StartInfo = processStartInfo
            })
            {
                process.Start();
                process.StandardInput.WriteLine(command);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.ExecuteCommand("netsh advfirewall firewall add rule name=\"TemporaryBlock2\" dir=in action=block profile=any program=\"C:\\Program Files\\BlueStacks_nxt\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall add rule name=\"TemporaryBlock2\" dir=out action=block profile=any program=\"C:\\Program Files\\BlueStacks_nxt\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall add rule name=\"TemporaryBlock2\" dir=in action=block profile=any program=\"C:\\Program Files\\BlueStacks\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall add rule name=\"TemporaryBlock2\" dir=out action=block profile=any program=\"C:\\Program Files\\BlueStacks\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall add rule name=\"TemporaryBlock2\" dir=in action=block profile=any program=\"C:\\Program Files\\BlueStacks_msi2\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall add rule name=\"TemporaryBlock2\" dir=out action=block profile=any program=\"C:\\Program Files\\BlueStacks_msi2\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall add rule name=\"TemporaryBlock2\" dir=in action=block profile=any program=\"C:\\Program Files\\BlueStacks_msi5\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall add rule name=\"TemporaryBlock2\" dir=out action=block profile=any program=\"C:\\Program Files\\BlueStacks_msi5\\HD-Player.exe");
            this.status.Text = "BLOCKED";
            Console.Beep();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.ExecuteCommand("netsh advfirewall firewall delete rule name=all program=\"C:\\Program Files\\BlueStacks_nxt\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall delete rule name=all program=\"C:\\Program Files\\BlueStacks\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall delete rule name=all program=\"C:\\Program Files\\BlueStacks_msi2\\HD-Player.exe");
            this.ExecuteCommand("netsh advfirewall firewall delete rule name=all program=\"C:\\Program Files\\BlueStacks_msi5\\HD-Player.exe");
            this.status.Text = "UNBLOCKED";
            Console.Beep();
        }
    }
}
