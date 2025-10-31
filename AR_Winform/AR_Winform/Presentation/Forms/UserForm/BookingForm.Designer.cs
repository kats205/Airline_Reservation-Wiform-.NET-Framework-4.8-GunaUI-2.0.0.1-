using System.Drawing;

namespace AR_Winform.Presentation.Forms
{
    partial class BookingForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.searchBox = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.swapBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.seatClassCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.typeTicketBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reDateChB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deDateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reDateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromAirportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.roundtripRBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.onewayRBtn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.toAirportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.promotionBox = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.promo4 = new Guna.UI2.WinForms.Guna2Panel();
            this.promo3 = new Guna.UI2.WinForms.Guna2Panel();
            this.promo2 = new Guna.UI2.WinForms.Guna2Panel();
            this.promo1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.headerCntrol1 = new AR_Winform.Presentation.UControls.HeaderCntrol();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2.SuspendLayout();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.promotionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.promotionBox);
            this.panel2.Controls.Add(this.guna2PictureBox4);
            this.panel2.Controls.Add(this.guna2HtmlLabel1);
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 620);
            this.panel2.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BorderRadius = 15;
            this.searchBtn.CheckedState.Parent = this.searchBtn;
            this.searchBtn.CustomImages.Parent = this.searchBtn;
            this.searchBtn.Font = new System.Drawing.Font("Fz Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.HoverState.Parent = this.searchBtn;
            this.searchBtn.Location = new System.Drawing.Point(376, 340);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.ShadowDecoration.Parent = this.searchBtn;
            this.searchBtn.Size = new System.Drawing.Size(350, 55);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseTransparentBackground = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.Controls.Add(this.guna2HtmlLabel2);
            this.searchBox.Controls.Add(this.swapBtn);
            this.searchBox.Controls.Add(this.seatClassCB);
            this.searchBox.Controls.Add(this.guna2PictureBox3);
            this.searchBox.Controls.Add(this.typeTicketBtn);
            this.searchBox.Controls.Add(this.reDateChB);
            this.searchBox.Controls.Add(this.label4);
            this.searchBox.Controls.Add(this.deDateBtn);
            this.searchBox.Controls.Add(this.reDateBtn);
            this.searchBox.Controls.Add(this.label2);
            this.searchBox.Controls.Add(this.label1);
            this.searchBox.Controls.Add(this.fromAirportBtn);
            this.searchBox.Controls.Add(this.roundtripRBtn);
            this.searchBox.Controls.Add(this.onewayRBtn);
            this.searchBox.Controls.Add(this.toAirportBtn);
            this.searchBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox.Location = new System.Drawing.Point(13, 28);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Radius = 10;
            this.searchBox.ShadowColor = System.Drawing.Color.Black;
            this.searchBox.ShadowShift = 7;
            this.searchBox.Size = new System.Drawing.Size(1060, 355);
            this.searchBox.TabIndex = 1;
            // 
            // swapBtn
            // 
            this.swapBtn.BackColor = System.Drawing.Color.White;
            this.swapBtn.CheckedState.Parent = this.swapBtn;
            this.swapBtn.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.swapBtn.HoverState.Parent = this.swapBtn;
            this.swapBtn.Image = global::AR_Winform.Properties.Resources.loading_arrow;
            this.swapBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.swapBtn.Location = new System.Drawing.Point(272, 222);
            this.swapBtn.Margin = new System.Windows.Forms.Padding(4);
            this.swapBtn.Name = "swapBtn";
            this.swapBtn.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.swapBtn.PressedState.Parent = this.swapBtn;
            this.swapBtn.Size = new System.Drawing.Size(35, 35);
            this.swapBtn.TabIndex = 15;
            this.swapBtn.Click += new System.EventHandler(this.swapBtn_Click);
            // 
            // seatClassCB
            // 
            this.seatClassCB.BackColor = System.Drawing.Color.Transparent;
            this.seatClassCB.BorderColor = System.Drawing.Color.Black;
            this.seatClassCB.BorderRadius = 10;
            this.seatClassCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.seatClassCB.DropDownHeight = 110;
            this.seatClassCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seatClassCB.DropDownWidth = 180;
            this.seatClassCB.FocusedColor = System.Drawing.Color.Empty;
            this.seatClassCB.FocusedState.Parent = this.seatClassCB;
            this.seatClassCB.Font = new System.Drawing.Font("Fz Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatClassCB.ForeColor = System.Drawing.Color.Black;
            this.seatClassCB.FormattingEnabled = true;
            this.seatClassCB.HoverState.Parent = this.seatClassCB;
            this.seatClassCB.IntegralHeight = false;
            this.seatClassCB.ItemHeight = 30;
            this.seatClassCB.ItemsAppearance.Parent = this.seatClassCB;
            this.seatClassCB.Location = new System.Drawing.Point(290, 102);
            this.seatClassCB.Margin = new System.Windows.Forms.Padding(4);
            this.seatClassCB.Name = "seatClassCB";
            this.seatClassCB.ShadowDecoration.Parent = this.seatClassCB;
            this.seatClassCB.Size = new System.Drawing.Size(160, 36);
            this.seatClassCB.TabIndex = 13;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::AR_Winform.Properties.Resources.right_arrow_tra;
            this.guna2PictureBox3.Location = new System.Drawing.Point(843, 112);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 12;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // typeTicketBtn
            // 
            this.typeTicketBtn.BorderRadius = 10;
            this.typeTicketBtn.BorderThickness = 1;
            this.typeTicketBtn.CheckedState.Parent = this.typeTicketBtn;
            this.typeTicketBtn.CustomImages.Parent = this.typeTicketBtn;
            this.typeTicketBtn.FillColor = System.Drawing.Color.White;
            this.typeTicketBtn.Font = new System.Drawing.Font("Fz Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTicketBtn.ForeColor = System.Drawing.Color.Black;
            this.typeTicketBtn.HoverState.Parent = this.typeTicketBtn;
            this.typeTicketBtn.Image = global::AR_Winform.Properties.Resources.users;
            this.typeTicketBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.typeTicketBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.typeTicketBtn.Location = new System.Drawing.Point(582, 99);
            this.typeTicketBtn.Margin = new System.Windows.Forms.Padding(4);
            this.typeTicketBtn.Name = "typeTicketBtn";
            this.typeTicketBtn.ShadowDecoration.Parent = this.typeTicketBtn;
            this.typeTicketBtn.Size = new System.Drawing.Size(290, 45);
            this.typeTicketBtn.TabIndex = 11;
            this.typeTicketBtn.Text = "1 Adult, 0 Child, 0 Infant (on lap)";
            this.typeTicketBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.typeTicketBtn.Click += new System.EventHandler(this.typeTicketBtn_Click);
            // 
            // reDateChB
            // 
            this.reDateChB.AutoSize = true;
            this.reDateChB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reDateChB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reDateChB.CheckedState.BorderRadius = 2;
            this.reDateChB.CheckedState.BorderThickness = 1;
            this.reDateChB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reDateChB.Enabled = false;
            this.reDateChB.Font = new System.Drawing.Font("Fz Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reDateChB.Location = new System.Drawing.Point(832, 186);
            this.reDateChB.Margin = new System.Windows.Forms.Padding(4);
            this.reDateChB.Name = "reDateChB";
            this.reDateChB.Size = new System.Drawing.Size(118, 30);
            this.reDateChB.TabIndex = 2;
            this.reDateChB.Text = "Return date";
            this.reDateChB.UncheckedState.BorderColor = System.Drawing.Color.DarkGray;
            this.reDateChB.UncheckedState.BorderRadius = 2;
            this.reDateChB.UncheckedState.BorderThickness = 1;
            this.reDateChB.UncheckedState.FillColor = System.Drawing.Color.White;
            this.reDateChB.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fz Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(590, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Departure date";
            // 
            // deDateBtn
            // 
            this.deDateBtn.BorderRadius = 10;
            this.deDateBtn.BorderThickness = 1;
            this.deDateBtn.CheckedState.Parent = this.deDateBtn;
            this.deDateBtn.CustomImages.Parent = this.deDateBtn;
            this.deDateBtn.FillColor = System.Drawing.Color.White;
            this.deDateBtn.Font = new System.Drawing.Font("Fz Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deDateBtn.ForeColor = System.Drawing.Color.Black;
            this.deDateBtn.HoverState.Parent = this.deDateBtn;
            this.deDateBtn.Image = global::AR_Winform.Properties.Resources.calendar;
            this.deDateBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deDateBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.deDateBtn.Location = new System.Drawing.Point(582, 217);
            this.deDateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deDateBtn.Name = "deDateBtn";
            this.deDateBtn.ShadowDecoration.Parent = this.deDateBtn;
            this.deDateBtn.Size = new System.Drawing.Size(220, 45);
            this.deDateBtn.TabIndex = 7;
            this.deDateBtn.Text = "27 Oct 2025";
            this.deDateBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deDateBtn.Click += new System.EventHandler(this.deDateBtn_Click);
            // 
            // reDateBtn
            // 
            this.reDateBtn.BorderRadius = 10;
            this.reDateBtn.BorderThickness = 1;
            this.reDateBtn.CheckedState.Parent = this.reDateBtn;
            this.reDateBtn.CustomImages.Parent = this.reDateBtn;
            this.reDateBtn.Enabled = false;
            this.reDateBtn.FillColor = System.Drawing.Color.White;
            this.reDateBtn.Font = new System.Drawing.Font("Fz Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reDateBtn.ForeColor = System.Drawing.Color.Black;
            this.reDateBtn.HoverState.Parent = this.reDateBtn;
            this.reDateBtn.Image = global::AR_Winform.Properties.Resources.calendar_unchecked;
            this.reDateBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reDateBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.reDateBtn.Location = new System.Drawing.Point(820, 217);
            this.reDateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reDateBtn.Name = "reDateBtn";
            this.reDateBtn.ShadowDecoration.Parent = this.reDateBtn;
            this.reDateBtn.Size = new System.Drawing.Size(220, 45);
            this.reDateBtn.TabIndex = 8;
            this.reDateBtn.Text = "29 Oct 2025";
            this.reDateBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reDateBtn.Click += new System.EventHandler(this.reDateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fz Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fz Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // fromAirportBtn
            // 
            this.fromAirportBtn.BorderRadius = 10;
            this.fromAirportBtn.BorderThickness = 1;
            this.fromAirportBtn.CheckedState.Parent = this.fromAirportBtn;
            this.fromAirportBtn.CustomImages.Parent = this.fromAirportBtn;
            this.fromAirportBtn.FillColor = System.Drawing.Color.White;
            this.fromAirportBtn.Font = new System.Drawing.Font("Fz Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAirportBtn.ForeColor = System.Drawing.Color.Black;
            this.fromAirportBtn.HoverState.Parent = this.fromAirportBtn;
            this.fromAirportBtn.Image = global::AR_Winform.Properties.Resources.take_off;
            this.fromAirportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fromAirportBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.fromAirportBtn.Location = new System.Drawing.Point(20, 217);
            this.fromAirportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.fromAirportBtn.Name = "fromAirportBtn";
            this.fromAirportBtn.ShadowDecoration.Parent = this.fromAirportBtn;
            this.fromAirportBtn.Size = new System.Drawing.Size(270, 45);
            this.fromAirportBtn.TabIndex = 2;
            this.fromAirportBtn.Text = "... (...)";
            this.fromAirportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fromAirportBtn.Click += new System.EventHandler(this.fromAirportBtn_Click);
            // 
            // roundtripRBtn
            // 
            this.roundtripRBtn.AutoSize = true;
            this.roundtripRBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roundtripRBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roundtripRBtn.CheckedState.BorderThickness = 0;
            this.roundtripRBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roundtripRBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.roundtripRBtn.CheckedState.InnerOffset = -4;
            this.roundtripRBtn.Font = new System.Drawing.Font("Fz Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundtripRBtn.ForeColor = System.Drawing.Color.Black;
            this.roundtripRBtn.Location = new System.Drawing.Point(136, 104);
            this.roundtripRBtn.Margin = new System.Windows.Forms.Padding(4);
            this.roundtripRBtn.Name = "roundtripRBtn";
            this.roundtripRBtn.Size = new System.Drawing.Size(112, 30);
            this.roundtripRBtn.TabIndex = 1;
            this.roundtripRBtn.TabStop = true;
            this.roundtripRBtn.Text = "Round-trip";
            this.roundtripRBtn.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.roundtripRBtn.UncheckedState.BorderThickness = 2;
            this.roundtripRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.roundtripRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.roundtripRBtn.UseVisualStyleBackColor = false;
            this.roundtripRBtn.CheckedChanged += new System.EventHandler(this.roundtripRBtn_CheckedChanged);
            // 
            // onewayRBtn
            // 
            this.onewayRBtn.AutoSize = true;
            this.onewayRBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.onewayRBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.onewayRBtn.CheckedState.BorderThickness = 0;
            this.onewayRBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.onewayRBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.onewayRBtn.CheckedState.InnerOffset = -4;
            this.onewayRBtn.Font = new System.Drawing.Font("Fz Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onewayRBtn.Location = new System.Drawing.Point(29, 104);
            this.onewayRBtn.Margin = new System.Windows.Forms.Padding(4);
            this.onewayRBtn.Name = "onewayRBtn";
            this.onewayRBtn.Size = new System.Drawing.Size(99, 30);
            this.onewayRBtn.TabIndex = 0;
            this.onewayRBtn.TabStop = true;
            this.onewayRBtn.Text = "One-way";
            this.onewayRBtn.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.onewayRBtn.UncheckedState.BorderThickness = 2;
            this.onewayRBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.onewayRBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.onewayRBtn.UseVisualStyleBackColor = false;
            this.onewayRBtn.CheckedChanged += new System.EventHandler(this.onewayRBtn_CheckedChanged);
            // 
            // toAirportBtn
            // 
            this.toAirportBtn.BorderRadius = 10;
            this.toAirportBtn.BorderThickness = 1;
            this.toAirportBtn.CheckedState.Parent = this.toAirportBtn;
            this.toAirportBtn.CustomImages.Parent = this.toAirportBtn;
            this.toAirportBtn.FillColor = System.Drawing.Color.White;
            this.toAirportBtn.Font = new System.Drawing.Font("Fz Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAirportBtn.ForeColor = System.Drawing.Color.Black;
            this.toAirportBtn.HoverState.Parent = this.toAirportBtn;
            this.toAirportBtn.Image = global::AR_Winform.Properties.Resources.landing;
            this.toAirportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toAirportBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.toAirportBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.toAirportBtn.Location = new System.Drawing.Point(290, 217);
            this.toAirportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.toAirportBtn.Name = "toAirportBtn";
            this.toAirportBtn.ShadowDecoration.Parent = this.toAirportBtn;
            this.toAirportBtn.Size = new System.Drawing.Size(270, 45);
            this.toAirportBtn.TabIndex = 3;
            this.toAirportBtn.Text = "... (...)";
            this.toAirportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toAirportBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.toAirportBtn.Click += new System.EventHandler(this.toAirportBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::AR_Winform.Properties.Resources.beach2;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1100, 300);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // promotionBox
            // 
            this.promotionBox.BackColor = System.Drawing.Color.Transparent;
            this.promotionBox.Controls.Add(this.promo4);
            this.promotionBox.Controls.Add(this.promo3);
            this.promotionBox.Controls.Add(this.promo2);
            this.promotionBox.Controls.Add(this.promo1);
            this.promotionBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.promotionBox.Location = new System.Drawing.Point(27, 436);
            this.promotionBox.Margin = new System.Windows.Forms.Padding(4);
            this.promotionBox.Name = "promotionBox";
            this.promotionBox.Radius = 10;
            this.promotionBox.ShadowColor = System.Drawing.Color.Black;
            this.promotionBox.ShadowDepth = 50;
            this.promotionBox.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.promotionBox.Size = new System.Drawing.Size(1020, 145);
            this.promotionBox.TabIndex = 3;
            // 
            // promo4
            // 
            this.promo4.FillColor = System.Drawing.Color.White;
            this.promo4.Location = new System.Drawing.Point(771, 17);
            this.promo4.Margin = new System.Windows.Forms.Padding(4);
            this.promo4.Name = "promo4";
            this.promo4.ShadowDecoration.BorderRadius = 20;
            this.promo4.ShadowDecoration.Depth = 12;
            this.promo4.ShadowDecoration.Enabled = true;
            this.promo4.ShadowDecoration.Parent = this.promo4;
            this.promo4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.promo4.Size = new System.Drawing.Size(230, 100);
            this.promo4.TabIndex = 3;
            // 
            // promo3
            // 
            this.promo3.FillColor = System.Drawing.Color.White;
            this.promo3.Location = new System.Drawing.Point(520, 17);
            this.promo3.Margin = new System.Windows.Forms.Padding(4);
            this.promo3.Name = "promo3";
            this.promo3.ShadowDecoration.BorderRadius = 20;
            this.promo3.ShadowDecoration.Depth = 12;
            this.promo3.ShadowDecoration.Enabled = true;
            this.promo3.ShadowDecoration.Parent = this.promo3;
            this.promo3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.promo3.Size = new System.Drawing.Size(230, 100);
            this.promo3.TabIndex = 2;
            // 
            // promo2
            // 
            this.promo2.FillColor = System.Drawing.Color.White;
            this.promo2.Location = new System.Drawing.Point(270, 17);
            this.promo2.Margin = new System.Windows.Forms.Padding(4);
            this.promo2.Name = "promo2";
            this.promo2.ShadowDecoration.BorderRadius = 20;
            this.promo2.ShadowDecoration.Depth = 12;
            this.promo2.ShadowDecoration.Enabled = true;
            this.promo2.ShadowDecoration.Parent = this.promo2;
            this.promo2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.promo2.Size = new System.Drawing.Size(230, 100);
            this.promo2.TabIndex = 1;
            // 
            // promo1
            // 
            this.promo1.FillColor = System.Drawing.Color.White;
            this.promo1.Location = new System.Drawing.Point(19, 17);
            this.promo1.Margin = new System.Windows.Forms.Padding(4);
            this.promo1.Name = "promo1";
            this.promo1.ShadowDecoration.BorderRadius = 20;
            this.promo1.ShadowDecoration.Depth = 12;
            this.promo1.ShadowDecoration.Enabled = true;
            this.promo1.ShadowDecoration.Parent = this.promo1;
            this.promo1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.promo1.Size = new System.Drawing.Size(230, 100);
            this.promo1.TabIndex = 0;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = global::AR_Winform.Properties.Resources.gift_box;
            this.guna2PictureBox4.Location = new System.Drawing.Point(32, 394);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.ShadowDecoration.Parent = this.guna2PictureBox4;
            this.guna2PictureBox4.Size = new System.Drawing.Size(35, 35);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 13;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Fz Poppins SemBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(71, 398);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(230, 30);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "New Friend Promotion Code";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.searchBox;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.promotionBox;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.promo1;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 20;
            this.guna2Elipse4.TargetControl = this.promo2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 20;
            this.guna2Elipse5.TargetControl = this.promo3;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 20;
            this.guna2Elipse6.TargetControl = this.promo4;
            // 
            // headerCntrol1
            // 
            this.headerCntrol1.BackColor = System.Drawing.Color.White;
            this.headerCntrol1.Location = new System.Drawing.Point(-17, 0);
            this.headerCntrol1.Margin = new System.Windows.Forms.Padding(0);
            this.headerCntrol1.Name = "headerCntrol1";
            this.headerCntrol1.Size = new System.Drawing.Size(1100, 100);
            this.headerCntrol1.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Fz Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(358, 26);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(350, 50);
            this.guna2HtmlLabel2.TabIndex = 16;
            this.guna2HtmlLabel2.Text = "SEE THE WORLD FOR LESS";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.headerCntrol1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.promotionBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ShadowPanel searchBox;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2RadioButton roundtripRBtn;
        private Guna.UI2.WinForms.Guna2RadioButton onewayRBtn;
        private Guna.UI2.WinForms.Guna2Button fromAirportBtn;
        private Guna.UI2.WinForms.Guna2Button toAirportBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button deDateBtn;
        private Guna.UI2.WinForms.Guna2Button reDateBtn;
        private Guna.UI2.WinForms.Guna2CheckBox reDateChB;
        private Guna.UI2.WinForms.Guna2ComboBox seatClassCB;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Button typeTicketBtn;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel promotionBox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel promo4;
        private Guna.UI2.WinForms.Guna2Panel promo3;
        private Guna.UI2.WinForms.Guna2Panel promo2;
        private Guna.UI2.WinForms.Guna2Panel promo1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2ImageButton swapBtn;
        private UControls.HeaderCntrol headerCntrol1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}