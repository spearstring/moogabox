
namespace WindowsFormsApp1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Btn_Cancle = new System.Windows.Forms.Button();
			this.View_TotalSale = new System.Windows.Forms.ListView();
			this.View_TotalIncome = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("굴림", 11F);
			this.label1.Location = new System.Drawing.Point(120, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "총 판매수량";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("굴림", 11F);
			this.label2.Location = new System.Drawing.Point(334, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "총 매출액";
			// 
			// Btn_Cancle
			// 
			this.Btn_Cancle.Location = new System.Drawing.Point(491, 332);
			this.Btn_Cancle.Name = "Btn_Cancle";
			this.Btn_Cancle.Size = new System.Drawing.Size(47, 24);
			this.Btn_Cancle.TabIndex = 6;
			this.Btn_Cancle.Text = "취소";
			this.Btn_Cancle.UseVisualStyleBackColor = true;
			// 
			// View_TotalSale
			// 
			this.View_TotalSale.HideSelection = false;
			this.View_TotalSale.Location = new System.Drawing.Point(29, 56);
			this.View_TotalSale.Name = "View_TotalSale";
			this.View_TotalSale.Size = new System.Drawing.Size(278, 306);
			this.View_TotalSale.TabIndex = 7;
			this.View_TotalSale.UseCompatibleStateImageBehavior = false;
			// 
			// View_TotalIncome
			// 
			this.View_TotalIncome.HideSelection = false;
			this.View_TotalIncome.Location = new System.Drawing.Point(412, 168);
			this.View_TotalIncome.Name = "View_TotalIncome";
			this.View_TotalIncome.Size = new System.Drawing.Size(160, 15);
			this.View_TotalIncome.TabIndex = 8;
			this.View_TotalIncome.UseCompatibleStateImageBehavior = false;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 411);
			this.Controls.Add(this.View_TotalIncome);
			this.Controls.Add(this.View_TotalSale);
			this.Controls.Add(this.Btn_Cancle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Cancle;
        private System.Windows.Forms.ListView View_TotalSale;
        private System.Windows.Forms.ListView View_TotalIncome;
    }
}