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
	// 예매임시테이블 과 매점구매 테이블을 불러와 각각의 그룹에 뿌린다.
	public partial class Form7 : Form
	{
		private string Constr = "Server=(local);database=MoogaBox;" + "Integrated Security=true"; //SQL 연결문자열

		public Form7()
		{
			InitializeComponent();
		}

		private void Form7_Load(object sender, EventArgs e)
		{
			this.txtSumTotal.Text = DataLoadMovie().ToString();
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
				string MvName = (string)R["MvName"].ToString();                 // R.Read로 읽어온 행의 id열 값을 id에 저장
				string StartTime = (string)R["StartTime"].ToString();                  // R.Read로 읽어온 행의 carName열 값을 carName에 저장
				string Hall = R["Hall"].ToString();               // R.Read로 읽어온 행의 carYear열 값을 carYear에 저장
				string SeatNum = (string)R["SeatNum"].ToString();     // R.Read로 읽어온 행의 carPrice열 값을 carPrice에 저장
				string Ccount = (string)R["Ccount"].ToString();       // R.Read로 읽어온 행의 carDoor열 값을 carDoor에 저장
				string Mmoney = (string)R["Mmoney"].ToString();       // R.Read로 읽어온 행의 carDoor열 값을 carDoor에 저장

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

		private void DataLoadMajum()
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
				string MvName = (string)R["MvName"].ToString();                 // R.Read로 읽어온 행의 id열 값을 id에 저장
				string StartTime = (string)R["StartTime"].ToString();                  // R.Read로 읽어온 행의 carName열 값을 carName에 저장
				string Hall = R["Hall"].ToString();               // R.Read로 읽어온 행의 carYear열 값을 carYear에 저장
				string SeatNum = (string)R["SeatNum"].ToString();     // R.Read로 읽어온 행의 carPrice열 값을 carPrice에 저장
				string Ccount = (string)R["Ccount"].ToString();       // R.Read로 읽어온 행의 carDoor열 값을 carDoor에 저장
				string Mmoney = (string)R["Mmoney"].ToString();       // R.Read로 읽어온 행의 carDoor열 값을 carDoor에 저장

				// 이렇게 저장된 string 문자열들을 문자열배열을 선언해 삽입
				string[] strs = new string[] { MvName, StartTime, Hall, SeatNum, Ccount, Mmoney };

				// ListView에 Item으로 삽입되려면 열수에 맞는 배열요소를 가진 문자열 배열이어야 하므로
				ListViewItem getItem = new ListViewItem(strs);
				lvMovie.Items.Add(getItem);
			}
			this.txtSumMajum.Text = sum.ToString();
			R.Close();
			Conn.Close();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			Form8 form8 = new Form8();
			form8.Show();
			this.Hide();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			form1.Show();
			this.Hide();
		}
	}
}
