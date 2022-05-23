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
using WinFormsApp1;

namespace moogabox
{
    public partial class Form6 : Form
    {
		public string UserId { get; set; }

		private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true"; //SQL 연결문자열
		public Form6()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("매점 추가 구매 하시겠습니까?", "추가 구매", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
				

				// 매점 창으로 이동
				Form9 form9 = new Form9();
				form9.Show();
				this.Hide();
				
			}

			else
            {
				Form7 form7 = new Form7();
				form7.Show();
				this.Hide();
			}
        }

		private void Form6_Load(object sender, EventArgs e)
		{
			DataLoad();
		}

		private void DataLoad()
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Form5 form5 = new Form5();
			form5.Show();
			this.Hide();
		}
	}
}
