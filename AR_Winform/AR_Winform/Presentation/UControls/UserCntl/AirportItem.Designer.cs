using System.Drawing;

namespace AR_Winform.Presentation.UControls
{
    partial class AirportItem
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
            this.airportNameLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.airportCodeLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cityLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.countyLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // airportNameLB
            // 
            this.airportNameLB.BackColor = System.Drawing.Color.Transparent;
            this.airportNameLB.Font = new System.Drawing.Font("Fz Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportNameLB.Location = new System.Drawing.Point(3, 3);
            this.airportNameLB.Name = "airportNameLB";
            this.airportNameLB.Size = new System.Drawing.Size(214, 21);
            this.airportNameLB.TabIndex = 0;
            this.airportNameLB.Text = "Taiwan Taoyuan International Airport";
            // 
            // airportCodeLB
            // 
            this.airportCodeLB.BackColor = System.Drawing.Color.Transparent;
            this.airportCodeLB.Font = new System.Drawing.Font("Fz Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airportCodeLB.Location = new System.Drawing.Point(223, 3);
            this.airportCodeLB.Name = "airportCodeLB";
            this.airportCodeLB.Size = new System.Drawing.Size(21, 21);
            this.airportCodeLB.TabIndex = 1;
            this.airportCodeLB.Text = "TPE";
            // 
            // cityLB
            // 
            this.cityLB.BackColor = System.Drawing.Color.Transparent;
            this.cityLB.Font = new System.Drawing.Font("Fz Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLB.Location = new System.Drawing.Point(3, 3);
            this.cityLB.Name = "cityLB";
            this.cityLB.Size = new System.Drawing.Size(38, 21);
            this.cityLB.TabIndex = 3;
            this.cityLB.Text = "Taipei,";
            // 
            // countyLB
            // 
            this.countyLB.BackColor = System.Drawing.Color.Transparent;
            this.countyLB.Font = new System.Drawing.Font("Fz Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countyLB.Location = new System.Drawing.Point(47, 3);
            this.countyLB.Name = "countyLB";
            this.countyLB.Size = new System.Drawing.Size(42, 21);
            this.countyLB.TabIndex = 4;
            this.countyLB.Text = "Taiwan";
            // 
            // layout
            // 
            this.layout.ColumnCount = 3;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.Controls.Add(this.pictureBox1, 0, 0);
            this.layout.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.layout.Controls.Add(this.flowLayoutPanel2, 2, 1);
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Size = new System.Drawing.Size(280, 70);
            this.layout.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AR_Winform.Properties.Resources.plane;
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.airportNameLB);
            this.flowLayoutPanel1.Controls.Add(this.airportCodeLB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 24);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.cityLB);
            this.flowLayoutPanel2.Controls.Add(this.countyLB);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(29, 38);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(92, 24);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // AirportItem
            // 
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layout);
            this.Name = "AirportItem";
            this.Size = new System.Drawing.Size(280, 70);
            this.Click += new System.EventHandler(this.Item_Click);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel airportNameLB;
        private Guna.UI2.WinForms.Guna2HtmlLabel airportCodeLB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel cityLB;
        private Guna.UI2.WinForms.Guna2HtmlLabel countyLB;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
