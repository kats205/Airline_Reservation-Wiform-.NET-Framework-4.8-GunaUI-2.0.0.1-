using System.Drawing;

namespace AR_Winform.Presentation.UControls.User
{
    partial class AirportSelector
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
            this.flowAirports = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowAirports
            // 
            this.flowAirports.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowAirports.Location = new System.Drawing.Point(0, 0);
            this.flowAirports.Margin = new System.Windows.Forms.Padding(0);
            this.flowAirports.Name = "flowAirports";
            this.flowAirports.Size = new System.Drawing.Size(290, 250);
            this.flowAirports.TabIndex = 0;
            this.flowAirports.WrapContents = false;
            // 
            // AirportSelector
            // 
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.flowAirports);
            this.Name = "AirportSelector";
            this.Size = new System.Drawing.Size(305, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowAirports;
    }
}
