using System.Drawing;
using System.Windows.Forms;

namespace AR_Winform.Presentation.UControls.UserCntl
{
    partial class AllFlights
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
            this.components = new System.ComponentModel.Container();
            this.btnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblToAirport = new System.Windows.Forms.Label();
            this.lblFlightType = new System.Windows.Forms.Label();
            this.lblFromAirport = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBaggage = new System.Windows.Forms.Label();
            this.lblAirlineName = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.BorderRadius = 10;
            this.btnChoose.CheckedState.Parent = this.btnChoose;
            this.btnChoose.CustomImages.Parent = this.btnChoose;
            this.btnChoose.Font = new System.Drawing.Font("Fz Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.HoverState.Parent = this.btnChoose;
            this.btnChoose.Location = new System.Drawing.Point(555, 60);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.ShadowDecoration.Parent = this.btnChoose;
            this.btnChoose.Size = new System.Drawing.Size(150, 40);
            this.btnChoose.TabIndex = 12;
            this.btnChoose.Text = "Choose";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click_1);
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.AutoSize = true;
            this.lblPriceLabel.Font = new System.Drawing.Font("Fz Poppins SemBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.lblPriceLabel.Location = new System.Drawing.Point(542, 33);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.Size = new System.Drawing.Size(164, 28);
            this.lblPriceLabel.TabIndex = 1;
            this.lblPriceLabel.Text = "1.456.289 VND/pax";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Fz Poppins SemBd", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.lblPrice.Location = new System.Drawing.Point(525, 9);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(180, 28);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "1.477.255 VND";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblToAirport
            // 
            this.lblToAirport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblToAirport.ForeColor = System.Drawing.Color.Gray;
            this.lblToAirport.Location = new System.Drawing.Point(338, 35);
            this.lblToAirport.Margin = new System.Windows.Forms.Padding(0);
            this.lblToAirport.Name = "lblToAirport";
            this.lblToAirport.Size = new System.Drawing.Size(150, 18);
            this.lblToAirport.TabIndex = 4;
            this.lblToAirport.Text = "BKK";
            this.lblToAirport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFlightType
            // 
            this.lblFlightType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFlightType.ForeColor = System.Drawing.Color.Gray;
            this.lblFlightType.Location = new System.Drawing.Point(244, 30);
            this.lblFlightType.Name = "lblFlightType";
            this.lblFlightType.Size = new System.Drawing.Size(80, 18);
            this.lblFlightType.TabIndex = 5;
            this.lblFlightType.Text = "━━ Direct ━━";
            this.lblFlightType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromAirport
            // 
            this.lblFromAirport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFromAirport.ForeColor = System.Drawing.Color.Gray;
            this.lblFromAirport.Location = new System.Drawing.Point(75, 33);
            this.lblFromAirport.Margin = new System.Windows.Forms.Padding(0);
            this.lblFromAirport.Name = "lblFromAirport";
            this.lblFromAirport.Size = new System.Drawing.Size(150, 18);
            this.lblFromAirport.TabIndex = 6;
            this.lblFromAirport.Text = "SGN";
            this.lblFromAirport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblArrivalTime.Location = new System.Drawing.Point(330, 7);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(70, 28);
            this.lblArrivalTime.TabIndex = 7;
            this.lblArrivalTime.Text = "19:00";
            this.lblArrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDuration.ForeColor = System.Drawing.Color.Gray;
            this.lblDuration.Location = new System.Drawing.Point(244, 12);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(80, 18);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "1h 30m";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblDepartureTime.Location = new System.Drawing.Point(165, 7);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(70, 28);
            this.lblDepartureTime.TabIndex = 9;
            this.lblDepartureTime.Text = "17:35";
            this.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderColor = System.Drawing.Color.Black;
            this.mainPanel.BorderRadius = 10;
            this.mainPanel.BorderThickness = 1;
            this.mainPanel.Controls.Add(this.btnChoose);
            this.mainPanel.Controls.Add(this.lblBaggage);
            this.mainPanel.Controls.Add(this.lblPriceLabel);
            this.mainPanel.Controls.Add(this.lblAirlineName);
            this.mainPanel.Controls.Add(this.lblPrice);
            this.mainPanel.Controls.Add(this.lblToAirport);
            this.mainPanel.Controls.Add(this.lblDepartureTime);
            this.mainPanel.Controls.Add(this.lblFlightType);
            this.mainPanel.Controls.Add(this.lblDuration);
            this.mainPanel.Controls.Add(this.lblFromAirport);
            this.mainPanel.Controls.Add(this.lblArrivalTime);
            this.mainPanel.Location = new System.Drawing.Point(0, 10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(730, 110);
            this.mainPanel.TabIndex = 1;
            // 
            // lblBaggage
            // 
            this.lblBaggage.AutoSize = true;
            this.lblBaggage.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBaggage.ForeColor = System.Drawing.Color.Gray;
            this.lblBaggage.Location = new System.Drawing.Point(10, 35);
            this.lblBaggage.Name = "lblBaggage";
            this.lblBaggage.Size = new System.Drawing.Size(41, 15);
            this.lblBaggage.TabIndex = 12;
            this.lblBaggage.Text = "🎒 0kg";
            // 
            // lblAirlineName
            // 
            this.lblAirlineName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAirlineName.Location = new System.Drawing.Point(3, 7);
            this.lblAirlineName.Name = "lblAirlineName";
            this.lblAirlineName.Size = new System.Drawing.Size(150, 22);
            this.lblAirlineName.TabIndex = 13;
            this.lblAirlineName.Text = "VietJet Air";
            // 
            // AllFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AllFlights";
            this.Size = new System.Drawing.Size(730, 130);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

            #endregion
        private Label lblDepartureTime;
        private Label lblDuration;
        private Label lblArrivalTime;
        private Label lblFromAirport;
        private Label lblFlightType;
        private Label lblToAirport;
        private Label lblPrice;
        private Label lblPriceLabel;
        private Guna.UI2.WinForms.Guna2Button btnChoose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Label lblBaggage;
        private Label lblAirlineName;
    }
}
