using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using moogabox;


namespace WinFormsApp1
{
    public partial class Form9 : Form
    {
        StoreOrder ord = new StoreOrder();
        int sum = 0;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /*if ()
            {
                if (MessageBox.Show("매점 구매를 취소하고 예매 결제 창으로 가시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Form7 frm7 = new Form7();
                    frm7.Show();
                    this.Hide();
                }
            }
            else
            {
                if (MessageBox.Show("매점 구매를 취소하고 홈으로 가시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                }
            }*/
        }

        private void btnDrink1_Click(object sender, EventArgs e)
        {

        }
    }
}
