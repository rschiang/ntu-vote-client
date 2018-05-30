using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NTUOSC.Vote
{
    class Program : ApplicationContext
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        private static string logFilePath = "Log.txt";

        public static void Log(string text) {
            with (StreamWriter writer = File.AppendText(logFilePath)) {
                writer.Write("{0}: ", DateTime.Now.ToString("u"));
                writer.WriteLine(text);
                writer.WriteLine();
            }
        }

        public static void Log(Exception e) {
            with (StreamWriter writer = File.AppendText(logFilePath)) {
                writer.WriteLine("{0}: ERROR", DateTime.Now.ToString("u"));
                writer.WriteLine(e);
                writer.WriteLine();
            }
        }

        // Instance methods

        LoginForm loginForm;

        private VoteApplication() {
            loginForm = new LoginForm();
            loginForm.LoginSucceeded += OnLoginSucceeded;
            loginForm.Show();
        }

        private OnLoginSucceeded(object sender, EventArgs e) {
            MainForm mainForm = new MainForm();
            this.MainForm = mainForm;
            mainForm.Show()
        }
    }
}
