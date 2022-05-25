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
using System.Configuration;
using moogabox;

namespace WinFormsApp1
{

	public partial class Form8 : Form
	{
		string Constr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
		
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
			Com.ExecuteNonQuery();
			//InsertSql = "update Reservation set RsvCode = " + DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + "0001 " + "where ID = "

			var Comm = new SqlCommand("Select MvName, StartTime, Hall, SeatNum, RsvCode from Reservation", Conn);
			
			var myRead = Comm.ExecuteReader();
			if (myRead.Read())
			{
				this.txtMovie.Text = myRead[0].ToString();
				this.txtTime.Text = myRead[1].ToString();
				this.txtHallNum.Text = myRead[2].ToString();
				this.txtSeatNum.Text = myRead[3].ToString();
				this.txtNum.Text = myRead[4].ToString();
			}
			myRead.Close();

			Conn.Close();
		}

		private void Form8_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
