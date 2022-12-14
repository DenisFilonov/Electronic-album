namespace WindowsFormsApp7_pd
{
    partial class Form1
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
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.grbPartOfWorld = new System.Windows.Forms.GroupBox();
            this.rbEurope = new System.Windows.Forms.RadioButton();
            this.rbAsia = new System.Windows.Forms.RadioButton();
            this.rbAfrica = new System.Windows.Forms.RadioButton();
            this.rbNorthAmerica = new System.Windows.Forms.RadioButton();
            this.rbSouthAmerica = new System.Windows.Forms.RadioButton();
            this.rbAustralia = new System.Windows.Forms.RadioButton();
            this.grbCities = new System.Windows.Forms.GroupBox();
            this.pbCities = new System.Windows.Forms.PictureBox();
            this.grbPartOfWorld.SuspendLayout();
            this.grbCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCities)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCities
            // 
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Items.AddRange(new object[] {
            "Берлин",
            "Варшава",
            "Прага",
            "Пекин",
            "Нью-Дели",
            "Токио",
            "Каир",
            "Луанда",
            "Киншаса",
            "Нью-Йорк",
            "Мехико",
            "Чикаго",
            "Рио-де-Жанейро",
            "Сантьяго",
            "Лима",
            "Сидней",
            "Брисбен",
            "Перт"});
            this.cbCities.Location = new System.Drawing.Point(6, 21);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(205, 24);
            this.cbCities.TabIndex = 0;
            this.cbCities.SelectedIndexChanged += new System.EventHandler(this.cbCities_SelectedIndexChanged);
            // 
            // grbPartOfWorld
            // 
            this.grbPartOfWorld.Controls.Add(this.rbEurope);
            this.grbPartOfWorld.Controls.Add(this.rbAsia);
            this.grbPartOfWorld.Controls.Add(this.rbAfrica);
            this.grbPartOfWorld.Controls.Add(this.rbNorthAmerica);
            this.grbPartOfWorld.Controls.Add(this.rbSouthAmerica);
            this.grbPartOfWorld.Controls.Add(this.rbAustralia);
            this.grbPartOfWorld.Location = new System.Drawing.Point(12, 12);
            this.grbPartOfWorld.Name = "grbPartOfWorld";
            this.grbPartOfWorld.Size = new System.Drawing.Size(182, 209);
            this.grbPartOfWorld.TabIndex = 1;
            this.grbPartOfWorld.TabStop = false;
            this.grbPartOfWorld.Text = "Часть света";
            // 
            // rbEurope
            // 
            this.rbEurope.AutoSize = true;
            this.rbEurope.Location = new System.Drawing.Point(16, 30);
            this.rbEurope.Name = "rbEurope";
            this.rbEurope.Size = new System.Drawing.Size(79, 20);
            this.rbEurope.TabIndex = 0;
            this.rbEurope.TabStop = true;
            this.rbEurope.Text = "Европа";
            this.rbEurope.UseVisualStyleBackColor = true;
            this.rbEurope.CheckedChanged += new System.EventHandler(this.RadioButtonChecked);
            // 
            // rbAsia
            // 
            this.rbAsia.AutoSize = true;
            this.rbAsia.Location = new System.Drawing.Point(16, 56);
            this.rbAsia.Name = "rbAsia";
            this.rbAsia.Size = new System.Drawing.Size(60, 20);
            this.rbAsia.TabIndex = 1;
            this.rbAsia.TabStop = true;
            this.rbAsia.Text = "Азия";
            this.rbAsia.UseVisualStyleBackColor = true;
            this.rbAsia.CheckedChanged += new System.EventHandler(this.RadioButtonChecked);
            // 
            // rbAfrica
            // 
            this.rbAfrica.AutoSize = true;
            this.rbAfrica.Location = new System.Drawing.Point(16, 82);
            this.rbAfrica.Name = "rbAfrica";
            this.rbAfrica.Size = new System.Drawing.Size(79, 20);
            this.rbAfrica.TabIndex = 2;
            this.rbAfrica.TabStop = true;
            this.rbAfrica.Text = "Африка";
            this.rbAfrica.UseVisualStyleBackColor = true;
            this.rbAfrica.CheckedChanged += new System.EventHandler(this.RadioButtonChecked);
            // 
            // rbNorthAmerica
            // 
            this.rbNorthAmerica.AutoSize = true;
            this.rbNorthAmerica.Location = new System.Drawing.Point(16, 108);
            this.rbNorthAmerica.Name = "rbNorthAmerica";
            this.rbNorthAmerica.Size = new System.Drawing.Size(152, 20);
            this.rbNorthAmerica.TabIndex = 3;
            this.rbNorthAmerica.TabStop = true;
            this.rbNorthAmerica.Text = "Северная Америка";
            this.rbNorthAmerica.UseVisualStyleBackColor = true;
            this.rbNorthAmerica.CheckedChanged += new System.EventHandler(this.RadioButtonChecked);
            // 
            // rbSouthAmerica
            // 
            this.rbSouthAmerica.AutoSize = true;
            this.rbSouthAmerica.Location = new System.Drawing.Point(16, 134);
            this.rbSouthAmerica.Name = "rbSouthAmerica";
            this.rbSouthAmerica.Size = new System.Drawing.Size(131, 20);
            this.rbSouthAmerica.TabIndex = 4;
            this.rbSouthAmerica.TabStop = true;
            this.rbSouthAmerica.Text = "Южная Америка";
            this.rbSouthAmerica.UseVisualStyleBackColor = true;
            this.rbSouthAmerica.CheckedChanged += new System.EventHandler(this.RadioButtonChecked);
            // 
            // rbAustralia
            // 
            this.rbAustralia.AutoSize = true;
            this.rbAustralia.Location = new System.Drawing.Point(16, 160);
            this.rbAustralia.Name = "rbAustralia";
            this.rbAustralia.Size = new System.Drawing.Size(98, 20);
            this.rbAustralia.TabIndex = 5;
            this.rbAustralia.TabStop = true;
            this.rbAustralia.Text = "Австралия";
            this.rbAustralia.UseVisualStyleBackColor = true;
            this.rbAustralia.CheckedChanged += new System.EventHandler(this.RadioButtonChecked);
            // 
            // grbCities
            // 
            this.grbCities.Controls.Add(this.pbCities);
            this.grbCities.Controls.Add(this.cbCities);
            this.grbCities.Location = new System.Drawing.Point(211, 12);
            this.grbCities.Name = "grbCities";
            this.grbCities.Size = new System.Drawing.Size(734, 554);
            this.grbCities.TabIndex = 2;
            this.grbCities.TabStop = false;
            this.grbCities.Text = "Города";
            // 
            // pbCities
            // 
            this.pbCities.Location = new System.Drawing.Point(6, 54);
            this.pbCities.Name = "pbCities";
            this.pbCities.Size = new System.Drawing.Size(722, 494);
            this.pbCities.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCities.TabIndex = 3;
            this.pbCities.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 597);
            this.Controls.Add(this.grbCities);
            this.Controls.Add(this.grbPartOfWorld);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Города мира";
            this.grbPartOfWorld.ResumeLayout(false);
            this.grbPartOfWorld.PerformLayout();
            this.grbCities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCities;
        private System.Windows.Forms.GroupBox grbPartOfWorld;
        private System.Windows.Forms.RadioButton rbAustralia;
        private System.Windows.Forms.RadioButton rbSouthAmerica;
        private System.Windows.Forms.RadioButton rbNorthAmerica;
        private System.Windows.Forms.RadioButton rbAfrica;
        private System.Windows.Forms.RadioButton rbAsia;
        private System.Windows.Forms.RadioButton rbEurope;
        private System.Windows.Forms.GroupBox grbCities;
        private System.Windows.Forms.PictureBox pbCities;
    }
}

