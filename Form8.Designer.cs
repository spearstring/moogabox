
namespace WinFormsApp1
{
	partial class Form8
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtMovie = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtSeatNum = new System.Windows.Forms.TextBox();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.lbHall = new System.Windows.Forms.Label();
			this.txtHallNum = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F);
			this.label1.Location = new System.Drawing.Point(159, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "예매완료";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.label2.Location = new System.Drawing.Point(26, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "영화정보 :";
			// 
			// txtMovie
			// 
			this.txtMovie.Location = new System.Drawing.Point(116, 82);
			this.txtMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMovie.Name = "txtMovie";
			this.txtMovie.Size = new System.Drawing.Size(237, 21);
			this.txtMovie.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.label3.Location = new System.Drawing.Point(58, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "시간 :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.label4.Location = new System.Drawing.Point(58, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "좌석 :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.label5.Location = new System.Drawing.Point(26, 207);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 21);
			this.label5.TabIndex = 3;
			this.label5.Text = "발권번호 :";
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(116, 115);
			this.txtTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(100, 21);
			this.txtTime.TabIndex = 4;
			// 
			// txtSeatNum
			// 
			this.txtSeatNum.Location = new System.Drawing.Point(116, 177);
			this.txtSeatNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSeatNum.Name = "txtSeatNum";
			this.txtSeatNum.Size = new System.Drawing.Size(100, 21);
			this.txtSeatNum.TabIndex = 5;
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(116, 208);
			this.txtNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(135, 21);
			this.txtNum.TabIndex = 6;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(301, 258);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(91, 27);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "처음으로";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// lbHall
			// 
			this.lbHall.AutoSize = true;
			this.lbHall.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbHall.Font = new System.Drawing.Font("맑은 고딕", 12F);
			this.lbHall.Location = new System.Drawing.Point(42, 141);
			this.lbHall.Name = "lbHall";
			this.lbHall.Size = new System.Drawing.Size(68, 21);
			this.lbHall.TabIndex = 3;
			this.lbHall.Text = "상영관 :";
			// 
			// txtHallNum
			// 
			this.txtHallNum.Location = new System.Drawing.Point(116, 145);
			this.txtHallNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtHallNum.Name = "txtHallNum";
			this.txtHallNum.Size = new System.Drawing.Size(100, 21);
			this.txtHallNum.TabIndex = 5;
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 294);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.txtHallNum);
			this.Controls.Add(this.txtSeatNum);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbHall);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMovie);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form8";
			this.Text = "Form8";
			this.Load += new System.EventHandler(this.Form8_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMovie;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.TextBox txtSeatNum;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label lbHall;
		private System.Windows.Forms.TextBox txtHallNum;
	}
}