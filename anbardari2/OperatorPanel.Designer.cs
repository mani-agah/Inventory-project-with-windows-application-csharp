namespace anbardari2
{
    partial class OperatorPanel
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
            this.ManageringInventoryBtn = new System.Windows.Forms.Button();
            this.SellProductBtn = new System.Windows.Forms.Button();
            this.BuyProductBtn = new System.Windows.Forms.Button();
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ManageringInventoryBtn
            // 
            this.ManageringInventoryBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.ManageringInventoryBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageringInventoryBtn.Location = new System.Drawing.Point(8, 234);
            this.ManageringInventoryBtn.Name = "ManageringInventoryBtn";
            this.ManageringInventoryBtn.Size = new System.Drawing.Size(409, 49);
            this.ManageringInventoryBtn.TabIndex = 14;
            this.ManageringInventoryBtn.Text = "مدیریت انبار محصول";
            this.ManageringInventoryBtn.UseVisualStyleBackColor = false;
            this.ManageringInventoryBtn.Click += new System.EventHandler(this.ManageringInventoryBtn_Click);
            // 
            // SellProductBtn
            // 
            this.SellProductBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.SellProductBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellProductBtn.Location = new System.Drawing.Point(8, 179);
            this.SellProductBtn.Name = "SellProductBtn";
            this.SellProductBtn.Size = new System.Drawing.Size(409, 49);
            this.SellProductBtn.TabIndex = 13;
            this.SellProductBtn.Text = "فروش محصول";
            this.SellProductBtn.UseVisualStyleBackColor = false;
            this.SellProductBtn.Click += new System.EventHandler(this.SellProductBtn_Click);
            // 
            // BuyProductBtn
            // 
            this.BuyProductBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.BuyProductBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProductBtn.Location = new System.Drawing.Point(8, 124);
            this.BuyProductBtn.Name = "BuyProductBtn";
            this.BuyProductBtn.Size = new System.Drawing.Size(409, 49);
            this.BuyProductBtn.TabIndex = 12;
            this.BuyProductBtn.Text = "خرید محصول";
            this.BuyProductBtn.UseVisualStyleBackColor = false;
            this.BuyProductBtn.Click += new System.EventHandler(this.BuyProductBtn_Click);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.Location = new System.Drawing.Point(8, 69);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(409, 49);
            this.CustomerBtn.TabIndex = 9;
            this.CustomerBtn.Text = "مدیریت مشتریان";
            this.CustomerBtn.UseVisualStyleBackColor = false;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(274, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(143, 29);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "خوش آمدید ادمین";
            // 
            // OperatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 304);
            this.Controls.Add(this.ManageringInventoryBtn);
            this.Controls.Add(this.SellProductBtn);
            this.Controls.Add(this.BuyProductBtn);
            this.Controls.Add(this.CustomerBtn);
            this.Controls.Add(this.labelName);
            this.Name = "OperatorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperatorPanel";
            this.Load += new System.EventHandler(this.OperatorPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ManageringInventoryBtn;
        private System.Windows.Forms.Button SellProductBtn;
        private System.Windows.Forms.Button BuyProductBtn;
        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.Label labelName;
    }
}