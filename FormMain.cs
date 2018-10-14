using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;
            Form1 f1 = new Form1();
            DialogResult result = f1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
                label1.Text = "TRÀ SỮA 3 THÀNH VIÊN";
            }
        }
    }
}
