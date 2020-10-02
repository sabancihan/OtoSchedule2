namespace ScheduleForm
{
    partial class ProgramOlustur
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
            this.dersSecLabel = new System.Windows.Forms.Label();
            this.DersSecDropDown = new System.Windows.Forms.ComboBox();
            this.dersEkleLink = new System.Windows.Forms.LinkLabel();
            this.sectionSecLabel = new System.Windows.Forms.Label();
            this.sectionSecDropDown = new System.Windows.Forms.ComboBox();
            this.secilmemisDerslerListBox = new System.Windows.Forms.ListBox();
            this.olusturButton = new System.Windows.Forms.Button();
            this.ekleButton = new System.Windows.Forms.Button();
            this.geriAlButton = new System.Windows.Forms.Button();
            this.secilmemisDerslerLabel = new System.Windows.Forms.Label();
            this.temizleButton = new System.Windows.Forms.Button();
            this.dersSilButton = new System.Windows.Forms.Button();
            this.devamButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new ScheduleForm.MyTableLayoutPanel();
            this.label11Ders = new System.Windows.Forms.Label();
            this.ders8Label = new System.Windows.Forms.Label();
            this.ders3Label = new System.Windows.Forms.Label();
            this.ders2Label = new System.Windows.Forms.Label();
            this.PazartesiLabel = new System.Windows.Forms.Label();
            this.saliLabel = new System.Windows.Forms.Label();
            this.carsambaLabel = new System.Windows.Forms.Label();
            this.persembeLabel = new System.Windows.Forms.Label();
            this.cumalabel = new System.Windows.Forms.Label();
            this.ders1Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ders5Label = new System.Windows.Forms.Label();
            this.ders6Label = new System.Windows.Forms.Label();
            this.ders7Label = new System.Windows.Forms.Label();
            this.ders9Label = new System.Windows.Forms.Label();
            this.ders10Label = new System.Windows.Forms.Label();
            this.programCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dersSecLabel
            // 
            this.dersSecLabel.AutoSize = true;
            this.dersSecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersSecLabel.Location = new System.Drawing.Point(33, 47);
            this.dersSecLabel.Name = "dersSecLabel";
            this.dersSecLabel.Size = new System.Drawing.Size(168, 39);
            this.dersSecLabel.TabIndex = 0;
            this.dersSecLabel.Text = "Ders Seç";
            // 
            // DersSecDropDown
            // 
            this.DersSecDropDown.FormattingEnabled = true;
            this.DersSecDropDown.Location = new System.Drawing.Point(39, 121);
            this.DersSecDropDown.Name = "DersSecDropDown";
            this.DersSecDropDown.Size = new System.Drawing.Size(271, 21);
            this.DersSecDropDown.TabIndex = 1;
            this.DersSecDropDown.SelectedIndexChanged += new System.EventHandler(this.DersSecDropDown_SelectedIndexChanged);
            // 
            // dersEkleLink
            // 
            this.dersEkleLink.AutoSize = true;
            this.dersEkleLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersEkleLink.LinkColor = System.Drawing.Color.Red;
            this.dersEkleLink.Location = new System.Drawing.Point(232, 68);
            this.dersEkleLink.Name = "dersEkleLink";
            this.dersEkleLink.Size = new System.Drawing.Size(62, 13);
            this.dersEkleLink.TabIndex = 2;
            this.dersEkleLink.TabStop = true;
            this.dersEkleLink.Text = "Ders Ekle";
            this.dersEkleLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dersEkleLink_LinkClicked);
            // 
            // sectionSecLabel
            // 
            this.sectionSecLabel.AutoSize = true;
            this.sectionSecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sectionSecLabel.Location = new System.Drawing.Point(33, 202);
            this.sectionSecLabel.Name = "sectionSecLabel";
            this.sectionSecLabel.Size = new System.Drawing.Size(213, 39);
            this.sectionSecLabel.TabIndex = 3;
            this.sectionSecLabel.Text = "Section Seç";
            // 
            // sectionSecDropDown
            // 
            this.sectionSecDropDown.FormattingEnabled = true;
            this.sectionSecDropDown.Location = new System.Drawing.Point(40, 285);
            this.sectionSecDropDown.Name = "sectionSecDropDown";
            this.sectionSecDropDown.Size = new System.Drawing.Size(270, 21);
            this.sectionSecDropDown.TabIndex = 4;
            this.sectionSecDropDown.SelectedValueChanged += new System.EventHandler(this.sectionSecDropDown_SelectedValueChanged);
            // 
            // secilmemisDerslerListBox
            // 
            this.secilmemisDerslerListBox.FormattingEnabled = true;
            this.secilmemisDerslerListBox.Location = new System.Drawing.Point(39, 457);
            this.secilmemisDerslerListBox.Name = "secilmemisDerslerListBox";
            this.secilmemisDerslerListBox.Size = new System.Drawing.Size(306, 329);
            this.secilmemisDerslerListBox.TabIndex = 5;
            // 
            // olusturButton
            // 
            this.olusturButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olusturButton.Location = new System.Drawing.Point(761, 843);
            this.olusturButton.Name = "olusturButton";
            this.olusturButton.Size = new System.Drawing.Size(169, 40);
            this.olusturButton.TabIndex = 7;
            this.olusturButton.Text = "Oluştur";
            this.olusturButton.UseVisualStyleBackColor = true;
            this.olusturButton.Click += new System.EventHandler(this.olusturButton_Click);
            // 
            // ekleButton
            // 
            this.ekleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButton.Location = new System.Drawing.Point(264, 206);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(81, 40);
            this.ekleButton.TabIndex = 8;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // geriAlButton
            // 
            this.geriAlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriAlButton.Location = new System.Drawing.Point(910, 12);
            this.geriAlButton.Name = "geriAlButton";
            this.geriAlButton.Size = new System.Drawing.Size(169, 37);
            this.geriAlButton.TabIndex = 10;
            this.geriAlButton.Text = "Geri Al";
            this.geriAlButton.UseVisualStyleBackColor = true;
            this.geriAlButton.Click += new System.EventHandler(this.geriAlButton_Click);
            // 
            // secilmemisDerslerLabel
            // 
            this.secilmemisDerslerLabel.AutoSize = true;
            this.secilmemisDerslerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secilmemisDerslerLabel.Location = new System.Drawing.Point(33, 352);
            this.secilmemisDerslerLabel.Name = "secilmemisDerslerLabel";
            this.secilmemisDerslerLabel.Size = new System.Drawing.Size(338, 39);
            this.secilmemisDerslerLabel.TabIndex = 11;
            this.secilmemisDerslerLabel.Text = "Seçilmemiş Dersler";
            // 
            // temizleButton
            // 
            this.temizleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.Location = new System.Drawing.Point(1010, 843);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(169, 40);
            this.temizleButton.TabIndex = 12;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = true;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // dersSilButton
            // 
            this.dersSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersSilButton.Location = new System.Drawing.Point(40, 843);
            this.dersSilButton.Name = "dersSilButton";
            this.dersSilButton.Size = new System.Drawing.Size(169, 40);
            this.dersSilButton.TabIndex = 13;
            this.dersSilButton.Text = "Dersi Sil";
            this.dersSilButton.UseVisualStyleBackColor = true;
            this.dersSilButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // devamButton
            // 
            this.devamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.devamButton.Location = new System.Drawing.Point(761, 843);
            this.devamButton.Name = "devamButton";
            this.devamButton.Size = new System.Drawing.Size(169, 40);
            this.devamButton.TabIndex = 14;
            this.devamButton.Text = "Devam";
            this.devamButton.UseVisualStyleBackColor = true;
            this.devamButton.Click += new System.EventHandler(this.devamButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MintCream;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label11Ders, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.ders8Label, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.ders3Label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ders2Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PazartesiLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.saliLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.carsambaLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.persembeLabel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cumalabel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.ders1Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ders5Label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ders6Label, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ders7Label, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ders9Label, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.ders10Label, 0, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(391, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1158, 742);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label11Ders
            // 
            this.label11Ders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11Ders.Location = new System.Drawing.Point(6, 674);
            this.label11Ders.Name = "label11Ders";
            this.label11Ders.Size = new System.Drawing.Size(44, 65);
            this.label11Ders.TabIndex = 19;
            this.label11Ders.Text = "18:40 - 19:30";
            this.label11Ders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ders8Label
            // 
            this.ders8Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders8Label.Location = new System.Drawing.Point(6, 491);
            this.ders8Label.Name = "ders8Label";
            this.ders8Label.Size = new System.Drawing.Size(44, 57);
            this.ders8Label.TabIndex = 12;
            this.ders8Label.Text = "15:40 - 16:30";
            this.ders8Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ders3Label
            // 
            this.ders3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders3Label.Location = new System.Drawing.Point(6, 186);
            this.ders3Label.Name = "ders3Label";
            this.ders3Label.Size = new System.Drawing.Size(44, 57);
            this.ders3Label.TabIndex = 12;
            this.ders3Label.Text = "10:40 - 11:30";
            this.ders3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ders2Label
            // 
            this.ders2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders2Label.Location = new System.Drawing.Point(6, 125);
            this.ders2Label.Name = "ders2Label";
            this.ders2Label.Size = new System.Drawing.Size(44, 57);
            this.ders2Label.TabIndex = 12;
            this.ders2Label.Text = "9:40 - 10:30";
            this.ders2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PazartesiLabel
            // 
            this.PazartesiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PazartesiLabel.Location = new System.Drawing.Point(59, 3);
            this.PazartesiLabel.Name = "PazartesiLabel";
            this.PazartesiLabel.Size = new System.Drawing.Size(209, 56);
            this.PazartesiLabel.TabIndex = 0;
            this.PazartesiLabel.Text = "Pazartesi";
            this.PazartesiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saliLabel
            // 
            this.saliLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saliLabel.Location = new System.Drawing.Point(279, 3);
            this.saliLabel.Name = "saliLabel";
            this.saliLabel.Size = new System.Drawing.Size(209, 56);
            this.saliLabel.TabIndex = 1;
            this.saliLabel.Text = "Salı";
            this.saliLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carsambaLabel
            // 
            this.carsambaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carsambaLabel.Location = new System.Drawing.Point(499, 3);
            this.carsambaLabel.Name = "carsambaLabel";
            this.carsambaLabel.Size = new System.Drawing.Size(209, 56);
            this.carsambaLabel.TabIndex = 2;
            this.carsambaLabel.Text = "Çarşamba";
            this.carsambaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // persembeLabel
            // 
            this.persembeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.persembeLabel.Location = new System.Drawing.Point(719, 3);
            this.persembeLabel.Name = "persembeLabel";
            this.persembeLabel.Size = new System.Drawing.Size(209, 56);
            this.persembeLabel.TabIndex = 3;
            this.persembeLabel.Text = "Perşembe";
            this.persembeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cumalabel
            // 
            this.cumalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cumalabel.Location = new System.Drawing.Point(939, 3);
            this.cumalabel.Name = "cumalabel";
            this.cumalabel.Size = new System.Drawing.Size(209, 56);
            this.cumalabel.TabIndex = 4;
            this.cumalabel.Text = "Cuma";
            this.cumalabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ders1Label
            // 
            this.ders1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders1Label.Location = new System.Drawing.Point(6, 64);
            this.ders1Label.Name = "ders1Label";
            this.ders1Label.Size = new System.Drawing.Size(44, 58);
            this.ders1Label.TabIndex = 5;
            this.ders1Label.Text = "8:40 - 9:30";
            this.ders1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ders1Label.Click += new System.EventHandler(this.ders1Label_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 57);
            this.label3.TabIndex = 13;
            this.label3.Text = "11:40 - 12:30";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ders5Label
            // 
            this.ders5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders5Label.Location = new System.Drawing.Point(6, 308);
            this.ders5Label.Name = "ders5Label";
            this.ders5Label.Size = new System.Drawing.Size(44, 57);
            this.ders5Label.TabIndex = 14;
            this.ders5Label.Text = "12:40 - 13:30";
            this.ders5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ders5Label.Click += new System.EventHandler(this.label4_Click);
            // 
            // ders6Label
            // 
            this.ders6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders6Label.Location = new System.Drawing.Point(6, 369);
            this.ders6Label.Name = "ders6Label";
            this.ders6Label.Size = new System.Drawing.Size(44, 57);
            this.ders6Label.TabIndex = 15;
            this.ders6Label.Text = "13:40 - 14:30";
            this.ders6Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ders7Label
            // 
            this.ders7Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders7Label.Location = new System.Drawing.Point(6, 430);
            this.ders7Label.Name = "ders7Label";
            this.ders7Label.Size = new System.Drawing.Size(44, 57);
            this.ders7Label.TabIndex = 16;
            this.ders7Label.Text = "14:40 - 15:30";
            this.ders7Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ders9Label
            // 
            this.ders9Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders9Label.Location = new System.Drawing.Point(6, 552);
            this.ders9Label.Name = "ders9Label";
            this.ders9Label.Size = new System.Drawing.Size(44, 57);
            this.ders9Label.TabIndex = 17;
            this.ders9Label.Text = "16:40 - 17:30";
            this.ders9Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ders10Label
            // 
            this.ders10Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ders10Label.Location = new System.Drawing.Point(6, 613);
            this.ders10Label.Name = "ders10Label";
            this.ders10Label.Size = new System.Drawing.Size(44, 57);
            this.ders10Label.TabIndex = 18;
            this.ders10Label.Text = "17:40 - 18:30";
            this.ders10Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // programCountLabel
            // 
            this.programCountLabel.AutoSize = true;
            this.programCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programCountLabel.Location = new System.Drawing.Point(1150, 12);
            this.programCountLabel.Name = "programCountLabel";
            this.programCountLabel.Size = new System.Drawing.Size(209, 39);
            this.programCountLabel.TabIndex = 15;
            this.programCountLabel.Text = "Program : 0";
            // 
            // ProgramOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1574, 895);
            this.Controls.Add(this.programCountLabel);
            this.Controls.Add(this.devamButton);
            this.Controls.Add(this.dersSilButton);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.secilmemisDerslerLabel);
            this.Controls.Add(this.geriAlButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.olusturButton);
            this.Controls.Add(this.secilmemisDerslerListBox);
            this.Controls.Add(this.sectionSecDropDown);
            this.Controls.Add(this.sectionSecLabel);
            this.Controls.Add(this.dersEkleLink);
            this.Controls.Add(this.DersSecDropDown);
            this.Controls.Add(this.dersSecLabel);
            this.DoubleBuffered = true;
            this.Name = "ProgramOlustur";
            this.Text = "ProgramOlustur";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dersSecLabel;
        private System.Windows.Forms.ComboBox DersSecDropDown;
        private System.Windows.Forms.LinkLabel dersEkleLink;
        private System.Windows.Forms.Label sectionSecLabel;
        private System.Windows.Forms.ComboBox sectionSecDropDown;
        private System.Windows.Forms.ListBox secilmemisDerslerListBox;
        private System.Windows.Forms.Button olusturButton;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button geriAlButton;
        private System.Windows.Forms.Label secilmemisDerslerLabel;
        private System.Windows.Forms.Label PazartesiLabel;
        private System.Windows.Forms.Label saliLabel;
        private System.Windows.Forms.Label carsambaLabel;
        private System.Windows.Forms.Label persembeLabel;
        private System.Windows.Forms.Label cumalabel;
        private System.Windows.Forms.Label ders1Label;
        private System.Windows.Forms.Label ders5Label;
        private System.Windows.Forms.Label ders3Label;
        private System.Windows.Forms.Label ders2Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11Ders;
        private System.Windows.Forms.Label ders8Label;
        private System.Windows.Forms.Label ders6Label;
        private System.Windows.Forms.Label ders7Label;
        private System.Windows.Forms.Label ders9Label;
        private System.Windows.Forms.Label ders10Label;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Button dersSilButton;
        private MyTableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button devamButton;
        private System.Windows.Forms.Label programCountLabel;
    }
}