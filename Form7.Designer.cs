
namespace WinFormsApp1
{
	partial class Form7
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSumMovie = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSumMajum = new System.Windows.Forms.TextBox();
			this.txtSumTotal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.lvMovie = new System.Windows.Forms.ListView();
			this.listView2 = new System.Windows.Forms.ListView();
			this.MvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Hall = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SeatNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SumMovie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SnackName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SnackNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Cout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SumSnack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F);
			this.label1.Location = new System.Drawing.Point(173, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "결제";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(202, 345);
			this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(91, 36);
			this.btnCheck.TabIndex = 7;
			this.btnCheck.Text = "결제";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lvMovie);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtSumMovie);
			this.groupBox1.Location = new System.Drawing.Point(12, 32);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(378, 136);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "예매 결제정보";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(195, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "예매 총합계";
			// 
			// txtSumMovie
			// 
			this.txtSumMovie.Location = new System.Drawing.Point(270, 110);
			this.txtSumMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSumMovie.Name = "txtSumMovie";
			this.txtSumMovie.Size = new System.Drawing.Size(100, 21);
			this.txtSumMovie.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listView2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtSumMajum);
			this.groupBox2.Location = new System.Drawing.Point(12, 172);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(378, 169);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "매점 결제정보";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(195, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "매점 총합계";
			// 
			// txtSumMajum
			// 
			this.txtSumMajum.Location = new System.Drawing.Point(270, 144);
			this.txtSumMajum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSumMajum.Name = "txtSumMajum";
			this.txtSumMajum.Size = new System.Drawing.Size(100, 21);
			this.txtSumMajum.TabIndex = 1;
			// 
			// txtSumTotal
			// 
			this.txtSumTotal.Location = new System.Drawing.Point(91, 354);
			this.txtSumTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSumTotal.Name = "txtSumTotal";
			this.txtSumTotal.Size = new System.Drawing.Size(90, 21);
			this.txtSumTotal.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 357);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "총 결제금액";
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(299, 345);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(91, 36);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "처음으로";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// lvMovie
			// 
			this.lvMovie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MvName,
            this.StartTime,
            this.Hall,
            this.SeatNum,
            this.Count,
            this.SumMovie});
			this.lvMovie.FullRowSelect = true;
			this.lvMovie.GridLines = true;
			this.lvMovie.HideSelection = false;
			this.lvMovie.Location = new System.Drawing.Point(6, 19);
			this.lvMovie.Name = "lvMovie";
			this.lvMovie.Size = new System.Drawing.Size(364, 86);
			this.lvMovie.TabIndex = 10;
			this.lvMovie.UseCompatibleStateImageBehavior = false;
			this.lvMovie.View = System.Windows.Forms.View.Details;
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SnackName,
            this.SnackNum,
            this.Price,
            this.Cout,
            this.SumSnack});
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(6, 19);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(364, 120);
			this.listView2.TabIndex = 11;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// MvName
			// 
			this.MvName.Text = "영화이름";
			// 
			// StartTime
			// 
			this.StartTime.Text = "시간";
			// 
			// Hall
			// 
			this.Hall.Text = "상영관";
			// 
			// SeatNum
			// 
			this.SeatNum.Text = "좌석";
			// 
			// Count
			// 
			this.Count.Text = "수량";
			// 
			// SumMovie
			// 
			this.SumMovie.Text = "합계";
			// 
			// SnackName
			// 
			this.SnackName.Text = "상품명";
			// 
			// SnackNum
			// 
			this.SnackNum.Text = "상품번호";
			// 
			// Price
			// 
			this.Price.Text = "단가";
			// 
			// Cout
			// 
			this.Cout.Text = "수량";
			// 
			// SumSnack
			// 
			this.SumSnack.Text = "합계";
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 400);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSumTotal);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form7";
			this.Text = "Form7";
			this.Load += new System.EventHandler(this.Form7_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSumMovie;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSumMajum;
		private System.Windows.Forms.TextBox txtSumTotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.ListView lvMovie;
		private System.Windows.Forms.ColumnHeader MvName;
		private System.Windows.Forms.ColumnHeader StartTime;
		private System.Windows.Forms.ColumnHeader Hall;
		private System.Windows.Forms.ColumnHeader SeatNum;
		private System.Windows.Forms.ColumnHeader Count;
		private System.Windows.Forms.ColumnHeader SumMovie;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader SnackName;
		private System.Windows.Forms.ColumnHeader SnackNum;
		private System.Windows.Forms.ColumnHeader Price;
		private System.Windows.Forms.ColumnHeader Cout;
		private System.Windows.Forms.ColumnHeader SumSnack;
	}
}
