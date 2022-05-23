
namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.Btn_Next = new System.Windows.Forms.Button();
			this.Ticket_Number = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Btn_Next
			// 
			this.Btn_Next.Location = new System.Drawing.Point(501, 333);
			this.Btn_Next.Name = "Btn_Next";
			this.Btn_Next.Size = new System.Drawing.Size(47, 24);
			this.Btn_Next.TabIndex = 0;
			this.Btn_Next.Text = "다음";
			this.Btn_Next.UseVisualStyleBackColor = true;
			this.Btn_Next.Click += new System.EventHandler(this.button1_Click);
			// 
			// Ticket_Number
			// 
			this.Ticket_Number.Location = new System.Drawing.Point(164, 191);
			this.Ticket_Number.Name = "Ticket_Number";
			this.Ticket_Number.Size = new System.Drawing.Size(323, 21);
			this.Ticket_Number.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("굴림", 17F);
			this.label1.Location = new System.Drawing.Point(56, 191);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "발권번호";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("굴림", 20F);
			this.label2.Location = new System.Drawing.Point(228, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 27);
			this.label2.TabIndex = 3;
			this.label2.Text = "예매조회";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("굴림", 15F);
			this.label3.Location = new System.Drawing.Point(229, 261);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "로 조회합니다";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 411);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Ticket_Number);
			this.Controls.Add(this.Btn_Next);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.TextBox Ticket_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

