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
            textBoxDate = new TextBox();
            textBoxTime = new TextBox();
            textBoxAdress = new TextBox();
            textBoxRoute = new TextBox();
            textBoxDistance = new TextBox();
            textBoxPrice = new TextBox();
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
            SuspendLayout();
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(159, 204);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(280, 27);
            textBoxDate.TabIndex = 54;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(159, 237);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(280, 27);
            textBoxTime.TabIndex = 53;
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
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(159, 138);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.Size = new Size(280, 27);
            textBoxDistance.TabIndex = 51;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(159, 171);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(280, 27);
            textBoxPrice.TabIndex = 52;
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
            buttonAdd.Location = new Point(12, 270);
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
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 312);
            Controls.Add(comboBoxDrivers);
            Controls.Add(comboBoxCars);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxTime);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxRoute);
            Controls.Add(textBoxDistance);
            Controls.Add(textBoxPrice);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDate;
        private TextBox textBoxTime;
        private TextBox textBoxAdress;
        private TextBox textBoxRoute;
        private TextBox textBoxDistance;
        private TextBox textBoxPrice;
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
    }
}