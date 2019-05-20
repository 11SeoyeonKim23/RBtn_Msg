using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RBtn_Msg
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons mbb;
        private MessageBoxIcon mbi;
        public Form1()
        {
            InitializeComponent();
        }

        private void GpOption1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (this.rbOk.Checked)
            {
                this.mbb = MessageBoxButtons.OK;
            }
            else if (this.rbOkCancle.Checked)
            {
                this.mbb = MessageBoxButtons.OKCancel;
            }
            else if (this.rbYesNo.Checked)
            {
                this.mbb = MessageBoxButtons.YesNo;
            }
            else if (this.rbError.Checked)
            {
                this.mbb = MessageBoxIcon.Error;
            }
            else if (this.rbInformation.Checked)
            {
                this.mbb = MessageBoxIcon.Information;
            }
            else if (this.rbQuestion.Checked)
            {
                this.mbb = MessageBoxIcon.Question;
            }
        }
    }
}
