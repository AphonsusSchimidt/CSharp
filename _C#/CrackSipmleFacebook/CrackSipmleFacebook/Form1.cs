using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackSipmleFacebook
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string RandomString(int numberChar = 10)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;

            Random rand = new Random();
            for (int i = 0; i < numberChar; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(36);
                if (temp != -1 && temp == t)
                {
                    return RandomString(numberChar);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }

        public static string GetLetter()
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] allCharArray = allChar.Split(',');
            int temp = -1;
            Random rand = new Random();
            if (temp != -1)
            {
                rand = new Random(temp * ((int)DateTime.Now.Ticks));
            }
            int t = rand.Next(36);
            if (temp != -1 && temp == t)
            {
                return GetLetter();
            }
            temp = t;
            return allCharArray[t];
        }

        public static char GxetLetter()
        {
            string chars = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rand = new Random();
            int x = DateTime.Now.Millisecond;
            while (x > 36)
            {
                x = x % 36;
            }
            // int num = rand.Next(x, chars.Length - 1);
            return chars[x];
        }

        private Microsoft.Win32.RegistryKey key;

        public string Generatekey()
        {
            string key = "ATP-FACEBOOK";
            List<string> listkey = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                string s;
                s = RandomString(4);
                Thread.Sleep(100);
                key += "-" + s;
            }
            return key;
        }

        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        public void DoWork(IProgress<int> progress)
        {
            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                if (progress != null)
                    progress.Report((j + 1) * 100 / 100000);
            }
        }

        private async void btnCrack_Click(object sender, EventArgs e)
        {
            try
            {
                prsBar.Maximum = 100;
                prsBar.Step = 1;
                var progress = new Progress<int>(v =>
                {
                    prsBar.Value = v;
                });
                await Task.Run(() => DoWork(progress));
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\ATP");
                key.SetValue("ATP-FACEBOOK", Generatekey());
                key.Close();
                MessageBox.Show("Crack success :V ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCrack.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}