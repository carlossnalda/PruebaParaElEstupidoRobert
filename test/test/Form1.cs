using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private bool Normal;
        public Form1()
        {
            InitializeComponent();
            Normal = false;
        }

        private void t1_EditValueChanged(object sender, EventArgs e)
        {
            if(Normal)
            {
                var total = int.Parse(t1.EditValue.ToString()) + int.Parse(t2.EditValue.ToString());
                t3.EditValue = total;
            }
        }

        private void t2_EditValueChanged(object sender, EventArgs e)
        {
            if(Normal)
            {
                var total = int.Parse(t1.EditValue.ToString()) + int.Parse(t2.EditValue.ToString());
                t3.EditValue = total;
            }
        }

        private void t3_EditValueChanged(object sender, EventArgs e)
        {
            if(!Normal)
            {
                var total = int.Parse(t3.EditValue.ToString());
                t1.EditValue = total;
                t2.EditValue = 0;
            }
        }

        private void t3_KeyPress(object sender, EventArgs e)
        {
            Normal = false;
        }

        private void t2_KeyPress(object sender, EventArgs e)
        {
            Normal = true;
        }

        private void t1_KeyPress(object sender, EventArgs e)
        {
            Normal = true;
        }
    }
}
