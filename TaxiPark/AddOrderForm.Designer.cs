namespace TaxiPark
{
    partial class AddOrderForm
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
            textBoxAdress = new TextBox();
            textBoxRoute = new TextBox();
            label3 = new Label();
            label2 = new Label();
            surnameLabel = new Label();
            phoneLabel = new Label();
            yearGraduationLabel = new Label();
            nextStudyLabel = new Label();
            positionLabel = new Label();
            groupLabel = new Label();
            buttonAdd = new Button();
            comboBoxCars = new ComboBox();
            comboBoxDrivers = new ComboBox();
            numericUpDownPrice = new NumericUpDown();
            dateTimePicker = new DateTimePicker();
            dateTimePickerTime = new DateTimePicker();
            numericUpDownDistance = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).BeginInit();
            SuspendLayout();
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(159, 72);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(280, 27);
            textBoxAdress.TabIndex = 49;
            // 
            // textBoxRoute
            // 
            textBoxRoute.Location = new Point(159, 105);
            textBoxRoute.Name = "textBoxRoute";
            textBoxRoute.Size = new Size(280, 27);
            textBoxRoute.TabIndex = 50;
            // 
            // label3
            // 
            label3.Location = new Point(12, 240);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 48;
            label3.Text = "Час:";
            // 
            // label2
            // 
            label2.Location = new Point(12, 207);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 47;
            label2.Text = "Дата:";
            // 
            // surnameLabel
            // 
            surnameLabel.Location = new Point(12, 9);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(100, 23);
            surnameLabel.TabIndex = 41;
            surnameLabel.Text = "Машина: ";
            // 
            // phoneLabel
            // 
            phoneLabel.Location = new Point(12, 42);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(100, 23);
            phoneLabel.TabIndex = 42;
            phoneLabel.Text = "Водій:";
            // 
            // yearGraduationLabel
            // 
            yearGraduationLabel.Location = new Point(12, 75);
            yearGraduationLabel.Name = "yearGraduationLabel";
            yearGraduationLabel.Size = new Size(129, 23);
            yearGraduationLabel.TabIndex = 43;
            yearGraduationLabel.Text = "Адреса машини: ";
            // 
            // nextStudyLabel
            // 
            nextStudyLabel.Location = new Point(12, 108);
            nextStudyLabel.Name = "nextStudyLabel";
            nextStudyLabel.Size = new Size(100, 23);
            nextStudyLabel.TabIndex = 44;
            nextStudyLabel.Text = "Маршрут:";
            // 
            // positionLabel
            // 
            positionLabel.Location = new Point(12, 141);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(100, 23);
            positionLabel.TabIndex = 45;
            positionLabel.Text = "Дистанція: ";
            // 
            // groupLabel
            // 
            groupLabel.Location = new Point(12, 174);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(100, 23);
            groupLabel.TabIndex = 46;
            groupLabel.Text = "Ціна: ";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 272);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(427, 30);
            buttonAdd.TabIndex = 56;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBoxCars
            // 
            comboBoxCars.FormattingEnabled = true;
            comboBoxCars.Location = new Point(159, 6);
            comboBoxCars.Name = "comboBoxCars";
            comboBoxCars.Size = new Size(280, 28);
            comboBoxCars.TabIndex = 57;
            // 
            // comboBoxDrivers
            // 
            comboBoxDrivers.FormattingEnabled = true;
            comboBoxDrivers.Location = new Point(159, 39);
            comboBoxDrivers.Name = "comboBoxDrivers";
            comboBoxDrivers.Size = new Size(280, 28);
            comboBoxDrivers.TabIndex = 58;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(159, 172);
            numericUpDownPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(280, 27);
            numericUpDownPrice.TabIndex = 59;
            numericUpDownPrice.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(159, 202);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(280, 27);
            dateTimePicker.TabIndex = 60;
            // 
            // dateTimePickerTime
            // 
            dateTimePickerTime.Format = DateTimePickerFormat.Time;
            dateTimePickerTime.Location = new Point(159, 235);
            dateTimePickerTime.Name = "dateTimePickerTime";
            dateTimePickerTime.Size = new Size(280, 27);
            dateTimePickerTime.TabIndex = 61;
            // 
            // numericUpDownDistance
            // 
            numericUpDownDistance.Location = new Point(159, 139);
            numericUpDownDistance.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownDistance.Name = "numericUpDownDistance";
            numericUpDownDistance.Size = new Size(280, 27);
            numericUpDownDistance.TabIndex = 62;
            numericUpDownDistance.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 314);
            Controls.Add(numericUpDownDistance);
            Controls.Add(dateTimePickerTime);
            Controls.Add(dateTimePicker);
            Controls.Add(numericUpDownPrice);
            Controls.Add(comboBoxDrivers);
            Controls.Add(comboBoxCars);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxRoute);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(surnameLabel);
            Controls.Add(phoneLabel);
            Controls.Add(yearGraduationLabel);
            Controls.Add(nextStudyLabel);
            Controls.Add(positionLabel);
            Controls.Add(groupLabel);
            Name = "AddOrderForm";
            Text = "AddOrderForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxAdress;
        private TextBox textBoxRoute;
        private Label label3;
        private Label label2;
        private Label surnameLabel;
        private Label phoneLabel;
        private Label yearGraduationLabel;
        private Label nextStudyLabel;
        private Label positionLabel;
        private Label groupLabel;
        private Button buttonAdd;
        private ComboBox comboBoxCars;
        private ComboBox comboBoxDrivers;
        private NumericUpDown numericUpDownPrice;
        private DateTimePicker dateTimePicker;
        private DateTimePicker dateTimePickerTime;
        private NumericUpDown numericUpDownDistance;
    }
}