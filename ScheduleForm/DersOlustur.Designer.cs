namespace ScheduleForm
{
    partial class DersOlustur
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
            this.dersAdıTextBox = new System.Windows.Forms.TextBox();
            this.dersEkleButton = new System.Windows.Forms.Button();
            this.dersEkleLabel = new System.Windows.Forms.Label();
            this.suankiDerslerLabel = new System.Windows.Forms.Label();
            this.suankiDerslerListBox = new System.Windows.Forms.ListBox();
            this.dersKoduTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dersAdıTextBox
            // 
            this.dersAdıTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersAdıTextBox.Location = new System.Drawing.Point(70, 86);
            this.dersAdıTextBox.Name = "dersAdıTextBox";
            this.dersAdıTextBox.Size = new System.Drawing.Size(306, 31);
            this.dersAdıTextBox.TabIndex = 0;
            this.dersAdıTextBox.Text = "Ders Adı Girin";
            // 
            // dersEkleButton
            // 
            this.dersEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersEkleButton.Location = new System.Drawing.Point(170, 180);
            this.dersEkleButton.Name = "dersEkleButton";
            this.dersEkleButton.Size = new System.Drawing.Size(103, 43);
            this.dersEkleButton.TabIndex = 1;
            this.dersEkleButton.Text = "Ekle";
            this.dersEkleButton.UseVisualStyleBackColor = true;
            this.dersEkleButton.Click += new System.EventHandler(this.dersEkleButton_Click);
            // 
            // dersEkleLabel
            // 
            this.dersEkleLabel.AutoSize = true;
            this.dersEkleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersEkleLabel.Location = new System.Drawing.Point(153, 31);
            this.dersEkleLabel.Name = "dersEkleLabel";
            this.dersEkleLabel.Size = new System.Drawing.Size(141, 31);
            this.dersEkleLabel.TabIndex = 2;
            this.dersEkleLabel.Text = "Ders Ekle";
            // 
            // suankiDerslerLabel
            // 
            this.suankiDerslerLabel.AutoSize = true;
            this.suankiDerslerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suankiDerslerLabel.Location = new System.Drawing.Point(120, 226);
            this.suankiDerslerLabel.Name = "suankiDerslerLabel";
            this.suankiDerslerLabel.Size = new System.Drawing.Size(206, 31);
            this.suankiDerslerLabel.TabIndex = 3;
            this.suankiDerslerLabel.Text = "Şuanki Dersler";
            // 
            // suankiDerslerListBox
            // 
            this.suankiDerslerListBox.FormattingEnabled = true;
            this.suankiDerslerListBox.Location = new System.Drawing.Point(99, 276);
            this.suankiDerslerListBox.Name = "suankiDerslerListBox";
            this.suankiDerslerListBox.Size = new System.Drawing.Size(248, 160);
            this.suankiDerslerListBox.TabIndex = 4;
            this.suankiDerslerListBox.SelectedIndexChanged += new System.EventHandler(this.suankiDerslerListBox_SelectedIndexChanged);
            // 
            // dersKoduTextBox
            // 
            this.dersKoduTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersKoduTextBox.Location = new System.Drawing.Point(70, 132);
            this.dersKoduTextBox.Name = "dersKoduTextBox";
            this.dersKoduTextBox.Size = new System.Drawing.Size(306, 31);
            this.dersKoduTextBox.TabIndex = 5;
            this.dersKoduTextBox.Text = "Ders Kodu Girin";
            // 
            // DersOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(485, 481);
            this.Controls.Add(this.dersKoduTextBox);
            this.Controls.Add(this.suankiDerslerListBox);
            this.Controls.Add(this.suankiDerslerLabel);
            this.Controls.Add(this.dersEkleLabel);
            this.Controls.Add(this.dersEkleButton);
            this.Controls.Add(this.dersAdıTextBox);
            this.Name = "DersOlustur";
            this.Text = "DersOlustur";
            this.Load += new System.EventHandler(this.DersOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dersAdıTextBox;
        private System.Windows.Forms.Button dersEkleButton;
        private System.Windows.Forms.Label dersEkleLabel;
        private System.Windows.Forms.Label suankiDerslerLabel;
        private System.Windows.Forms.ListBox suankiDerslerListBox;
        private System.Windows.Forms.TextBox dersKoduTextBox;
    }
}