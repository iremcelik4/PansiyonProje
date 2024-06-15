using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris frm=new FrmGiris();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frm=new FrmYeniMusteri();
            frm.Show();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar frm=new FrmOdalar();
            frm.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMusteriler frm=new frmMusteriler();
            frm.Show();
        }
    }
}
