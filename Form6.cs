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
using System.Configuration;

namespace moogabox
{
    public partial class Form6 : Form
    {
		string Constr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

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
			string path = "../../Resource/" + DataLoad() + ".jpg";
			Image img = Image.FromFile(path);
			pbMovie.Load(path);
			pbMovie.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private string DataLoad()
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();

			var Comm = new SqlCommand("Select MvName, StartTime, Hall, SeatNum from TmpReservation", Conn);
			var myRead = Comm.ExecuteReader();
			if (myRead.Read())
			{
				this.txtMovie.Text = myRead[0].ToString();
				this.txtTime.Text = myRead[1].ToString();
				this.txtHallNum.Text = myRead[2].ToString();
				this.txtSeatNum.Text = myRead[3].ToString();
			}

			return this.txtMovie.Text;

			myRead.Close();

			Conn.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();

			var Comm = new SqlCommand("update TmpReservation set SeatNum = null", Conn);
			Comm.ExecuteNonQuery();

			Conn.Close();
			Form5 form5 = new Form5();
			form5.Show();
			this.Hide();
		}

		private void Form6_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}

