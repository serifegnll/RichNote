namespace RichNote
{
    partial class FrmBul
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
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.cbHarfDuyarli = new System.Windows.Forms.CheckBox();
            this.btBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranan:";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(112, 28);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(195, 22);
            this.txtAranan.TabIndex = 1;
            this.txtAranan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbHarfDuyarli
            // 
            this.cbHarfDuyarli.AutoSize = true;
            this.cbHarfDuyarli.Location = new System.Drawing.Point(112, 56);
            this.cbHarfDuyarli.Name = "cbHarfDuyarli";
            this.cbHarfDuyarli.Size = new System.Drawing.Size(191, 21);
            this.cbHarfDuyarli.TabIndex = 2;
            this.cbHarfDuyarli.Text = "Büyük/Küçük Harf Duyarlı";
            this.cbHarfDuyarli.UseVisualStyleBackColor = true;
            // 
            // btBul
            // 
            this.btBul.Location = new System.Drawing.Point(112, 83);
            this.btBul.Name = "btBul";
            this.btBul.Size = new System.Drawing.Size(195, 38);
            this.btBul.TabIndex = 3;
            this.btBul.Text = "Bul";
            this.btBul.UseVisualStyleBackColor = true;
            this.btBul.Click += new System.EventHandler(this.btBul_Click);
            // 
            // FrmBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 148);
            this.Controls.Add(this.btBul);
            this.Controls.Add(this.cbHarfDuyarli);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmBul";
            this.Text = "FrmBul";
            this.Load += new System.EventHandler(this.FrmBul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.CheckBox cbHarfDuyarli;
        private System.Windows.Forms.Button btBul;
    }
}