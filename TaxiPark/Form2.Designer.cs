namespace TaxiPark
{
    partial class Form2
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
            label1 = new Label();
            listBoxOrders = new ListBox();
            nameLabel = new Label();
            surnameLabel = new Label();
            phoneLabel = new Label();
            yearGraduationLabel = new Label();
            nextStudyLabel = new Label();
            positionLabel = new Label();
            groupLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxId = new TextBox();
            textBoxAdress = new TextBox();
            textBoxRoute = new TextBox();
            textBoxDistance = new TextBox();
            textBoxPrice = new TextBox();
            textBoxTime = new TextBox();
            textBoxDate = new TextBox();
            buttonCar = new Button();
            buttonDriver = new Button();
            buttonAddOrder = new Button();
            buttonAddCar = new Button();
            buttonAddDriver = new Button();
            buttonComplete = new Button();
            buttonRating = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 0;
            label1.Text = "Замовлення";
            // 
            // listBoxOrders
            // 
            listBoxOrders.FormattingEnabled = true;
            listBoxOrders.ItemHeight = 20;
            listBoxOrders.Location = new Point(11, 43);
            listBoxOrders.Name = "listBoxOrders";
            listBoxOrders.Size = new Size(288, 304);
            listBoxOrders.TabIndex = 1;
            listBoxOrders.SelectedIndexChanged += listBoxOrders_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(305, 46);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 23);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "ID:";
            // 
            // surnameLabel
            // 
            surnameLabel.Location = new Point(305, 79);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(100, 23);
            surnameLabel.TabIndex = 16;
            surnameLabel.Text = "Машина: ";
            // 
            // phoneLabel
            // 
            phoneLabel.Location = new Point(305, 112);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(100, 23);
            phoneLabel.TabIndex = 18;
            phoneLabel.Text = "Водій:";
            // 
            // yearGraduationLabel
            // 
            yearGraduationLabel.Location = new Point(305, 145);
            yearGraduationLabel.Name = "yearGraduationLabel";
            yearGraduationLabel.Size = new Size(129, 23);
            yearGraduationLabel.TabIndex = 20;
            yearGraduationLabel.Text = "Адреса машини: ";
            // 
            // nextStudyLabel
            // 
            nextStudyLabel.Location = new Point(305, 178);
            nextStudyLabel.Name = "nextStudyLabel";
            nextStudyLabel.Size = new Size(100, 23);
            nextStudyLabel.TabIndex = 22;
            nextStudyLabel.Text = "Маршрут:";
            // 
            // positionLabel
            // 
            positionLabel.Location = new Point(305, 211);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(100, 23);
            positionLabel.TabIndex = 24;
            positionLabel.Text = "Дистанція: ";
            // 
            // groupLabel
            // 
            groupLabel.Location = new Point(305, 244);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(100, 23);
            groupLabel.TabIndex = 26;
            groupLabel.Text = "Ціна: ";
            // 
            // label2
            // 
            label2.Location = new Point(305, 277);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 27;
            label2.Text = "Дата:";
            // 
            // label3
            // 
            label3.Location = new Point(305, 310);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 28;
            label3.Text = "Час:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(452, 43);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(280, 27);
            textBoxId.TabIndex = 29;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(452, 142);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.ReadOnly = true;
            textBoxAdress.Size = new Size(280, 27);
            textBoxAdress.TabIndex = 32;
            // 
            // textBoxRoute
            // 
            textBoxRoute.Location = new Point(452, 175);
            textBoxRoute.Name = "textBoxRoute";
            textBoxRoute.ReadOnly = true;
            textBoxRoute.Size = new Size(280, 27);
            textBoxRoute.TabIndex = 33;
            // 
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(452, 208);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.ReadOnly = true;
            textBoxDistance.Size = new Size(280, 27);
            textBoxDistance.TabIndex = 34;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(452, 241);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(280, 27);
            textBoxPrice.TabIndex = 35;
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(452, 307);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.ReadOnly = true;
            textBoxTime.Size = new Size(280, 27);
            textBoxTime.TabIndex = 37;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(452, 274);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.Size = new Size(280, 27);
            textBoxDate.TabIndex = 38;
            // 
            // buttonCar
            // 
            buttonCar.Location = new Point(452, 76);
            buttonCar.Name = "buttonCar";
            buttonCar.Size = new Size(280, 27);
            buttonCar.TabIndex = 0;
            buttonCar.Text = "Машина";
            buttonCar.TextAlign = ContentAlignment.BottomLeft;
            buttonCar.UseVisualStyleBackColor = true;
            buttonCar.Click += buttonCar_Click;
            // 
            // buttonDriver
            // 
            buttonDriver.Location = new Point(452, 109);
            buttonDriver.Name = "buttonDriver";
            buttonDriver.Size = new Size(280, 27);
            buttonDriver.TabIndex = 39;
            buttonDriver.Text = "Водій";
            buttonDriver.TextAlign = ContentAlignment.BottomLeft;
            buttonDriver.UseVisualStyleBackColor = true;
            buttonDriver.Click += buttonDriver_Click;
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Location = new Point(153, 15);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(67, 26);
            buttonAddOrder.TabIndex = 40;
            buttonAddOrder.Text = "Додати";
            buttonAddOrder.UseVisualStyleBackColor = true;
            buttonAddOrder.Visible = false;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // buttonAddCar
            // 
            buttonAddCar.Location = new Point(629, 12);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(103, 26);
            buttonAddCar.TabIndex = 41;
            buttonAddCar.Text = "Додати авто";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Visible = false;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // buttonAddDriver
            // 
            buttonAddDriver.Location = new Point(512, 12);
            buttonAddDriver.Name = "buttonAddDriver";
            buttonAddDriver.Size = new Size(111, 26);
            buttonAddDriver.TabIndex = 42;
            buttonAddDriver.Text = "Додати водія";
            buttonAddDriver.UseVisualStyleBackColor = true;
            buttonAddDriver.Visible = false;
            buttonAddDriver.Click += buttonAddDriver_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.Location = new Point(305, 12);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(129, 26);
            buttonComplete.TabIndex = 43;
            buttonComplete.Text = "Виконано";
            buttonComplete.UseVisualStyleBackColor = true;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonRating
            // 
            buttonRating.Location = new Point(613, 109);
            buttonRating.Name = "buttonRating";
            buttonRating.Size = new Size(119, 27);
            buttonRating.TabIndex = 44;
            buttonRating.Text = "Рейтинг водіїв";
            buttonRating.UseVisualStyleBackColor = true;
            buttonRating.Click += buttonRating_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 356);
            Controls.Add(buttonRating);
            Controls.Add(buttonComplete);
            Controls.Add(buttonAddDriver);
            Controls.Add(buttonAddCar);
            Controls.Add(buttonAddOrder);
            Controls.Add(buttonDriver);
            Controls.Add(buttonCar);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxTime);
            Controls.Add(textBoxId);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxRoute);
            Controls.Add(textBoxDistance);
            Controls.Add(textBoxPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameLabel);
            Controls.Add(surnameLabel);
            Controls.Add(phoneLabel);
            Controls.Add(yearGraduationLabel);
            Controls.Add(nextStudyLabel);
            Controls.Add(positionLabel);
            Controls.Add(groupLabel);
            Controls.Add(listBoxOrders);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Таксі-парк";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxOrders;
        private Label nameLabel;
        private Label surnameLabel;
        private Label phoneLabel;
        private Label yearGraduationLabel;
        private Label nextStudyLabel;
        private Label positionLabel;
        private Label groupLabel;
        private Label label2;
        private Label label3;
        private TextBox textBoxId;
        private TextBox textBoxAdress;
        private TextBox textBoxRoute;
        private TextBox textBoxDistance;
        private TextBox textBoxPrice;
        private TextBox textBoxTime;
        private TextBox textBoxDate;
        private Button buttonCar;
        private Button buttonDriver;
        private Button buttonAddOrder;
        private Button buttonAddCar;
        private Button buttonAddDriver;
        private Button buttonComplete;
        private Button buttonRating;
    }
}