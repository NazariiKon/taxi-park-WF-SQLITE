namespace TaxiPark
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelLogin = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 75);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(73, 72);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(205, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(12, 9);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(260, 50);
            labelLogin.TabIndex = 2;
            labelLogin.Text = "Вхід";
            labelLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(12, 122);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(266, 35);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Увійти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 169);
            Controls.Add(buttonLogin);
            Controls.Add(labelLogin);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Name = "Form1";
            Text = "Вхід в систему";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        Label labelEmail;
        TextBox textBoxEmail;
        Button buttonLogin;
        Label labelLogin;
    }
}