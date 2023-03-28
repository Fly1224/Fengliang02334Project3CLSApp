using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fengliang02334Project3CLSApp
{
    public partial class frmCreative : Form
    {
        private Icon m_Ready=new Icon (SystemIcons .Information,40,40 );

        public frmCreative()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textSource.Text = "D:\\Creative\\Source\\";
            textProcessedFile.Text = "D:\\Creative\\Processed\\";
            textDest.Text = "D:\\Creative\\Destination\\";
            optGenerateLog.Checked = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textSource.Text))
            {
                errMessage.SetError(textSource, "Ivalid Source Directory");
                textSource.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(textSource, "");

            if (!Directory.Exists(textProcessedFile.Text))
            {
                errMessage.SetError(textProcessedFile, "Ivalid Processed File Directory");
                textProcessedFile.Focus();
                tabControl1.SelectedTab = tabSource;
                return;
            }
            else
                errMessage.SetError(textProcessedFile, "");


            if (!Directory.Exists(textDest.Text))
            {
                errMessage.SetError(textDest, "Ivalid Destnation Directory");
                textDest.Focus();
                tabControl1.SelectedTab = tabDest;
                return;
            }
            else
                errMessage.SetError(textDest, "");


            watchDir.EnableRaisingEvents = true;
            watchDir.Path = textSource.Text;

            mnuNotify.Icon = m_Ready;
            mnuNotify.Visible = true;
            this.ShowInTaskbar = false;
            this.Hide();
        }

        private void textSource_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(textSource.Text))
                textSource.BackColor = Color.White;
            else
                textSource.BackColor = Color.Pink;
        }

        private void textProcessedFile_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(textProcessedFile.Text))
                textProcessedFile.BackColor = Color.White;
            else
                textProcessedFile.BackColor = Color.Pink;
        }

        private void textDest_KeyUp(object sender, KeyEventArgs e)
        {
            if (Directory.Exists(textDest.Text))
                textDest.BackColor = Color.White;
            else
                textDest.BackColor = Color.Pink;
        }

        private void configureApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuNotify.Visible = false ;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuNotify_DoubleClick(object sender, EventArgs e)
        {
            mnuNotify.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
        }
    }
}
