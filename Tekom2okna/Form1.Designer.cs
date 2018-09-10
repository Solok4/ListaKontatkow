namespace Aplikacja
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
            this.ListVjuPanel = new System.Windows.Forms.Panel();
            this.ListaKontaktow = new System.Windows.Forms.ListView();
            this.Imię = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wiek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LewyPanel = new System.Windows.Forms.Panel();
            this.BTNProcesy = new System.Windows.Forms.Button();
            this.WizBTN = new System.Windows.Forms.Button();
            this.XMLOdBtn = new System.Windows.Forms.Button();
            this.XMLZapBtn = new System.Windows.Forms.Button();
            this.OdczytBBtn = new System.Windows.Forms.Button();
            this.ZapisBButton = new System.Windows.Forms.Button();
            this.WczytajBtn = new System.Windows.Forms.Button();
            this.ZapiszBtn = new System.Windows.Forms.Button();
            this.CzekBoxPanel = new System.Windows.Forms.Panel();
            this.TelefonCheck = new System.Windows.Forms.CheckBox();
            this.EmailCheck = new System.Windows.Forms.CheckBox();
            this.UsunButton = new System.Windows.Forms.Button();
            this.EdytujButton = new System.Windows.Forms.Button();
            this.DodajButton = new System.Windows.Forms.Button();
            this.ZapiszWnd = new System.Windows.Forms.SaveFileDialog();
            this.WczytajWnd = new System.Windows.Forms.OpenFileDialog();
            this.BTNWatki = new System.Windows.Forms.Button();
            this.ListVjuPanel.SuspendLayout();
            this.LewyPanel.SuspendLayout();
            this.CzekBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListVjuPanel
            // 
            this.ListVjuPanel.Controls.Add(this.ListaKontaktow);
            this.ListVjuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListVjuPanel.Location = new System.Drawing.Point(0, 0);
            this.ListVjuPanel.Name = "ListVjuPanel";
            this.ListVjuPanel.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.ListVjuPanel.Size = new System.Drawing.Size(534, 410);
            this.ListVjuPanel.TabIndex = 6;
            // 
            // ListaKontaktow
            // 
            this.ListaKontaktow.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ListaKontaktow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaKontaktow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Imię,
            this.Nazwisko,
            this.Telefon,
            this.Email,
            this.Wiek});
            this.ListaKontaktow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaKontaktow.FullRowSelect = true;
            this.ListaKontaktow.Location = new System.Drawing.Point(100, 0);
            this.ListaKontaktow.Name = "ListaKontaktow";
            this.ListaKontaktow.Size = new System.Drawing.Size(434, 410);
            this.ListaKontaktow.TabIndex = 0;
            this.ListaKontaktow.UseCompatibleStateImageBehavior = false;
            this.ListaKontaktow.View = System.Windows.Forms.View.Details;
            this.ListaKontaktow.VirtualMode = true;
            this.ListaKontaktow.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListaKontaktow_ColumnClick);
            this.ListaKontaktow.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.ListaKontaktow_RetrieveVirtualItem);
            // 
            // Imię
            // 
            this.Imię.Text = "Imię";
            this.Imię.Width = 80;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Text = "Nazwisko";
            this.Nazwisko.Width = 80;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 90;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 120;
            // 
            // Wiek
            // 
            this.Wiek.Text = "Wiek";
            // 
            // LewyPanel
            // 
            this.LewyPanel.Controls.Add(this.BTNWatki);
            this.LewyPanel.Controls.Add(this.BTNProcesy);
            this.LewyPanel.Controls.Add(this.WizBTN);
            this.LewyPanel.Controls.Add(this.XMLOdBtn);
            this.LewyPanel.Controls.Add(this.XMLZapBtn);
            this.LewyPanel.Controls.Add(this.OdczytBBtn);
            this.LewyPanel.Controls.Add(this.ZapisBButton);
            this.LewyPanel.Controls.Add(this.WczytajBtn);
            this.LewyPanel.Controls.Add(this.ZapiszBtn);
            this.LewyPanel.Controls.Add(this.CzekBoxPanel);
            this.LewyPanel.Controls.Add(this.UsunButton);
            this.LewyPanel.Controls.Add(this.EdytujButton);
            this.LewyPanel.Controls.Add(this.DodajButton);
            this.LewyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LewyPanel.Location = new System.Drawing.Point(0, 0);
            this.LewyPanel.Name = "LewyPanel";
            this.LewyPanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.LewyPanel.Size = new System.Drawing.Size(101, 410);
            this.LewyPanel.TabIndex = 7;
            // 
            // BTNProcesy
            // 
            this.BTNProcesy.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNProcesy.Location = new System.Drawing.Point(0, 353);
            this.BTNProcesy.Name = "BTNProcesy";
            this.BTNProcesy.Size = new System.Drawing.Size(101, 23);
            this.BTNProcesy.TabIndex = 29;
            this.BTNProcesy.Text = "Procesy";
            this.BTNProcesy.UseVisualStyleBackColor = true;
            this.BTNProcesy.Click += new System.EventHandler(this.BTNProcesy_Click);
            // 
            // WizBTN
            // 
            this.WizBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.WizBTN.Location = new System.Drawing.Point(0, 330);
            this.WizBTN.Name = "WizBTN";
            this.WizBTN.Size = new System.Drawing.Size(101, 23);
            this.WizBTN.TabIndex = 28;
            this.WizBTN.Text = "Wizytówka";
            this.WizBTN.UseVisualStyleBackColor = true;
            this.WizBTN.Click += new System.EventHandler(this.WizBTN_Click);
            // 
            // XMLOdBtn
            // 
            this.XMLOdBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.XMLOdBtn.Location = new System.Drawing.Point(0, 307);
            this.XMLOdBtn.Name = "XMLOdBtn";
            this.XMLOdBtn.Size = new System.Drawing.Size(101, 23);
            this.XMLOdBtn.TabIndex = 27;
            this.XMLOdBtn.Text = "XML Odczyt";
            this.XMLOdBtn.UseVisualStyleBackColor = true;
            this.XMLOdBtn.Click += new System.EventHandler(this.XMLOdBtn_Click);
            // 
            // XMLZapBtn
            // 
            this.XMLZapBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.XMLZapBtn.Location = new System.Drawing.Point(0, 284);
            this.XMLZapBtn.Name = "XMLZapBtn";
            this.XMLZapBtn.Size = new System.Drawing.Size(101, 23);
            this.XMLZapBtn.TabIndex = 26;
            this.XMLZapBtn.Text = "XML Zapis";
            this.XMLZapBtn.UseVisualStyleBackColor = true;
            this.XMLZapBtn.Click += new System.EventHandler(this.XMLZapBtn_Click);
            // 
            // OdczytBBtn
            // 
            this.OdczytBBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OdczytBBtn.Location = new System.Drawing.Point(0, 261);
            this.OdczytBBtn.Name = "OdczytBBtn";
            this.OdczytBBtn.Size = new System.Drawing.Size(101, 23);
            this.OdczytBBtn.TabIndex = 25;
            this.OdczytBBtn.Text = "Odczyt binarny";
            this.OdczytBBtn.UseVisualStyleBackColor = true;
            this.OdczytBBtn.Click += new System.EventHandler(this.OdczytBBtn_Click);
            // 
            // ZapisBButton
            // 
            this.ZapisBButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZapisBButton.Location = new System.Drawing.Point(0, 238);
            this.ZapisBButton.Name = "ZapisBButton";
            this.ZapisBButton.Size = new System.Drawing.Size(101, 23);
            this.ZapisBButton.TabIndex = 24;
            this.ZapisBButton.Text = "Zapis binarny";
            this.ZapisBButton.UseVisualStyleBackColor = true;
            this.ZapisBButton.Click += new System.EventHandler(this.ZapisBButton_Click);
            // 
            // WczytajBtn
            // 
            this.WczytajBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.WczytajBtn.Location = new System.Drawing.Point(0, 215);
            this.WczytajBtn.Name = "WczytajBtn";
            this.WczytajBtn.Size = new System.Drawing.Size(101, 23);
            this.WczytajBtn.TabIndex = 23;
            this.WczytajBtn.Text = "Wczytaj liste";
            this.WczytajBtn.UseVisualStyleBackColor = true;
            this.WczytajBtn.Click += new System.EventHandler(this.WczytajBtn_Click);
            // 
            // ZapiszBtn
            // 
            this.ZapiszBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZapiszBtn.Location = new System.Drawing.Point(0, 192);
            this.ZapiszBtn.Name = "ZapiszBtn";
            this.ZapiszBtn.Size = new System.Drawing.Size(101, 23);
            this.ZapiszBtn.TabIndex = 22;
            this.ZapiszBtn.Text = "Zapisz liste";
            this.ZapiszBtn.UseVisualStyleBackColor = true;
            this.ZapiszBtn.Click += new System.EventHandler(this.ZapiszBtn_Click);
            // 
            // CzekBoxPanel
            // 
            this.CzekBoxPanel.Controls.Add(this.TelefonCheck);
            this.CzekBoxPanel.Controls.Add(this.EmailCheck);
            this.CzekBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CzekBoxPanel.Location = new System.Drawing.Point(0, 140);
            this.CzekBoxPanel.Name = "CzekBoxPanel";
            this.CzekBoxPanel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.CzekBoxPanel.Size = new System.Drawing.Size(101, 52);
            this.CzekBoxPanel.TabIndex = 18;
            // 
            // TelefonCheck
            // 
            this.TelefonCheck.AutoSize = true;
            this.TelefonCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.TelefonCheck.Location = new System.Drawing.Point(5, 27);
            this.TelefonCheck.Name = "TelefonCheck";
            this.TelefonCheck.Size = new System.Drawing.Size(91, 17);
            this.TelefonCheck.TabIndex = 14;
            this.TelefonCheck.Text = "Bez telefonu";
            this.TelefonCheck.UseVisualStyleBackColor = true;
            this.TelefonCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EmailCheck
            // 
            this.EmailCheck.AutoSize = true;
            this.EmailCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailCheck.Location = new System.Drawing.Point(5, 10);
            this.EmailCheck.Name = "EmailCheck";
            this.EmailCheck.Size = new System.Drawing.Size(91, 17);
            this.EmailCheck.TabIndex = 13;
            this.EmailCheck.Text = "Bez Email";
            this.EmailCheck.UseVisualStyleBackColor = true;
            this.EmailCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // UsunButton
            // 
            this.UsunButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsunButton.Location = new System.Drawing.Point(0, 100);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(101, 40);
            this.UsunButton.TabIndex = 21;
            this.UsunButton.Text = "Usuń";
            this.UsunButton.UseVisualStyleBackColor = true;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // EdytujButton
            // 
            this.EdytujButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EdytujButton.Location = new System.Drawing.Point(0, 60);
            this.EdytujButton.Name = "EdytujButton";
            this.EdytujButton.Size = new System.Drawing.Size(101, 40);
            this.EdytujButton.TabIndex = 20;
            this.EdytujButton.Text = "Edytuj";
            this.EdytujButton.UseVisualStyleBackColor = true;
            this.EdytujButton.Click += new System.EventHandler(this.EdytujButton_Click);
            // 
            // DodajButton
            // 
            this.DodajButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DodajButton.Location = new System.Drawing.Point(0, 20);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(101, 40);
            this.DodajButton.TabIndex = 19;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // WczytajWnd
            // 
            this.WczytajWnd.FileName = "openFileDialog1";
            // 
            // BTNWatki
            // 
            this.BTNWatki.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNWatki.Location = new System.Drawing.Point(0, 376);
            this.BTNWatki.Name = "BTNWatki";
            this.BTNWatki.Size = new System.Drawing.Size(101, 23);
            this.BTNWatki.TabIndex = 30;
            this.BTNWatki.Text = "Watki";
            this.BTNWatki.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 410);
            this.Controls.Add(this.LewyPanel);
            this.Controls.Add(this.ListVjuPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kontakty";
            this.ListVjuPanel.ResumeLayout(false);
            this.LewyPanel.ResumeLayout(false);
            this.CzekBoxPanel.ResumeLayout(false);
            this.CzekBoxPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListVjuPanel;
        private System.Windows.Forms.ListView ListaKontaktow;
        private System.Windows.Forms.ColumnHeader Imię;
        private System.Windows.Forms.ColumnHeader Nazwisko;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Panel LewyPanel;
        private System.Windows.Forms.Panel CzekBoxPanel;
        private System.Windows.Forms.CheckBox TelefonCheck;
        private System.Windows.Forms.CheckBox EmailCheck;
        private System.Windows.Forms.Button UsunButton;
        private System.Windows.Forms.Button EdytujButton;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.ColumnHeader Wiek;
        private System.Windows.Forms.Button WczytajBtn;
        private System.Windows.Forms.Button ZapiszBtn;
        private System.Windows.Forms.SaveFileDialog ZapiszWnd;
        private System.Windows.Forms.OpenFileDialog WczytajWnd;
        private System.Windows.Forms.Button ZapisBButton;
        private System.Windows.Forms.Button OdczytBBtn;
        private System.Windows.Forms.Button XMLOdBtn;
        private System.Windows.Forms.Button XMLZapBtn;
        private System.Windows.Forms.Button WizBTN;
        private System.Windows.Forms.Button BTNProcesy;
        private System.Windows.Forms.Button BTNWatki;
    }
}

