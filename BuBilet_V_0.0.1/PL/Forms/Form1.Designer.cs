﻿namespace BuBilet_V_0._0._1
{
    partial class FrmBuBilet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuBilet));
            this.PnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.PnlSidebarTop = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnOtobus = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUcak = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBilet = new Guna.UI2.WinForms.Guna2Button();
            this.BtnOtel = new Guna.UI2.WinForms.Guna2Button();
            this.PnlSidebarBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnCikisYap = new Guna.UI2.WinForms.Guna2Button();
            this.BtnGirisYap = new Guna.UI2.WinForms.Guna2Button();
            this.PnlNavbar = new Guna.UI2.WinForms.Guna2Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnSideBarControl = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CbxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CbxMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2CbxExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TmrSideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.PnlAnaPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PnlSidebar.SuspendLayout();
            this.PnlSidebarTop.SuspendLayout();
            this.PnlSidebarBottom.SuspendLayout();
            this.PnlNavbar.SuspendLayout();
            this.PnlAnaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSidebar
            // 
            this.PnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(111)))));
            this.PnlSidebar.Controls.Add(this.PnlSidebarTop);
            this.PnlSidebar.Controls.Add(this.PnlSidebarBottom);
            this.PnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSidebar.Location = new System.Drawing.Point(0, 58);
            this.PnlSidebar.MaximumSize = new System.Drawing.Size(265, 0);
            this.PnlSidebar.MinimumSize = new System.Drawing.Size(77, 0);
            this.PnlSidebar.Name = "PnlSidebar";
            this.PnlSidebar.Size = new System.Drawing.Size(265, 961);
            this.PnlSidebar.TabIndex = 0;
            // 
            // PnlSidebarTop
            // 
            this.PnlSidebarTop.Controls.Add(this.BtnOtobus);
            this.PnlSidebarTop.Controls.Add(this.BtnUcak);
            this.PnlSidebarTop.Controls.Add(this.BtnBilet);
            this.PnlSidebarTop.Controls.Add(this.BtnOtel);
            this.PnlSidebarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSidebarTop.Location = new System.Drawing.Point(0, 0);
            this.PnlSidebarTop.Name = "PnlSidebarTop";
            this.PnlSidebarTop.Size = new System.Drawing.Size(265, 268);
            this.PnlSidebarTop.TabIndex = 2;
            // 
            // BtnOtobus
            // 
            this.BtnOtobus.Animated = true;
            this.BtnOtobus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOtobus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOtobus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOtobus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOtobus.FillColor = System.Drawing.Color.Transparent;
            this.BtnOtobus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOtobus.ForeColor = System.Drawing.Color.White;
            this.BtnOtobus.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnOtobus.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.BtnOtobus.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BtnOtobus.Image = ((System.Drawing.Image)(resources.GetObject("BtnOtobus.Image")));
            this.BtnOtobus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnOtobus.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnOtobus.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnOtobus.Location = new System.Drawing.Point(0, 11);
            this.BtnOtobus.Name = "BtnOtobus";
            this.BtnOtobus.Size = new System.Drawing.Size(265, 59);
            this.BtnOtobus.TabIndex = 3;
            this.BtnOtobus.Text = "   Otobüs Bileti Bul";
            this.BtnOtobus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnOtobus.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnOtobus.Click += new System.EventHandler(this.BtnOtobus_Click);
            // 
            // BtnUcak
            // 
            this.BtnUcak.Animated = true;
            this.BtnUcak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUcak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUcak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUcak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUcak.FillColor = System.Drawing.Color.Transparent;
            this.BtnUcak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUcak.ForeColor = System.Drawing.Color.White;
            this.BtnUcak.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnUcak.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnUcak.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.BtnUcak.Image = ((System.Drawing.Image)(resources.GetObject("BtnUcak.Image")));
            this.BtnUcak.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnUcak.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnUcak.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnUcak.Location = new System.Drawing.Point(0, 76);
            this.BtnUcak.Name = "BtnUcak";
            this.BtnUcak.Size = new System.Drawing.Size(265, 59);
            this.BtnUcak.TabIndex = 8;
            this.BtnUcak.Text = "   Uçak Bileti Bul";
            this.BtnUcak.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnUcak.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnUcak.Click += new System.EventHandler(this.BtnUcak_Click);
            // 
            // BtnBilet
            // 
            this.BtnBilet.Animated = true;
            this.BtnBilet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBilet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBilet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBilet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBilet.FillColor = System.Drawing.Color.Transparent;
            this.BtnBilet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBilet.ForeColor = System.Drawing.Color.White;
            this.BtnBilet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnBilet.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnBilet.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.BtnBilet.Image = ((System.Drawing.Image)(resources.GetObject("BtnBilet.Image")));
            this.BtnBilet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnBilet.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnBilet.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnBilet.Location = new System.Drawing.Point(0, 206);
            this.BtnBilet.Name = "BtnBilet";
            this.BtnBilet.Size = new System.Drawing.Size(265, 59);
            this.BtnBilet.TabIndex = 10;
            this.BtnBilet.Text = "   Bilet Sorgula";
            this.BtnBilet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnBilet.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnBilet.Click += new System.EventHandler(this.BtnBilet_Click);
            // 
            // BtnOtel
            // 
            this.BtnOtel.Animated = true;
            this.BtnOtel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOtel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOtel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOtel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOtel.FillColor = System.Drawing.Color.Transparent;
            this.BtnOtel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOtel.ForeColor = System.Drawing.Color.White;
            this.BtnOtel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnOtel.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnOtel.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.BtnOtel.Image = ((System.Drawing.Image)(resources.GetObject("BtnOtel.Image")));
            this.BtnOtel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnOtel.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnOtel.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnOtel.Location = new System.Drawing.Point(0, 141);
            this.BtnOtel.Name = "BtnOtel";
            this.BtnOtel.Size = new System.Drawing.Size(265, 59);
            this.BtnOtel.TabIndex = 9;
            this.BtnOtel.Text = "   Otel Bileti Bul";
            this.BtnOtel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnOtel.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnOtel.Click += new System.EventHandler(this.BtnOtel_Click);
            // 
            // PnlSidebarBottom
            // 
            this.PnlSidebarBottom.Controls.Add(this.BtnCikisYap);
            this.PnlSidebarBottom.Controls.Add(this.BtnGirisYap);
            this.PnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlSidebarBottom.Location = new System.Drawing.Point(0, 812);
            this.PnlSidebarBottom.Name = "PnlSidebarBottom";
            this.PnlSidebarBottom.Size = new System.Drawing.Size(265, 149);
            this.PnlSidebarBottom.TabIndex = 8;
            // 
            // BtnCikisYap
            // 
            this.BtnCikisYap.Animated = true;
            this.BtnCikisYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCikisYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCikisYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCikisYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCikisYap.FillColor = System.Drawing.Color.Transparent;
            this.BtnCikisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikisYap.ForeColor = System.Drawing.Color.White;
            this.BtnCikisYap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCikisYap.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnCikisYap.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.BtnCikisYap.Image = ((System.Drawing.Image)(resources.GetObject("BtnCikisYap.Image")));
            this.BtnCikisYap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCikisYap.ImageOffset = new System.Drawing.Point(5, 0);
            this.BtnCikisYap.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnCikisYap.Location = new System.Drawing.Point(0, 96);
            this.BtnCikisYap.Name = "BtnCikisYap";
            this.BtnCikisYap.Size = new System.Drawing.Size(265, 53);
            this.BtnCikisYap.TabIndex = 12;
            this.BtnCikisYap.Text = "   Çıkış Yap";
            this.BtnCikisYap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnCikisYap.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Animated = true;
            this.BtnGirisYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGirisYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGirisYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGirisYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGirisYap.FillColor = System.Drawing.Color.Transparent;
            this.BtnGirisYap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.ForeColor = System.Drawing.Color.White;
            this.BtnGirisYap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnGirisYap.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnGirisYap.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.BtnGirisYap.Image = ((System.Drawing.Image)(resources.GetObject("BtnGirisYap.Image")));
            this.BtnGirisYap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnGirisYap.ImageOffset = new System.Drawing.Point(4, 0);
            this.BtnGirisYap.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnGirisYap.Location = new System.Drawing.Point(0, 37);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(265, 53);
            this.BtnGirisYap.TabIndex = 11;
            this.BtnGirisYap.Text = "   Giriş Yap!";
            this.BtnGirisYap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnGirisYap.TextOffset = new System.Drawing.Point(10, 0);
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // PnlNavbar
            // 
            this.PnlNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(111)))));
            this.PnlNavbar.Controls.Add(this.LblTitle);
            this.PnlNavbar.Controls.Add(this.BtnSideBarControl);
            this.PnlNavbar.Controls.Add(this.guna2TextBox1);
            this.PnlNavbar.Controls.Add(this.guna2CbxMinimize);
            this.PnlNavbar.Controls.Add(this.guna2CbxMaximize);
            this.PnlNavbar.Controls.Add(this.guna2CbxExit);
            this.PnlNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.PnlNavbar.Name = "PnlNavbar";
            this.PnlNavbar.Size = new System.Drawing.Size(1919, 58);
            this.PnlNavbar.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(83, 4);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(125, 50);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "BuBilet";
            // 
            // BtnSideBarControl
            // 
            this.BtnSideBarControl.Animated = true;
            this.BtnSideBarControl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSideBarControl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSideBarControl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSideBarControl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSideBarControl.FillColor = System.Drawing.Color.Transparent;
            this.BtnSideBarControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSideBarControl.ForeColor = System.Drawing.Color.White;
            this.BtnSideBarControl.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSideBarControl.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.BtnSideBarControl.Image = ((System.Drawing.Image)(resources.GetObject("BtnSideBarControl.Image")));
            this.BtnSideBarControl.Location = new System.Drawing.Point(0, 1);
            this.BtnSideBarControl.Name = "BtnSideBarControl";
            this.BtnSideBarControl.Size = new System.Drawing.Size(77, 52);
            this.BtnSideBarControl.TabIndex = 8;
            this.BtnSideBarControl.Click += new System.EventHandler(this.BtnSideBarControl_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 14;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(838, 13);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(229, 31);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // guna2CbxMinimize
            // 
            this.guna2CbxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CbxMinimize.Animated = true;
            this.guna2CbxMinimize.BorderRadius = 5;
            this.guna2CbxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2CbxMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(111)))));
            this.guna2CbxMinimize.IconColor = System.Drawing.Color.White;
            this.guna2CbxMinimize.Location = new System.Drawing.Point(1761, 8);
            this.guna2CbxMinimize.Name = "guna2CbxMinimize";
            this.guna2CbxMinimize.Size = new System.Drawing.Size(48, 41);
            this.guna2CbxMinimize.TabIndex = 2;
            // 
            // guna2CbxMaximize
            // 
            this.guna2CbxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CbxMaximize.Animated = true;
            this.guna2CbxMaximize.BorderRadius = 5;
            this.guna2CbxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2CbxMaximize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(111)))));
            this.guna2CbxMaximize.IconColor = System.Drawing.Color.White;
            this.guna2CbxMaximize.Location = new System.Drawing.Point(1812, 8);
            this.guna2CbxMaximize.Name = "guna2CbxMaximize";
            this.guna2CbxMaximize.Size = new System.Drawing.Size(48, 41);
            this.guna2CbxMaximize.TabIndex = 1;
            // 
            // guna2CbxExit
            // 
            this.guna2CbxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CbxExit.Animated = true;
            this.guna2CbxExit.BorderRadius = 5;
            this.guna2CbxExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(111)))));
            this.guna2CbxExit.IconColor = System.Drawing.Color.White;
            this.guna2CbxExit.Location = new System.Drawing.Point(1863, 7);
            this.guna2CbxExit.Name = "guna2CbxExit";
            this.guna2CbxExit.Size = new System.Drawing.Size(48, 41);
            this.guna2CbxExit.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.PnlNavbar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // TmrSideBarTransition
            // 
            this.TmrSideBarTransition.Interval = 30;
            this.TmrSideBarTransition.Tick += new System.EventHandler(this.TmrSideBarTransition_Tick);
            // 
            // PnlAnaPanel
            // 
            this.PnlAnaPanel.Controls.Add(this.dataGridView1);
            this.PnlAnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAnaPanel.Location = new System.Drawing.Point(265, 58);
            this.PnlAnaPanel.Name = "PnlAnaPanel";
            this.PnlAnaPanel.Size = new System.Drawing.Size(1654, 961);
            this.PnlAnaPanel.TabIndex = 2;
            this.PnlAnaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlAnaPanel_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(488, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmBuBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1919, 1019);
            this.Controls.Add(this.PnlAnaPanel);
            this.Controls.Add(this.PnlSidebar);
            this.Controls.Add(this.PnlNavbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuBilet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BuBilet";
            this.PnlSidebar.ResumeLayout(false);
            this.PnlSidebarTop.ResumeLayout(false);
            this.PnlSidebarBottom.ResumeLayout(false);
            this.PnlNavbar.ResumeLayout(false);
            this.PnlNavbar.PerformLayout();
            this.PnlAnaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlSidebar;
        private Guna.UI2.WinForms.Guna2Panel PnlNavbar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2CbxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2CbxMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox guna2CbxExit;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel PnlSidebarBottom;
        private Guna.UI2.WinForms.Guna2Panel PnlSidebarTop;
        private Guna.UI2.WinForms.Guna2Button BtnOtobus;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button BtnUcak;
        private Guna.UI2.WinForms.Guna2Button BtnOtel;
        private Guna.UI2.WinForms.Guna2Button BtnBilet;
        private Guna.UI2.WinForms.Guna2Button BtnGirisYap;
        private Guna.UI2.WinForms.Guna2Button BtnCikisYap;
        private Guna.UI2.WinForms.Guna2Button BtnSideBarControl;
        private System.Windows.Forms.Timer TmrSideBarTransition;
        private Guna.UI2.WinForms.Guna2Panel PnlAnaPanel;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

