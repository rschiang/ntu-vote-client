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
            using (StreamWriter writer = File.AppendText(logFilePath)) {
                writer.Write("{0}: ", DateTime.Now.ToString("u"));
                writer.WriteLine(text);
                writer.WriteLine();
            }
        }

        public static void Log(Exception e) {
            using (StreamWriter writer = File.AppendText(logFilePath)) {
                writer.WriteLine("{0}: ERROR", DateTime.Now.ToString("u"));
                writer.WriteLine(e);
                writer.WriteLine();
            }
        }

        public static void ShowError(Form parent, Exception ex, String title) {
            Log(ex);
            ShowError(parent, "無法連線到身份驗證系統，請檢查網路連線。（{0}）", title, ex.Message);
        }

        public static void ShowError(Form parent, String message, String title, String arg0) {
            MessageBox.Show(parent, String.Format(message, arg0), title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Instance methods

        LoginForm loginForm;

        private Program(): base() {
            loginForm = new LoginForm();
            loginForm.LoginSucceeded += OnLoginSucceeded;
            this.MainForm = loginForm;
            loginForm.Show();
        }

        private void OnLoginSucceeded(object sender, EventArgs e) {
            MainForm mainForm = new MainForm();
            this.MainForm = mainForm;
            mainForm.Show();
        }
    }
}
