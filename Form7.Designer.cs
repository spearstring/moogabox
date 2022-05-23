
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
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("맑은 고딕", 15F);
			this.label1.Location = new System.Drawing.Point(177, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "결제";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(216, 339);
			this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(91, 27);
			this.btnCheck.TabIndex = 7;
			this.btnCheck.Text = "결제";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 32);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(392, 146);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "예매 결제정보";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(241, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "소계";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(286, 122);
			this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 21);
			this.textBox3.TabIndex = 1;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(6, 18);
			this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(380, 100);
			this.listBox1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.listBox2);
			this.groupBox2.Location = new System.Drawing.Point(12, 191);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(392, 143);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "매점 결제정보";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(241, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "소계";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(286, 120);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 21);
			this.textBox2.TabIndex = 1;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 12;
			this.listBox2.Location = new System.Drawing.Point(6, 18);
			this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(380, 100);
			this.listBox2.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(60, 345);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 21);
			this.textBox1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 347);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 9;
			this.label2.Text = "합계";
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(313, 339);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(91, 27);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "처음으로";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 400);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
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
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBack;
	}
}
