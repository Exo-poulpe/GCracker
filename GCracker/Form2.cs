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

namespace GCracker
{
    public partial class Form2 : Form
    {

        const string DEFAULT_LABEL_PASSWORD = "PasswordFound : ";
        const string DEFAULT_LABEL_DATE_START = "Date time of start : ";
        const string DEFAULT_LABEL_DATE_END = "Date time of end : ";

        private string Password { get; set; }

        public Form2(string password,DateTime start,DateTime end)
        {
            InitializeComponent();
            Password = password;
            lblPasswordFound.Text = DEFAULT_LABEL_PASSWORD + password;
            lblStartDate.Text = DEFAULT_LABEL_DATE_START + start.ToString();
            lblDateEnd.Text = DEFAULT_LABEL_DATE_END + end.ToString();
            this.btnCopy.Click += CopyToClipBoard;

        }

        public void CopyToClipBoard(object sender,EventArgs e)
        {
            Thread T = new Thread(new ThreadStart(() => { Clipboard.SetText(Password); }));
            T.SetApartmentState(ApartmentState.STA);
            T.Start();
            T.Join();
            
        }
    }
}
