using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

namespace GCracker
{
    public partial class Form1 : Form
    {
        Size DEFAULT_SIZE_MIN = new Size(800, 550);
        Size DEFAULT_SIZE_MAX = new Size(1265, 550);
        const string DEFAULT_STRING_PASSWORD_CURRENT = "Password current : ";
        const string DEFAULT_STRING_PASSWORD_COUNT = "Password speed : ";
        const string DEFAULT_STRING_PASSWORD_NUMBER = "Password number : ";


        bool _maximize = false;
        public string Password { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool Maximize { get => _maximize; set => _maximize = value; }

        private IAttackor _attack;

        public IAttackor Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }


        public AutoResetEvent PasswordFound = new AutoResetEvent(false);

        private Thread T, T1;
        public Form1()
        {
            InitializeComponent();
            SetTextSettings();
            T1 = new Thread(new ThreadStart(EventPassword));
            T1.Start();
            this.cmbType.SelectedIndex = 0;
            this.btnOpen.Click += OpenArchive;
            this.btnStart.Click += ExtractArchive;
            this.btnStop.Click += StopAttack;
            this.tbxArchivePath.DoubleClick += OpenExplorer;
            this.btnSettings.Click += NewUI;
            this.FormClosing += AppQuit;
            this.btnFindWordlist.Click += FindWordList;

        }


        public void FindWordList(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.InitialDirectory = Environment.CurrentDirectory;
            opfd.Filter = " Text file (*.txt) |*.txt|  List file (*.lst) |*.lst";
            opfd.FilterIndex = 0;
            opfd.Multiselect = false;
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                this.tbxWordlistPath.Text = opfd.FileName;
            }
        }


        public void SetTextSettings()
        {
            this.chkBoxAlpha1.Text = new string(BruteForce.ALPHABET);
            this.chkBoxAlpha2.Text = "..." + new string(BruteForce.ALPHABET_UPPER).Substring(26);
            this.chkBoxAlpha3.Text = "..." + new string(BruteForce.ALPHABET_UPPER_NUMBER).Substring(52);
        }
        public void AppQuit(object sender, EventArgs e)
        {
            if (T != null)
            {
                T.Abort();
            }
            if (T1 != null)
            {
                T1.Abort();
            }
            Application.Exit();
        }

        public void NewUI(object sender, EventArgs e)
        {
            if (!Maximize)
            {
                this.Size = DEFAULT_SIZE_MAX;
                Maximize = !Maximize;
            }
            else
            {
                this.Size = DEFAULT_SIZE_MIN;
                Maximize = !Maximize;
            }
        }

        public void OpenExplorer(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C explorer " + tbxArchivePath.Text;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = true;
            p.Start();
        }

        public void StopAttack(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                T.Abort();
                T1.Abort();
                if (T.IsAlive)
                {
                    T.Join();
                }
                Attack.Stop();
                UpdateLabelPassword("", "", "");
                LogAction("Stop " + cmbType.Items[cmbType.SelectedIndex].ToString() + " attack alphabet number : " + ((chkBoxAlpha1.Checked) ? "1" : (chkBoxAlpha2.Checked) ? "2" : (chkBoxAlpha3.Checked) ? "3" : "3"));
            }
            else if (cmbType.SelectedIndex == 1)
            {
                T.Abort();
                T1.Abort();
                if (T.IsAlive)
                {
                    T.Join();
                }
                Attack.Stop();
                UpdateLabelPassword("", "", "");
                LogAction("Stop " + cmbType.Items[cmbType.SelectedIndex].ToString() + " attack alphabet number : " + ((chkBoxAlpha1.Checked) ? "1" : (chkBoxAlpha2.Checked) ? "2" : (chkBoxAlpha3.Checked) ? "3" : "3"));

            }
        }

        public void UpdateLabelPassword(string passwordCurrent, string passwordCount, string passwordNumber)
        {
            lblPasswordCurrent.Invoke(new MethodInvoker(() =>
            {
                lblPasswordCurrent.Text = DEFAULT_STRING_PASSWORD_CURRENT + passwordCurrent;
            }));

            lblPasswordSpeed.Invoke(new MethodInvoker(() =>
            {
                lblPasswordSpeed.Text = DEFAULT_STRING_PASSWORD_COUNT + passwordCount;
            }));

            lblPasswordNumber.Invoke(new MethodInvoker(() =>
            {
                lblPasswordNumber.Text = DEFAULT_STRING_PASSWORD_NUMBER + passwordNumber;
            }));
        }

        public void EventPassword()
        {
            while (PasswordFound.WaitOne())
            {
                Form2 frm = new Form2(Password, Start, End);
                frm.ShowDialog();
                T.Abort();
            }
        }

        /// <summary>
        /// Find zip archive 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenArchive(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            string filter = null;
            switch (attackToolStripMenuItem.SelectedIndex)
            {
                case 0:
                    filter = "Zip file *.zip  | *.zip";
                    break;
                case 1:
                    filter = "Rar file *.rar  | *.rar";
                    break;

                default:
                    filter = "Zip file *.zip  | *.zip";
                    break;
            }
            opfd.Filter = filter;
            opfd.FilterIndex = 0;
            opfd.Multiselect = false;
            opfd.InitialDirectory = Environment.CurrentDirectory;
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                this.tbxArchivePath.Text = opfd.FileName;
            }

            this.btnStart.Enabled = true;
            this.btnStop.Enabled = true;
        }


        /// <summary>
        /// Extract data from archive
        /// </summary>
        /// <param name="sender">Parent sender</param>
        /// <param name="e">Event</param>
        public void ExtractArchive(object sender, EventArgs e)
        {

            if (cmbType.SelectedIndex == 0)
            {
                ZipFile archive = new ZipFile(tbxArchivePath.Text);
                Attack = new BruteForce(this, (chkBoxAlpha1.Checked) ? 1 : (chkBoxAlpha2.Checked) ? 2 : (chkBoxAlpha3.Checked) ? 3 : 3);
                T = new Thread(new ThreadStart(() => { Password = Attack.ZipAttack(archive); End = DateTime.Now; T.Abort(); }));
                T.Start();
            }
            else if (cmbType.SelectedIndex == 1)
            {
                ZipFile archive = new ZipFile(tbxArchivePath.Text);
                Attack = new Wordlist(this, this.tbxWordlistPath.Text);
                T = new Thread(new ThreadStart(() => { Password = Attack.ZipAttack(archive); End = DateTime.Now; T.Abort(); }));
                T.Start();
            }
            LogAction("Start " + cmbType.Items[cmbType.SelectedIndex].ToString() + " attack alphabet number : " + ((chkBoxAlpha1.Checked) ? "1" : (chkBoxAlpha2.Checked) ? "2" : (chkBoxAlpha3.Checked) ? "3" : "3"));
        }

        private void AttackToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attackToolStripMenuItem.SelectedIndex > 1)
            {
                this.btnOpen.Enabled = false;
                this.grpBoxArchivePath.Text = "Hash to test";
            } else if (attackToolStripMenuItem.SelectedIndex <= 1)
            {
                this.btnOpen.Enabled = true;
                this.grpBoxArchivePath.Text = "Path of archive";
            }
        }

        private void LogAction(string action)
        {
            Start = DateTime.Now;
            this.dataGridView1.Rows.Add(new object[] { Start, cmbType.Items[cmbType.SelectedIndex].ToString(), action, tbxArchivePath.Text });
        }

    }
}
