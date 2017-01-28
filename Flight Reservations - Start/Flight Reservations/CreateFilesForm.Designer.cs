namespace FlightReservationGui
{
    partial class CreateFilesForm
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
            this.btnCreateFlights = new System.Windows.Forms.Button();
            this.btnDisplayFlights = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateFlights
            // 
            this.btnCreateFlights.Location = new System.Drawing.Point(32, 37);
            this.btnCreateFlights.Name = "btnCreateFlights";
            this.btnCreateFlights.Size = new System.Drawing.Size(276, 66);
            this.btnCreateFlights.TabIndex = 0;
            this.btnCreateFlights.Text = "Create the flights.xml file";
            this.btnCreateFlights.UseVisualStyleBackColor = true;
            this.btnCreateFlights.Click += new System.EventHandler(this.btnCreateFlights_Click);
            // 
            // btnDisplayFlights
            // 
            this.btnDisplayFlights.Location = new System.Drawing.Point(339, 37);
            this.btnDisplayFlights.Name = "btnDisplayFlights";
            this.btnDisplayFlights.Size = new System.Drawing.Size(276, 66);
            this.btnDisplayFlights.TabIndex = 2;
            this.btnDisplayFlights.Text = "Display the sample.xml file in a Web browser window";
            this.btnDisplayFlights.UseVisualStyleBackColor = true;
            this.btnDisplayFlights.Click += new System.EventHandler(this.btnDisplayFlights_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 224);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "(status of last operation)";
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 286);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDisplayFlights);
            this.Controls.Add(this.btnCreateFlights);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Reservations 1.0";
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFlights;
        private System.Windows.Forms.Button btnDisplayFlights;
        private System.Windows.Forms.Label lblStatus;
    }
}

