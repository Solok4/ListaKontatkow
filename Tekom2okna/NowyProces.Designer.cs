namespace Aplikacja
{
    partial class NowyProces
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
            this.TXBNazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNUtworz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXBNazwa
            // 
            this.TXBNazwa.Location = new System.Drawing.Point(13, 33);
            this.TXBNazwa.Name = "TXBNazwa";
            this.TXBNazwa.Size = new System.Drawing.Size(169, 20);
            this.TXBNazwa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa pliku do uruchomienia:";
            // 
            // BTNUtworz
            // 
            this.BTNUtworz.Location = new System.Drawing.Point(197, 33);
            this.BTNUtworz.Name = "BTNUtworz";
            this.BTNUtworz.Size = new System.Drawing.Size(75, 23);
            this.BTNUtworz.TabIndex = 2;
            this.BTNUtworz.Text = "Utworz";
            this.BTNUtworz.UseVisualStyleBackColor = true;
            this.BTNUtworz.Click += new System.EventHandler(this.BTNUtworz_Click);
            // 
            // NowyProces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.BTNUtworz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXBNazwa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NowyProces";
            this.Text = "NowyProces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXBNazwa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNUtworz;
    }
}