using System.Drawing;
using System.Reflection.Emit;

namespace AR_Winform.Presentation.UControls
{
    partial class PromotionCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.promoCodeLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.copyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.descLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.discountLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.promoCodeLB);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 25);
            this.panel1.TabIndex = 0;
            // 
            // promoCodeLB
            // 
            this.promoCodeLB.AutoSize = false;
            this.promoCodeLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.promoCodeLB.Font = new System.Drawing.Font("Fz Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promoCodeLB.Location = new System.Drawing.Point(29, 0);
            this.promoCodeLB.Name = "promoCodeLB";
            this.promoCodeLB.Size = new System.Drawing.Size(100, 25);
            this.promoCodeLB.TabIndex = 1;
            this.promoCodeLB.Text = "TVLKBANMOI";
            this.promoCodeLB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2PictureBox1.Image = global::AR_Winform.Properties.Resources.copy1;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // copyBtn
            // 
            this.copyBtn.BorderRadius = 11;
            this.copyBtn.CheckedState.Parent = this.copyBtn;
            this.copyBtn.CustomImages.Parent = this.copyBtn;
            this.copyBtn.Font = new System.Drawing.Font("Fz Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.ForeColor = System.Drawing.Color.White;
            this.copyBtn.HoverState.Parent = this.copyBtn;
            this.copyBtn.Location = new System.Drawing.Point(171, 68);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.ShadowDecoration.Parent = this.copyBtn;
            this.copyBtn.Size = new System.Drawing.Size(50, 25);
            this.copyBtn.TabIndex = 1;
            this.copyBtn.Text = "Copy";
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // descLB
            // 
            this.descLB.BackColor = System.Drawing.Color.Transparent;
            this.descLB.Font = new System.Drawing.Font("Fz Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLB.Location = new System.Drawing.Point(39, 40);
            this.descLB.Name = "descLB";
            this.descLB.Size = new System.Drawing.Size(175, 24);
            this.descLB.TabIndex = 2;
            this.descLB.Text = "Black Friday Sale - Giảm 25%";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Fz Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(39, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(63, 24);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Giảm đến";
            // 
            // discountLB
            // 
            this.discountLB.BackColor = System.Drawing.Color.Transparent;
            this.discountLB.Font = new System.Drawing.Font("Fz Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLB.Location = new System.Drawing.Point(103, 2);
            this.discountLB.Name = "discountLB";
            this.discountLB.Size = new System.Drawing.Size(29, 24);
            this.discountLB.TabIndex = 5;
            this.discountLB.Text = "20%";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Fz Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(133, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(67, 24);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "bắt đầu từ";
            // 
            // dateLB
            // 
            this.dateLB.BackColor = System.Drawing.Color.Transparent;
            this.dateLB.Font = new System.Drawing.Font("Fz Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLB.Location = new System.Drawing.Point(39, 20);
            this.dateLB.Name = "dateLB";
            this.dateLB.Size = new System.Drawing.Size(153, 24);
            this.dateLB.TabIndex = 7;
            this.dateLB.Text = "20/10/2025 - 30/10/2025";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox2.Image = global::AR_Winform.Properties.Resources.sale;
            this.guna2PictureBox2.Location = new System.Drawing.Point(4, 6);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 8;
            this.guna2PictureBox2.TabStop = false;
            // 
            // PromotionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.dateLB);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.descLB);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.discountLB);
            this.Name = "PromotionCard";
            this.Size = new System.Drawing.Size(230, 100);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button copyBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel promoCodeLB;
        private Guna.UI2.WinForms.Guna2HtmlLabel descLB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel discountLB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel dateLB;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}
