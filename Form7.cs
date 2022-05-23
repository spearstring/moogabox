using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using moogabox;

namespace WinFormsApp1
{
	// 예매임시테이블 과 매점구매 테이블을 불러와 각각의 그룹에 뿌린다.
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		private void Form7_Load(object sender, EventArgs e)
		{

		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			Form8 form8 = new Form8();
			form8.Show();
			this.Hide();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Form8 form8 = new Form8();
			form8.Show();
			this.Hide();
		}
	}
}
