namespace RichNote
{
    partial class Kapat
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
            this.btEvet = new System.Windows.Forms.Button();
            this.btHayir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(137, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emin misin?";
            // 
            // btEvet
            // 
            this.btEvet.Location = new System.Drawing.Point(59, 108);
            this.btEvet.Name = "btEvet";
            this.btEvet.Size = new System.Drawing.Size(75, 33);
            this.btEvet.TabIndex = 1;
            this.btEvet.Text = "Evet";
            this.btEvet.UseVisualStyleBackColor = true;
            this.btEvet.Click += new System.EventHandler(this.btEvet_Click);
            // 
            // btHayir
            // 
            this.btHayir.Location = new System.Drawing.Point(254, 108);
            this.btHayir.Name = "btHayir";
            this.btHayir.Size = new System.Drawing.Size(75, 33);
            this.btHayir.TabIndex = 2;
            this.btHayir.Text = "Hayır";
            this.btHayir.UseVisualStyleBackColor = true;
            this.btHayir.Click += new System.EventHandler(this.btHayir_Click);
            // 
            // Kapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 183);
            this.Controls.Add(this.btHayir);
            this.Controls.Add(this.btEvet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Kapat";
            this.Text = "Kapat";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEvet;
        private System.Windows.Forms.Button btHayir;
    }
}