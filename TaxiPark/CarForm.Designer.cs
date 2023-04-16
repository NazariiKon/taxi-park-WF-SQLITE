namespace TaxiPark
{
    partial class CarForm
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
            colorTextBox = new TextBox();
            gradYearLabel = new Label();
            gradYearTextBox = new TextBox();
            repairTextBox = new TextBox();
            textBoxColor = new TextBox();
            textBoxYear = new TextBox();
            textBoxId = new TextBox();
            textBoxCar = new TextBox();
            textBoxNumber = new TextBox();
            yearLabel = new Label();
            colorLabel = new Label();
            idLabel = new Label();
            carLabel = new Label();
            numberLabel = new Label();
            textBoxRepair = new TextBox();
            repairLabel = new Label();
            SuspendLayout();
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(0, 0);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(100, 27);
            colorTextBox.TabIndex = 0;
            // 
            // gradYearLabel
            // 
            gradYearLabel.Location = new Point(0, 0);
            gradYearLabel.Name = "gradYearLabel";
            gradYearLabel.Size = new Size(100, 23);
            gradYearLabel.TabIndex = 0;
            // 
            // gradYearTextBox
            // 
            gradYearTextBox.Location = new Point(0, 0);
            gradYearTextBox.Name = "gradYearTextBox";
            gradYearTextBox.Size = new Size(100, 27);
            gradYearTextBox.TabIndex = 0;
            // 
            // repairTextBox
            // 
            repairTextBox.Location = new Point(0, 0);
            repairTextBox.Name = "repairTextBox";
            repairTextBox.Size = new Size(100, 27);
            repairTextBox.TabIndex = 0;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(118, 105);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.ReadOnly = true;
            textBoxColor.Size = new Size(272, 27);
            textBoxColor.TabIndex = 48;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(118, 138);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.ReadOnly = true;
            textBoxYear.Size = new Size(272, 27);
            textBoxYear.TabIndex = 47;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(118, 6);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(272, 27);
            textBoxId.TabIndex = 44;
            // 
            // textBoxCar
            // 
            textBoxCar.Location = new Point(118, 39);
            textBoxCar.Name = "textBoxCar";
            textBoxCar.ReadOnly = true;
            textBoxCar.Size = new Size(272, 27);
            textBoxCar.TabIndex = 45;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(118, 72);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.ReadOnly = true;
            textBoxNumber.Size = new Size(272, 27);
            textBoxNumber.TabIndex = 46;
            // 
            // yearLabel
            // 
            yearLabel.Location = new Point(12, 141);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(100, 23);
            yearLabel.TabIndex = 43;
            yearLabel.Text = "Рік випуска:";
            // 
            // colorLabel
            // 
            colorLabel.Location = new Point(12, 108);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(100, 23);
            colorLabel.TabIndex = 42;
            colorLabel.Text = "Колір: ";
            // 
            // idLabel
            // 
            idLabel.Location = new Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(100, 23);
            idLabel.TabIndex = 39;
            idLabel.Text = "ID:";
            // 
            // carLabel
            // 
            carLabel.Location = new Point(12, 42);
            carLabel.Name = "carLabel";
            carLabel.Size = new Size(100, 23);
            carLabel.TabIndex = 40;
            carLabel.Text = "Машина:";
            // 
            // numberLabel
            // 
            numberLabel.Location = new Point(12, 75);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(100, 23);
            numberLabel.TabIndex = 41;
            numberLabel.Text = "Номер:";
            // 
            // textBoxRepair
            // 
            textBoxRepair.Location = new Point(118, 171);
            textBoxRepair.Name = "textBoxRepair";
            textBoxRepair.ReadOnly = true;
            textBoxRepair.Size = new Size(272, 27);
            textBoxRepair.TabIndex = 50;
            // 
            // repairLabel
            // 
            repairLabel.Location = new Point(12, 174);
            repairLabel.Name = "repairLabel";
            repairLabel.Size = new Size(100, 23);
            repairLabel.TabIndex = 49;
            repairLabel.Text = "Ремонт:";
            // 
            // CarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 212);
            Controls.Add(textBoxRepair);
            Controls.Add(repairLabel);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxId);
            Controls.Add(textBoxCar);
            Controls.Add(textBoxNumber);
            Controls.Add(yearLabel);
            Controls.Add(colorLabel);
            Controls.Add(idLabel);
            Controls.Add(carLabel);
            Controls.Add(numberLabel);
            Name = "CarForm";
            Text = "Інформація про авто";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox colorTextBox;
        private Label gradYearLabel;
        private TextBox gradYearTextBox;
        private TextBox repairTextBox;
        private TextBox textBoxColor;
        private TextBox textBoxYear;
        private TextBox textBoxId;
        private TextBox textBoxCar;
        private TextBox textBoxNumber;
        private Label yearLabel;
        private Label colorLabel;
        private Label idLabel;
        private Label carLabel;
        private Label numberLabel;
        private TextBox textBoxRepair;
        private Label repairLabel;
    }
}