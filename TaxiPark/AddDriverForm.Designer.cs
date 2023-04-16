namespace TaxiPark
{
    partial class AddDriverForm
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
            textBoxEmail = new TextBox();
            emailLabel = new Label();
            textBoxPass = new TextBox();
            passLabel = new Label();
            textBoxNumber = new TextBox();
            numberLabel = new Label();
            zipcodeLabel = new Label();
            textBoxRegion = new TextBox();
            regionLabel = new Label();
            textBoxAdress = new TextBox();
            textBoxCity = new TextBox();
            textBoxName = new TextBox();
            cityLabel = new Label();
            adressLabel = new Label();
            nameLabel = new Label();
            buttonAdd = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBoxCars = new ComboBox();
            surnameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(118, 237);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(265, 27);
            textBoxEmail.TabIndex = 74;
            // 
            // emailLabel
            // 
            emailLabel.Location = new Point(12, 240);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(100, 23);
            emailLabel.TabIndex = 73;
            emailLabel.Text = "Email: ";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(118, 39);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(265, 27);
            textBoxPass.TabIndex = 72;
            // 
            // passLabel
            // 
            passLabel.Location = new Point(12, 42);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(100, 23);
            passLabel.TabIndex = 71;
            passLabel.Text = "PassId:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(118, 204);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(265, 27);
            textBoxNumber.TabIndex = 70;
            // 
            // numberLabel
            // 
            numberLabel.Location = new Point(12, 207);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(100, 23);
            numberLabel.TabIndex = 69;
            numberLabel.Text = "Номер: ";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.Location = new Point(12, 174);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(100, 23);
            zipcodeLabel.TabIndex = 67;
            zipcodeLabel.Text = "Індекс:";
            // 
            // textBoxRegion
            // 
            textBoxRegion.Location = new Point(118, 138);
            textBoxRegion.Name = "textBoxRegion";
            textBoxRegion.Size = new Size(265, 27);
            textBoxRegion.TabIndex = 66;
            // 
            // regionLabel
            // 
            regionLabel.Location = new Point(12, 141);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new Size(100, 23);
            regionLabel.TabIndex = 65;
            regionLabel.Text = "Регіон:";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(118, 72);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(265, 27);
            textBoxAdress.TabIndex = 64;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(118, 105);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(265, 27);
            textBoxCity.TabIndex = 63;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(118, 6);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(265, 27);
            textBoxName.TabIndex = 62;
            // 
            // cityLabel
            // 
            cityLabel.Location = new Point(12, 108);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(100, 23);
            cityLabel.TabIndex = 61;
            cityLabel.Text = "Місто:";
            // 
            // adressLabel
            // 
            adressLabel.Location = new Point(12, 75);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(100, 23);
            adressLabel.TabIndex = 60;
            adressLabel.Text = "Адреса:";
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 23);
            nameLabel.TabIndex = 59;
            nameLabel.Text = "Ім'я:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 304);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(371, 26);
            buttonAdd.TabIndex = 75;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(118, 171);
            numericUpDown1.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(265, 27);
            numericUpDown1.TabIndex = 76;
            // 
            // comboBoxCars
            // 
            comboBoxCars.FormattingEnabled = true;
            comboBoxCars.Location = new Point(118, 270);
            comboBoxCars.Name = "comboBoxCars";
            comboBoxCars.Size = new Size(265, 28);
            comboBoxCars.TabIndex = 78;
            // 
            // surnameLabel
            // 
            surnameLabel.Location = new Point(12, 273);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(100, 23);
            surnameLabel.TabIndex = 77;
            surnameLabel.Text = "Машина: ";
            // 
            // AddDriverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 338);
            Controls.Add(comboBoxCars);
            Controls.Add(surnameLabel);
            Controls.Add(numericUpDown1);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxEmail);
            Controls.Add(emailLabel);
            Controls.Add(textBoxPass);
            Controls.Add(passLabel);
            Controls.Add(textBoxNumber);
            Controls.Add(numberLabel);
            Controls.Add(zipcodeLabel);
            Controls.Add(textBoxRegion);
            Controls.Add(regionLabel);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxName);
            Controls.Add(cityLabel);
            Controls.Add(adressLabel);
            Controls.Add(nameLabel);
            Name = "AddDriverForm";
            Text = "AddDriverForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEmail;
        private Label emailLabel;
        private TextBox textBoxPass;
        private Label passLabel;
        private TextBox textBoxNumber;
        private Label numberLabel;
        private Label zipcodeLabel;
        private TextBox textBoxRegion;
        private Label regionLabel;
        private TextBox textBoxAdress;
        private TextBox textBoxCity;
        private TextBox textBoxName;
        private Label cityLabel;
        private Label adressLabel;
        private Label nameLabel;
        private Button buttonAdd;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBoxCars;
        private Label surnameLabel;
    }
}