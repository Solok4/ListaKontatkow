namespace Aplikacja
{
    partial class Procesy
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNNowy = new System.Windows.Forms.Button();
            this.BTNKill = new System.Windows.Forms.Button();
            this.BTNSzczegoly = new System.Windows.Forms.Button();
            this.BTNOdswiez = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LVProcesy = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Procesor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pamiec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNNowy);
            this.panel1.Controls.Add(this.BTNKill);
            this.panel1.Controls.Add(this.BTNSzczegoly);
            this.panel1.Controls.Add(this.BTNOdswiez);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel1.Size = new System.Drawing.Size(87, 262);
            this.panel1.TabIndex = 0;
            // 
            // BTNNowy
            // 
            this.BTNNowy.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNNowy.Location = new System.Drawing.Point(0, 99);
            this.BTNNowy.Name = "BTNNowy";
            this.BTNNowy.Size = new System.Drawing.Size(87, 37);
            this.BTNNowy.TabIndex = 3;
            this.BTNNowy.Text = "Utworz nowy";
            this.BTNNowy.UseVisualStyleBackColor = true;
            this.BTNNowy.Click += new System.EventHandler(this.BTNNowy_Click);
            // 
            // BTNKill
            // 
            this.BTNKill.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNKill.Location = new System.Drawing.Point(0, 76);
            this.BTNKill.Name = "BTNKill";
            this.BTNKill.Size = new System.Drawing.Size(87, 23);
            this.BTNKill.TabIndex = 2;
            this.BTNKill.Text = "Kill";
            this.BTNKill.UseVisualStyleBackColor = true;
            this.BTNKill.Click += new System.EventHandler(this.BTNKill_Click);
            // 
            // BTNSzczegoly
            // 
            this.BTNSzczegoly.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNSzczegoly.Location = new System.Drawing.Point(0, 53);
            this.BTNSzczegoly.Name = "BTNSzczegoly";
            this.BTNSzczegoly.Size = new System.Drawing.Size(87, 23);
            this.BTNSzczegoly.TabIndex = 1;
            this.BTNSzczegoly.Text = "Szczegoly";
            this.BTNSzczegoly.UseVisualStyleBackColor = true;
            this.BTNSzczegoly.Click += new System.EventHandler(this.BTNSzczegoly_Click);
            // 
            // BTNOdswiez
            // 
            this.BTNOdswiez.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNOdswiez.Location = new System.Drawing.Point(0, 30);
            this.BTNOdswiez.Name = "BTNOdswiez";
            this.BTNOdswiez.Size = new System.Drawing.Size(87, 23);
            this.BTNOdswiez.TabIndex = 0;
            this.BTNOdswiez.Text = "Odswiez";
            this.BTNOdswiez.UseVisualStyleBackColor = true;
            this.BTNOdswiez.Click += new System.EventHandler(this.BTNOdswiez_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LVProcesy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(87, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 262);
            this.panel2.TabIndex = 1;
            // 
            // LVProcesy
            // 
            this.LVProcesy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nazwa,
            this.Procesor,
            this.Pamiec});
            this.LVProcesy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVProcesy.Location = new System.Drawing.Point(0, 0);
            this.LVProcesy.Name = "LVProcesy";
            this.LVProcesy.Size = new System.Drawing.Size(496, 262);
            this.LVProcesy.TabIndex = 0;
            this.LVProcesy.UseCompatibleStateImageBehavior = false;
            this.LVProcesy.View = System.Windows.Forms.View.Details;
            this.LVProcesy.VirtualMode = true;
            this.LVProcesy.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.LVProcesy_RetrieveVirtualItem);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Nazwa";
            this.Nazwa.Width = 200;
            // 
            // Procesor
            // 
            this.Procesor.Text = "Wyk. procesora";
            this.Procesor.Width = 93;
            // 
            // Pamiec
            // 
            this.Pamiec.Text = "Wyk. pamieci";
            this.Pamiec.Width = 90;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Procesy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Procesy";
            this.Text = "Procesy";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView LVProcesy;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.Button BTNOdswiez;
        private System.Windows.Forms.Button BTNSzczegoly;
        private System.Windows.Forms.Button BTNKill;
        private System.Windows.Forms.Button BTNNowy;
        private System.Windows.Forms.ColumnHeader Procesor;
        private System.Windows.Forms.ColumnHeader Pamiec;
        private System.Windows.Forms.Timer timer1;
    }
}