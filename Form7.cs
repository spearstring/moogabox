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
using System.Configuration;

namespace WinFormsApp1
{
	// 예매임시테이블 과 매점구매 테이블을 불러와 각각의 그룹에 뿌린다.
	public partial class Form7 : Form
	{
		string Constr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

		public Form7()
		{
			InitializeComponent();
		}

		private void Form7_Load(object sender, EventArgs e)
		{
			this.txtSumTotal.Text = (DataLoadMajum()+DataLoadMovie()).ToString();
		}
		private int DataLoadMovie()
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();

			var Comm = new SqlCommand("Select MvName, StartTime, Hall, SeatNum, Ccount, Mmoney from TmpReservation", Conn);
			SqlDataReader R;
			R = Comm.ExecuteReader();

			int sum = 0;
			while (R.Read())    // R에 아직 읽을 행이 남아있는동안 무한반복(한행 읽고 다음행을 읽는다
			{
				sum += (int)R["Mmoney"];
				string MvName = R["MvName"].ToString();       
				string StartTime = R["StartTime"].ToString(); 
				string Hall = R["Hall"].ToString();           
				string SeatNum = R["SeatNum"].ToString();     
				string Ccount = R["Ccount"].ToString();       
				string Mmoney = R["Mmoney"].ToString();       

				// 이렇게 저장된 string 문자열들을 문자열배열을 선언해 삽입
				string[] strs = new string[] { MvName, StartTime, Hall, SeatNum, Ccount, Mmoney };

				// ListView에 Item으로 삽입되려면 열수에 맞는 배열요소를 가진 문자열 배열이어야 하므로
				ListViewItem getItem = new ListViewItem(strs);
				lvMovie.Items.Add(getItem);
			}
			this.txtSumMovie.Text = sum.ToString();
			R.Close();
			Conn.Close();
			return sum;
		}

		private int DataLoadMajum()
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();

			var Comm = new SqlCommand("Select SnackName, SnackNum, BuyPrice, BuyCount from TmpBuySnack", Conn);
			SqlDataReader R;
			R = Comm.ExecuteReader();

			int sum = 0;
			while (R.Read())    // R에 아직 읽을 행이 남아있는동안 무한반복(한행 읽고 다음행을 읽는다
			{
				
				string SnackName = R["SnackName"].ToString();   
				string SnackNum = R["SnackNum"].ToString();     
				string BuyPrice = R["BuyPrice"].ToString();     
				string BuyCount = R["BuyCount"].ToString();     

				string Mmoney = ((int)R["BuyPrice"] * (int)R["BuyCount"]).ToString();       
				sum += Convert.ToInt32(Mmoney);


				// 이렇게 저장된 string 문자열들을 문자열배열을 선언해 삽입
				string[] strs = new string[] { SnackName, SnackNum, BuyPrice, BuyCount, Mmoney };

				// ListView에 Item으로 삽입되려면 열수에 맞는 배열요소를 가진 문자열 배열이어야 하므로
				ListViewItem getItem = new ListViewItem(strs);
				lvMajum.Items.Add(getItem);
			}
			this.txtSumMajum.Text = sum.ToString();
			return sum;
			R.Close();
			Conn.Close();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			var Conn = new SqlConnection(Constr);
			Conn.Open();
			string InsertSql = string.Format("insert into BuySnack (ID, SnackName, SnackNum, BuyPrice, BuyCount) select ID, SnackName, SnackNum, BuyPrice, BuyCount from TmpBuySnack;");
			var Com = new SqlCommand(InsertSql, Conn);
			Com.ExecuteNonQuery();
			Com = new SqlCommand("delete from TmpBuySnack", Conn);
			Com.ExecuteNonQuery();

			Form8 form8 = new Form8();
			form8.Show();
			this.Hide();
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

		private void Form7_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
