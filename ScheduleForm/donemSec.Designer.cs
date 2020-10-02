namespace ScheduleForm
{
    partial class donemSec
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
            this.donemSecLabel = new System.Windows.Forms.Label();
            this.donemKoduTextBox = new System.Windows.Forms.TextBox();
            this.kontrolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // donemSecLabel
            // 
            this.donemSecLabel.AutoSize = true;
            this.donemSecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donemSecLabel.Location = new System.Drawing.Point(140, 23);
            this.donemSecLabel.Name = "donemSecLabel";
            this.donemSecLabel.Size = new System.Drawing.Size(260, 39);
            this.donemSecLabel.TabIndex = 1;
            this.donemSecLabel.Text = "Donemi Giriniz";
            this.donemSecLabel.Click += new System.EventHandler(this.dersSecLabel_Click);
            // 
            // donemKoduTextBox
            // 
            this.donemKoduTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donemKoduTextBox.Location = new System.Drawing.Point(59, 87);
            this.donemKoduTextBox.Name = "donemKoduTextBox";
            this.donemKoduTextBox.Size = new System.Drawing.Size(422, 31);
            this.donemKoduTextBox.TabIndex = 6;
            this.donemKoduTextBox.Text = "Donem Kodu Girin Ornek (201902)";
            this.donemKoduTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.donemKoduTextBox.TextChanged += new System.EventHandler(this.donemKoduTextBox_TextChanged);
            // 
            // kontrolButton
            // 
            this.kontrolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontrolButton.Location = new System.Drawing.Point(200, 137);
            this.kontrolButton.Name = "kontrolButton";
            this.kontrolButton.Size = new System.Drawing.Size(140, 36);
            this.kontrolButton.TabIndex = 9;
            this.kontrolButton.Text = "Kontrol";
            this.kontrolButton.UseVisualStyleBackColor = true;
            this.kontrolButton.Click += new System.EventHandler(this.kontrolButton_Click);
            // 
            // donemSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 195);
            this.Controls.Add(this.kontrolButton);
            this.Controls.Add(this.donemKoduTextBox);
            this.Controls.Add(this.donemSecLabel);
            this.Name = "donemSec";
            this.Text = "Donem";
            this.Load += new System.EventHandler(this.donemSec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label donemSecLabel;
        private System.Windows.Forms.TextBox donemKoduTextBox;
        private System.Windows.Forms.Button kontrolButton;
    }
}