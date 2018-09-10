namespace Aplikacja
{
    partial class Wizytowka
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
            this.kontrolka1 = new Kontrolka.Kontrolka();
            this.SuspendLayout();
            // 
            // kontrolka1
            // 
            this.kontrolka1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kontrolka1.Imie = "Imie";
            this.kontrolka1.KOKolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kontrolka1.KWKolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kontrolka1.Location = new System.Drawing.Point(0, 0);
            this.kontrolka1.Margin = new System.Windows.Forms.Padding(4);
            this.kontrolka1.Name = "kontrolka1";
            this.kontrolka1.Nazwisko = "Nazwisko";
            this.kontrolka1.Size = new System.Drawing.Size(524, 162);
            this.kontrolka1.TabIndex = 0;
            this.kontrolka1.Zdjecie = global::Aplikacja.Properties.Resources.cdc;
            // 
            // Wizytowka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 162);
            this.Controls.Add(this.kontrolka1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wizytowka";
            this.ShowIcon = false;
            this.Text = "Wizytówka";
            this.ResumeLayout(false);

        }

        #endregion

        private Kontrolka.Kontrolka kontrolka1;

    }
}