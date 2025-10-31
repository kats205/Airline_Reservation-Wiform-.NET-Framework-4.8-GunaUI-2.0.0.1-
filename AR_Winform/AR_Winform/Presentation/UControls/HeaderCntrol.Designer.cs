using System.Drawing;

namespace AR_Winform.Presentation.UControls
{
    partial class HeaderCntrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pointPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.promotionBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.supportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.bookingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointPicture)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.pointPicture);
            this.guna2Panel1.Controls.Add(this.loginBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(809, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(291, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pointPicture
            // 
            this.pointPicture.BackColor = System.Drawing.Color.Transparent;
            this.pointPicture.Image = global::AR_Winform.Properties.Resources.coin;
            this.pointPicture.Location = new System.Drawing.Point(172, 37);
            this.pointPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pointPicture.Name = "pointPicture";
            this.pointPicture.ShadowDecoration.Parent = this.pointPicture;
            this.pointPicture.Size = new System.Drawing.Size(30, 30);
            this.pointPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pointPicture.TabIndex = 4;
            this.pointPicture.TabStop = false;
            this.pointPicture.UseTransparentBackground = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 25;
            this.loginBtn.BorderThickness = 1;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.White;
            this.loginBtn.Font = new System.Drawing.Font("Fz Poppins SemBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Image = global::AR_Winform.Properties.Resources.user;
            this.loginBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.loginBtn.Location = new System.Drawing.Point(11, 12);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(271, 80);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "User Name  |           0 Point";
            this.loginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.promotionBtn);
            this.guna2Panel2.Location = new System.Drawing.Point(325, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(160, 100);
            this.guna2Panel2.TabIndex = 1;
            // 
            // promotionBtn
            // 
            this.promotionBtn.CheckedState.Parent = this.promotionBtn;
            this.promotionBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.promotionBtn.CustomImages.Parent = this.promotionBtn;
            this.promotionBtn.FillColor = System.Drawing.Color.White;
            this.promotionBtn.Font = new System.Drawing.Font("Fz Poppins SemBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promotionBtn.ForeColor = System.Drawing.Color.Black;
            this.promotionBtn.HoverState.Parent = this.promotionBtn;
            this.promotionBtn.Image = global::AR_Winform.Properties.Resources.gift_voucher;
            this.promotionBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.promotionBtn.Location = new System.Drawing.Point(6, 0);
            this.promotionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.promotionBtn.Name = "promotionBtn";
            this.promotionBtn.ShadowDecoration.Parent = this.promotionBtn;
            this.promotionBtn.Size = new System.Drawing.Size(150, 100);
            this.promotionBtn.TabIndex = 1;
            this.promotionBtn.Text = "Promotions";
            this.promotionBtn.Click += new System.EventHandler(this.promotionBtn_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.supportBtn);
            this.guna2Panel3.Location = new System.Drawing.Point(487, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(160, 100);
            this.guna2Panel3.TabIndex = 2;
            // 
            // supportBtn
            // 
            this.supportBtn.CheckedState.Parent = this.supportBtn;
            this.supportBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.supportBtn.CustomImages.Parent = this.supportBtn;
            this.supportBtn.FillColor = System.Drawing.Color.White;
            this.supportBtn.Font = new System.Drawing.Font("Fz Poppins SemBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportBtn.ForeColor = System.Drawing.Color.Black;
            this.supportBtn.HoverState.Parent = this.supportBtn;
            this.supportBtn.Image = global::AR_Winform.Properties.Resources.right_arrow_tra;
            this.supportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.supportBtn.ImageOffset = new System.Drawing.Point(10, -1);
            this.supportBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.supportBtn.Location = new System.Drawing.Point(4, 0);
            this.supportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.supportBtn.Name = "supportBtn";
            this.supportBtn.ShadowDecoration.Parent = this.supportBtn;
            this.supportBtn.Size = new System.Drawing.Size(152, 98);
            this.supportBtn.TabIndex = 1;
            this.supportBtn.Text = "Support";
            this.supportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.supportBtn.TextOffset = new System.Drawing.Point(-10, 0);
            this.supportBtn.Click += new System.EventHandler(this.supportBtn_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.Controls.Add(this.bookingBtn);
            this.guna2Panel4.Location = new System.Drawing.Point(648, 0);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(160, 100);
            this.guna2Panel4.TabIndex = 3;
            // 
            // bookingBtn
            // 
            this.bookingBtn.CheckedState.Parent = this.bookingBtn;
            this.bookingBtn.CustomBorderColor = System.Drawing.Color.Black;
            this.bookingBtn.CustomImages.Parent = this.bookingBtn;
            this.bookingBtn.FillColor = System.Drawing.Color.White;
            this.bookingBtn.Font = new System.Drawing.Font("Fz Poppins SemBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.ForeColor = System.Drawing.Color.Black;
            this.bookingBtn.HoverState.Parent = this.bookingBtn;
            this.bookingBtn.Image = global::AR_Winform.Properties.Resources.order;
            this.bookingBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.bookingBtn.Location = new System.Drawing.Point(4, 2);
            this.bookingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.ShadowDecoration.Parent = this.bookingBtn;
            this.bookingBtn.Size = new System.Drawing.Size(149, 98);
            this.bookingBtn.TabIndex = 1;
            this.bookingBtn.Text = "Bookings";
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // HeaderCntrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HeaderCntrol";
            this.Size = new System.Drawing.Size(1100, 100);
            this.Load += new System.EventHandler(this.HeaderCntrol_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointPicture)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button promotionBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button supportBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button bookingBtn;
        private Guna.UI2.WinForms.Guna2PictureBox pointPicture;
    }
}
