using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NirrayKillerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PierwszeUruchomienie(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            if (ConstContainer.Text == "")
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C netsh interface set interface Ethernet admin=enable";
                process.StartInfo = startInfo;
                process.Start();
                process.Close();
                ConstContainer.Text = "Enabled";
            }
            
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.Licznik_SprawdzanieStrony.Start();
        }

        private void Licznik_SprawdzanieStrony_Tick(object sender, EventArgs e)
        {

            if (cmd_line.Text == "DISABLED")
            {
                // do not check for new command, wait for ethernet reload
            }
            else
            {
                try
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] raw = wc.DownloadData("");

                    string webData = System.Text.Encoding.UTF8.GetString(raw);
                    if (webData != " ")
                    {
                        richTextBox1.AppendText("dostępna jest nowa komenda");
                        richTextBox1.AppendText("\n");
                        richTextBox1.AppendText(webData);
                        richTextBox1.AppendText("\n");
                        if (webData.Contains("turnoffnet30"))
                        {
                            UruchomKomendeZListy(1);
                        }
                        if (webData.Contains("turnoffnet60"))
                        {
                            UruchomKomendeZListy(2);
                        }
                        if (webData.Contains("turnoffnetlogout"))
                        {
                            UruchomKomendeZListy(3);
                        }
                        if (webData.Contains("justlogout"))
                        {
                            UruchomKomendeZListy(4);
                        }
                        if (webData.Contains("killgooglechrome"))
                        {
                            UruchomKomendeZListy(5);
                        }
                        if (webData.Contains("turnoffpc"))
                        {
                            UruchomKomendeZListy(6);
                        }
                        if (webData.Contains("killhbogo"))
                        {
                            UruchomKomendeZListy(7);
                        }
                        if (webData.Contains("killcdapremium"))
                        {
                            UruchomKomendeZListy(8);
                        }
                        if (webData.Contains("killyoutube"))
                        {
                            UruchomKomendeZListy(9);
                        }
                        if (webData.Contains("killnetflix"))
                        {
                            UruchomKomendeZListy(10);
                        }
                    }
                    else
                    {
                        // only debug
                        richTextBox1.AppendText("\n");
                        richTextBox1.AppendText("brak nowej komendy");
                        richTextBox1.AppendText("\n");
                    }
                }
                catch (System.Net.WebException)
                {
                    // nothing
                }
            }
        }

        public void UruchomKomendeZListy(int rodzaj)
        {
            if (rodzaj == 1)
            {
                Webbo.Refresh();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C netsh interface set interface Ethernet admin=disable";
                process.StartInfo = startInfo;
                process.Start();
                process.Close();
                cmd_line.Text = "DISABLED";
                UruchomInternetPonownie.Interval = 30000;
                UruchomInternetPonownie.Enabled = true;
                UruchomInternetPonownie.Start();
            }
            if (rodzaj == 2)
            {
                Webbo.Refresh();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C netsh interface set interface Ethernet admin=disable";
                process.StartInfo = startInfo;
                process.Start();
                process.Close();
                cmd_line.Text = "DISABLED";
                UruchomInternetPonownie.Interval = 60000;
                UruchomInternetPonownie.Enabled = true;
                UruchomInternetPonownie.Start();
            }
            if (rodzaj == 3)
            {
                Webbo.Refresh();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C netsh interface set interface Ethernet admin=disable";
                process.StartInfo = startInfo;
                process.Start();
                process.Close();
                cmd_line.Text = "DISABLED";
                UruchomInternetPonownie.Interval = 990000;
                UruchomInternetPonownie.Enabled = false;
                UruchomInternetPonownie.Stop();
            }
            if (rodzaj == 4)
            {
                Webbo.Refresh();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C shutdown -L";
                process.StartInfo = startInfo;
                process.Start();
                process.Close();
            }
            if (rodzaj == 5)
            {
                Webbo.Refresh();
                Kill_chrome();
            }
            if (rodzaj == 6)
            {
                Webbo.Refresh();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C shutdown -s -t 00";
                process.StartInfo = startInfo;
                process.Start();
                process.Close();
            }
            if (rodzaj == 7)
            {
                Webbo.Refresh();
                Kill_chrome();
                ShowHBO_error();
            }
            if (rodzaj == 8)
            {
                Webbo.Refresh();
                Kill_chrome();
                ShowCDA_error();
            }
            if (rodzaj == 9)
            {
                Webbo.Refresh();
                Kill_chrome();
                ShowYouTube_error();
            }
            if (rodzaj == 10)
            {
                Webbo.Refresh();
                Kill_chrome();
                ShowNetflix_error();
            }
        }
        public void ShowHBO_error()
        {
            HBO_FORCE_ERROR.Enabled = true;
            HBO_FORCE_ERROR.Start();
        }
        public void ShowCDA_error()
        {
            CDA_FORCE_ERROR.Enabled = true;
            CDA_FORCE_ERROR.Start();
        }
        public void ShowYouTube_error()
        {
            YOUTUBE_FORCE_ERROR.Enabled = true;
            YOUTUBE_FORCE_ERROR.Start();
        }
        public void ShowNetflix_error()
        {
            NETFLIX_FORCE_ERROR.Enabled = true;
            NETFLIX_FORCE_ERROR.Start();
        }
        public void Kill_chrome()
        {
            System.Diagnostics.Process.GetProcesses()
                         .Where(x => x.ProcessName.ToLower()
                                      .StartsWith("chrome"))
                         .ToList()
                         .ForEach(x => x.Kill());
        }

        private void UruchomInternetPonownie_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C netsh interface set interface Ethernet admin=enable";
            process.StartInfo = startInfo;
            process.Start();
            process.Close();
            cmd_line.Text = "ENABLED";
            UruchomInternetPonownie.Enabled = false;
            UruchomInternetPonownie.Stop();
        }

        private void HBO_FORCE_ERROR_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string command = "/C start chrome " + path + "/hbogo/hbo_error.html";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
            process.Close();
            HBO_FORCE_ERROR.Enabled = false;
            HBO_FORCE_ERROR.Stop();
        }

        private void CDA_FORCE_ERROR_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string command = "/C start chrome " + path + "/cdapremium/error.html";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
            process.Close();
            CDA_FORCE_ERROR.Enabled = false;
            CDA_FORCE_ERROR.Stop();
        }

        private void YOUTUBE_FORCE_ERROR_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string command = "/C start chrome https://www.youtube.com/error?src=404";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
            process.Close();
            YOUTUBE_FORCE_ERROR.Enabled = false;
            YOUTUBE_FORCE_ERROR.Stop();
        }

        private void NETFLIX_FORCE_ERROR_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string command = "/C start chrome " + path + "/netflix/help.netflix.com/pl/is-netflix-down.html";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
            process.Close();
            NETFLIX_FORCE_ERROR.Enabled = false;
            NETFLIX_FORCE_ERROR.Stop();
        }
    }
}
