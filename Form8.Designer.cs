
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
			this.txtInfo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtSeat = new System.Windows.Forms.TextBox();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(159, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "예매완료";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(26, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "영화정보 :";
			// 
			// txtInfo
			// 
			this.txtInfo.Location = new System.Drawing.Point(116, 103);
			this.txtInfo.Name = "txtInfo";
			this.txtInfo.Size = new System.Drawing.Size(237, 23);
			this.txtInfo.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(58, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "시간 :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(58, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "좌석 :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(26, 278);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 21);
			this.label5.TabIndex = 3;
			this.label5.Text = "발권번호 :";
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(116, 162);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(100, 23);
			this.txtTime.TabIndex = 4;
			// 
			// txtSeat
			// 
			this.txtSeat.Location = new System.Drawing.Point(116, 221);
			this.txtSeat.Name = "txtSeat";
			this.txtSeat.Size = new System.Drawing.Size(100, 23);
			this.txtSeat.TabIndex = 5;
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(116, 279);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(135, 23);
			this.txtNum.TabIndex = 6;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(301, 322);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(91, 34);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "처음으로";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 368);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.txtSeat);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtInfo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form8";
			this.Text = "Form8";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtInfo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.TextBox txtSeat;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnBack;
	}
}