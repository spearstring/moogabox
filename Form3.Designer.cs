
namespace moogabox
{
    partial class Form3
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
			this.lbTitle = new System.Windows.Forms.Label();
			this.lbTime = new System.Windows.Forms.Label();
			this.lbSitnum = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.pbMovie = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("굴림", 20F);
			this.lbTitle.Location = new System.Drawing.Point(243, 39);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(66, 27);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "영화";
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.Font = new System.Drawing.Font("굴림", 20F);
			this.lbTime.Location = new System.Drawing.Point(243, 108);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(66, 27);
			this.lbTime.TabIndex = 1;
			this.lbTime.Text = "시간";
			// 
			// lbSitnum
			// 
			this.lbSitnum.AutoSize = true;
			this.lbSitnum.Font = new System.Drawing.Font("굴림", 20F);
			this.lbSitnum.Location = new System.Drawing.Point(243, 180);
			this.lbSitnum.Name = "lbSitnum";
			this.lbSitnum.Size = new System.Drawing.Size(66, 27);
			this.lbSitnum.TabIndex = 2;
			this.lbSitnum.Text = "좌석";
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(411, 234);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(116, 46);
			this.btnPrint.TabIndex = 3;
			this.btnPrint.Text = "발권";
			this.btnPrint.UseVisualStyleBackColor = true;
			// 
			// pbMovie
			// 
			this.pbMovie.Location = new System.Drawing.Point(12, 39);
			this.pbMovie.Name = "pbMovie";
			this.pbMovie.Size = new System.Drawing.Size(145, 168);
			this.pbMovie.TabIndex = 6;
			this.pbMovie.TabStop = false;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(570, 305);
			this.Controls.Add(this.pbMovie);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.lbSitnum);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.lbTitle);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbSitnum;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox pbMovie;
    }
}