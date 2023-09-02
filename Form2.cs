using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game_By_Using_C_
{
    public partial class CustomForm : Form
    {
        public CustomForm()
        {
            InitializeComponent();
        }


        void CustomValidating()
        {
            if (Form1.CustomLevel.From > Form1.CustomLevel.To)
                Form1.CustomLevel.From = Form1.CustomLevel.To;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numFrom_ValueChanged(object sender, EventArgs e)
        {
            Form1.CustomLevel.From = (short)numFrom.Value;
            CustomValidating();
        }

        private void numTo_ValueChanged(object sender, EventArgs e)
        {
            Form1.CustomLevel.To = (short)numTo.Value;
            CustomValidating();
        }

        private void CustomForm_Load(object sender, EventArgs e)
        {
            numFrom.Minimum = 0;
            numFrom.Maximum = 170;

            numTo.Minimum = 0;
            numTo.Maximum = 170;
        }
    }
}
