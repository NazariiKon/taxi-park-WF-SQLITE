namespace TaxiPark
{
    partial class RatingForm
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
            listBoxRating = new ListBox();
            SuspendLayout();
            // 
            // listBoxRating
            // 
            listBoxRating.FormattingEnabled = true;
            listBoxRating.ItemHeight = 20;
            listBoxRating.Location = new Point(12, 12);
            listBoxRating.Name = "listBoxRating";
            listBoxRating.Size = new Size(458, 224);
            listBoxRating.TabIndex = 0;
            // 
            // RatingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 253);
            Controls.Add(listBoxRating);
            Name = "RatingForm";
            Text = "RatingForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxRating;
    }
}