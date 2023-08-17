namespace anbardari2.Forms
{
    partial class BuyFactor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.allPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelbarprice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.allPriceAfterBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "برگشت";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ":جمع ";
            // 
            // allPrice
            // 
            this.allPrice.AutoSize = true;
            this.allPrice.Location = new System.Drawing.Point(660, 425);
            this.allPrice.Name = "allPrice";
            this.allPrice.Size = new System.Drawing.Size(0, 13);
            this.allPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":هزینه بار";
            // 
            // labelbarprice
            // 
            this.labelbarprice.AutoSize = true;
            this.labelbarprice.Location = new System.Drawing.Point(455, 425);
            this.labelbarprice.Name = "labelbarprice";
            this.labelbarprice.Size = new System.Drawing.Size(0, 13);
            this.labelbarprice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = ":جمع کل";
            // 
            // allPriceAfterBar
            // 
            this.allPriceAfterBar.AutoSize = true;
            this.allPriceAfterBar.Location = new System.Drawing.Point(161, 425);
            this.allPriceAfterBar.Name = "allPriceAfterBar";
            this.allPriceAfterBar.Size = new System.Drawing.Size(0, 13);
            this.allPriceAfterBar.TabIndex = 2;
            // 
            // BuyFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelbarprice);
            this.Controls.Add(this.allPriceAfterBar);
            this.Controls.Add(this.allPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuyFactor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyFactor";
            this.Load += new System.EventHandler(this.BuyFactor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelbarprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label allPriceAfterBar;
    }
}