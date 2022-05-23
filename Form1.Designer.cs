
namespace moogabox
{
    partial class Form1
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
            this.btnInquiry = new System.Windows.Forms.Button();
            this.btnticket = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInquiry
            // 
            this.btnInquiry.Font = new System.Drawing.Font("굴림", 25F);
            this.btnInquiry.Location = new System.Drawing.Point(57, 60);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(191, 280);
            this.btnInquiry.TabIndex = 0;
            this.btnInquiry.Text = "예매 조회";
            this.btnInquiry.UseVisualStyleBackColor = true;
            // 
            // btnticket
            // 
            this.btnticket.Font = new System.Drawing.Font("굴림", 25F);
            this.btnticket.Location = new System.Drawing.Point(282, 60);
            this.btnticket.Name = "btnticket";
            this.btnticket.Size = new System.Drawing.Size(191, 280);
            this.btnticket.TabIndex = 1;
            this.btnticket.Text = "예매";
            this.btnticket.UseVisualStyleBackColor = true;
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("굴림", 25F);
            this.btnStore.Location = new System.Drawing.Point(498, 60);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(191, 280);
            this.btnStore.TabIndex = 2;
            this.btnStore.Text = "매점";
            this.btnStore.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 395);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnticket);
            this.Controls.Add(this.btnInquiry);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnticket;
        private System.Windows.Forms.Button btnStore;
    }
}