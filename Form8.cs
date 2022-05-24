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

	public partial class Form8 : Form
	{
		private string Constr = "Server = 210.119.12.69; Uid=User1;Pwd=1234;database=MoogaBox;" + "Integrated Security = false"; //SQL 연결문자열

		public Form8()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();

			var Comm = new SqlCommand("delete from TmpReservation", Conn);
			Comm.ExecuteNonQuery();

			Conn.Close();

			Form1 form1 = new Form1();
			form1.Show();
			this.Hide();
		}

		private void Form8_Load(object sender, EventArgs e)
		{

			DataLoad();

		}
		private void DataLoad()
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();
			string InsertSql = string.Format("insert into Reservation select * from TmpReservation");
			var Com = new SqlCommand(InsertSql, Conn);
			var Comm = new SqlCommand("Select MvName, StartTime, Hall, SeatNum from TmpReservation", Conn);
			Com.ExecuteNonQuery();
			var myRead = Comm.ExecuteReader();
			if (myRead.Read())
			{
				this.txtMovie.Text = myRead[0].ToString();
				this.txtTime.Text = myRead[1].ToString();
				this.txtHallNum.Text = myRead[2].ToString();
				this.txtSeatNum.Text = myRead[3].ToString();
				this.txtNum.Text = "temp";
			}
			myRead.Close();

			Conn.Close();
		}

		private void Form8_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
