
namespace WindowsFormsApp1
{
    partial class Form5
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
			this.View_StoreStock = new System.Windows.Forms.ListView();
			this.View_WearhouseStock = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.View_Order = new System.Windows.Forms.ListView();
			this.label3 = new System.Windows.Forms.Label();
			this.Btn_Back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// View_StoreStock
			// 
			this.View_StoreStock.HideSelection = false;
			this.View_StoreStock.Location = new System.Drawing.Point(48, 42);
			this.View_StoreStock.Name = "View_StoreStock";
			this.View_StoreStock.Size = new System.Drawing.Size(181, 148);
			this.View_StoreStock.TabIndex = 0;
			this.View_StoreStock.UseCompatibleStateImageBehavior = false;
			this.View_StoreStock.View = System.Windows.Forms.View.Details;
			// 
			// View_WearhouseStock
			// 
			this.View_WearhouseStock.HideSelection = false;
			this.View_WearhouseStock.Location = new System.Drawing.Point(291, 42);
			this.View_WearhouseStock.Name = "View_WearhouseStock";
			this.View_WearhouseStock.Size = new System.Drawing.Size(194, 148);
			this.View_WearhouseStock.TabIndex = 1;
			this.View_WearhouseStock.UseCompatibleStateImageBehavior = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "매장재고";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(289, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "창고재고";
			// 
			// View_Order
			// 
			this.View_Order.HideSelection = false;
			this.View_Order.Location = new System.Drawing.Point(48, 228);
			this.View_Order.Name = "View_Order";
			this.View_Order.Size = new System.Drawing.Size(437, 97);
			this.View_Order.TabIndex = 4;
			this.View_Order.UseCompatibleStateImageBehavior = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "발주";
			// 
			// Btn_Back
			// 
			this.Btn_Back.Location = new System.Drawing.Point(506, 352);
			this.Btn_Back.Name = "Btn_Back";
			this.Btn_Back.Size = new System.Drawing.Size(47, 24);
			this.Btn_Back.TabIndex = 6;
			this.Btn_Back.Text = "뒤로";
			this.Btn_Back.UseVisualStyleBackColor = true;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 411);
			this.Controls.Add(this.Btn_Back);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.View_Order);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.View_WearhouseStock);
			this.Controls.Add(this.View_StoreStock);
			this.Name = "Form5";
			this.Text = "Form5";
			this.Load += new System.EventHandler(this.Form5_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView View_StoreStock;
        private System.Windows.Forms.ListView View_WearhouseStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView View_Order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Back;
    }
}