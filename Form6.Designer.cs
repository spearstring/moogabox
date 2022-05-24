
namespace moogabox
{
    partial class Form6
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
			this.lbTime = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.pbMovie = new System.Windows.Forms.PictureBox();
			this.lbSitnum = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtMovie = new System.Windows.Forms.TextBox();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtHallNum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSeatNum = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.Font = new System.Drawing.Font("굴림", 20F);
			this.lbTime.Location = new System.Drawing.Point(124, 231);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(66, 27);
			this.lbTime.TabIndex = 7;
			this.lbTime.Text = "시간";
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("굴림", 20F);
			this.lbTitle.Location = new System.Drawing.Point(124, 194);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(66, 27);
			this.lbTitle.TabIndex = 6;
			this.lbTitle.Text = "영화";
			// 
			// pbMovie
			// 
			this.pbMovie.Location = new System.Drawing.Point(246, 12);
			this.pbMovie.Name = "pbMovie";
			this.pbMovie.Size = new System.Drawing.Size(145, 159);
			this.pbMovie.TabIndex = 5;
			this.pbMovie.TabStop = false;
			// 
			// lbSitnum
			// 
			this.lbSitnum.AutoSize = true;
			this.lbSitnum.Font = new System.Drawing.Font("굴림", 20F);
			this.lbSitnum.Location = new System.Drawing.Point(97, 269);
			this.lbSitnum.Name = "lbSitnum";
			this.lbSitnum.Size = new System.Drawing.Size(93, 27);
			this.lbSitnum.TabIndex = 8;
			this.lbSitnum.Text = "상영관";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(195, 375);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(104, 45);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "확인";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(340, 375);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(104, 45);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "취소";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtMovie
			// 
			this.txtMovie.CausesValidation = false;
			this.txtMovie.Location = new System.Drawing.Point(207, 200);
			this.txtMovie.Name = "txtMovie";
			this.txtMovie.Size = new System.Drawing.Size(237, 21);
			this.txtMovie.TabIndex = 11;
			// 
			// txtTime
			// 
			this.txtTime.CausesValidation = false;
			this.txtTime.Location = new System.Drawing.Point(207, 237);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(237, 21);
			this.txtTime.TabIndex = 11;
			// 
			// txtHallNum
			// 
			this.txtHallNum.CausesValidation = false;
			this.txtHallNum.Location = new System.Drawing.Point(207, 275);
			this.txtHallNum.Name = "txtHallNum";
			this.txtHallNum.Size = new System.Drawing.Size(237, 21);
			this.txtHallNum.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("굴림", 20F);
			this.label1.Location = new System.Drawing.Point(124, 306);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 27);
			this.label1.TabIndex = 8;
			this.label1.Text = "좌석";
			// 
			// txtSeatNum
			// 
			this.txtSeatNum.CausesValidation = false;
			this.txtSeatNum.Location = new System.Drawing.Point(207, 312);
			this.txtSeatNum.Name = "txtSeatNum";
			this.txtSeatNum.Size = new System.Drawing.Size(237, 21);
			this.txtSeatNum.TabIndex = 11;
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 450);
			this.Controls.Add(this.txtSeatNum);
			this.Controls.Add(this.txtHallNum);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.txtMovie);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbSitnum);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pbMovie);
			this.Name = "Form6";
			this.Text = "Form6";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
			this.Load += new System.EventHandler(this.Form6_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.Label lbSitnum;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtMovie;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.TextBox txtHallNum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSeatNum;
	}
}