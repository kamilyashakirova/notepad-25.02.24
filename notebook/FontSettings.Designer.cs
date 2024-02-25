namespace notebook
{
    partial class FontSettings
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
            this.example = new System.Windows.Forms.Label();
            this.examplefont = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fontchange = new System.Windows.Forms.Label();
            this.sizebox = new System.Windows.Forms.ComboBox();
            this.stylebox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // example
            // 
            this.example.AutoSize = true;
            this.example.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.example.Location = new System.Drawing.Point(12, 106);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(73, 18);
            this.example.TabIndex = 0;
            this.example.Text = "Образец:";
            this.example.Click += new System.EventHandler(this.example_Click);
            // 
            // examplefont
            // 
            this.examplefont.AutoSize = true;
            this.examplefont.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.examplefont.Location = new System.Drawing.Point(9, 133);
            this.examplefont.Name = "examplefont";
            this.examplefont.Size = new System.Drawing.Size(169, 32);
            this.examplefont.TabIndex = 1;
            this.examplefont.Text = "Aa Bb Yy Zz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(187, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Размер";
            // 
            // fontchange
            // 
            this.fontchange.AutoSize = true;
            this.fontchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontchange.Location = new System.Drawing.Point(9, 9);
            this.fontchange.Name = "fontchange";
            this.fontchange.Size = new System.Drawing.Size(90, 18);
            this.fontchange.TabIndex = 5;
            this.fontchange.Text = "Начертание";
            this.fontchange.Click += new System.EventHandler(this.fontchange_Click);
            // 
            // sizebox
            // 
            this.sizebox.AutoCompleteCustomSource.AddRange(new string[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.sizebox.FormattingEnabled = true;
            this.sizebox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "22"});
            this.sizebox.Location = new System.Drawing.Point(190, 30);
            this.sizebox.Name = "sizebox";
            this.sizebox.Size = new System.Drawing.Size(149, 24);
            this.sizebox.TabIndex = 6;
            this.sizebox.SelectedIndexChanged += new System.EventHandler(this.OnSize);
            this.sizebox.Click += new System.EventHandler(this.OnStyle);
            // 
            // stylebox
            // 
            this.stylebox.FormattingEnabled = true;
            this.stylebox.Items.AddRange(new object[] {
            "обычный ",
            "курсив",
            "полужирный",
            "подчёркивание"});
            this.stylebox.Location = new System.Drawing.Point(12, 30);
            this.stylebox.Name = "stylebox";
            this.stylebox.Size = new System.Drawing.Size(149, 24);
            this.stylebox.TabIndex = 7;
            this.stylebox.SelectedIndexChanged += new System.EventHandler(this.OnStyle);
            this.stylebox.SelectedValueChanged += new System.EventHandler(this.OnStyle);
            this.stylebox.Click += new System.EventHandler(this.OnStyle);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorbox
            // 
            this.colorbox.AutoCompleteCustomSource.AddRange(new string[] {
            "черный",
            "красный",
            "синий",
            "фиолетовый",
            "зелёный"});
            this.colorbox.FormattingEnabled = true;
            this.colorbox.Items.AddRange(new object[] {
            "чёрный ",
            "синий",
            "зелёный",
            "фиолетовый",
            "красный"});
            this.colorbox.Location = new System.Drawing.Point(367, 30);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(149, 24);
            this.colorbox.TabIndex = 9;
            this.colorbox.SelectedIndexChanged += new System.EventHandler(this.OnColor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Цвет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stylebox);
            this.Controls.Add(this.sizebox);
            this.Controls.Add(this.fontchange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.examplefont);
            this.Controls.Add(this.example);
            this.Name = "FontSettings";
            this.Text = "Шрифт";
            this.Load += new System.EventHandler(this.FontSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label example;
        private System.Windows.Forms.Label examplefont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fontchange;
        private System.Windows.Forms.ComboBox sizebox;
        private System.Windows.Forms.ComboBox stylebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox colorbox;
        private System.Windows.Forms.Label label1;
    }
}