namespace TaxiPark
{
    partial class AddCarForm
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
            textBoxRepair = new TextBox();
            repairLabel = new Label();
            textBoxColor = new TextBox();
            textBoxCar = new TextBox();
            textBoxNumber = new TextBox();
            yearLabel = new Label();
            colorLabel = new Label();
            carLabel = new Label();
            numberLabel = new Label();
            buttonAdd = new Button();
            numericUpDownYear = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            SuspendLayout();
            // 
            // textBoxRepair
            // 
            textBoxRepair.Location = new Point(121, 144);
            textBoxRepair.Name = "textBoxRepair";
            textBoxRepair.Size = new Size(272, 27);
            textBoxRepair.TabIndex = 60;
            // 
            // repairLabel
            // 
            repairLabel.Location = new Point(15, 147);
            repairLabel.Name = "repairLabel";
            repairLabel.Size = new Size(100, 23);
            repairLabel.TabIndex = 59;
            repairLabel.Text = "Ремонт:";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(121, 78);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(272, 27);
            textBoxColor.TabIndex = 58;
            // 
            // textBoxCar
            // 
            textBoxCar.Location = new Point(121, 12);
            textBoxCar.Name = "textBoxCar";
            textBoxCar.Size = new Size(272, 27);
            textBoxCar.TabIndex = 55;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(121, 45);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(272, 27);
            textBoxNumber.TabIndex = 56;
            // 
            // yearLabel
            // 
            yearLabel.Location = new Point(15, 114);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(100, 23);
            yearLabel.TabIndex = 54;
            yearLabel.Text = "Рік випуска:";
            // 
            // colorLabel
            // 
            colorLabel.Location = new Point(15, 81);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(100, 23);
            colorLabel.TabIndex = 53;
            colorLabel.Text = "Колір: ";
            // 
            // carLabel
            // 
            carLabel.Location = new Point(15, 15);
            carLabel.Name = "carLabel";
            carLabel.Size = new Size(100, 23);
            carLabel.TabIndex = 51;
            carLabel.Text = "Машина:";
            // 
            // numberLabel
            // 
            numberLabel.Location = new Point(15, 48);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(100, 23);
            numberLabel.TabIndex = 52;
            numberLabel.Text = "Номер:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(15, 177);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(378, 29);
            buttonAdd.TabIndex = 61;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(121, 114);
            numericUpDownYear.Maximum = new decimal(new int[] { 2023, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(272, 27);
            numericUpDownYear.TabIndex = 62;
            numericUpDownYear.Value = new decimal(new int[] { 1990, 0, 0, 0 });
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 214);
            Controls.Add(numericUpDownYear);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxRepair);
            Controls.Add(repairLabel);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxCar);
            Controls.Add(textBoxNumber);
            Controls.Add(yearLabel);
            Controls.Add(colorLabel);
            Controls.Add(carLabel);
            Controls.Add(numberLabel);
            Name = "AddCarForm";
            Text = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRepair;
        private Label repairLabel;
        private TextBox textBoxColor;
        private TextBox textBoxCar;
        private TextBox textBoxNumber;
        private Label yearLabel;
        private Label colorLabel;
        private Label carLabel;
        private Label numberLabel;
        private Button buttonAdd;
        private NumericUpDown numericUpDownYear;
    }
}