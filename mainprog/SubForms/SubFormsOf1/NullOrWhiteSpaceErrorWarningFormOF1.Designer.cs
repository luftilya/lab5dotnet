namespace Lab5.SubForms.SubFormsOf1
{
    partial class NullOrWhiteSpaceErrorWarningFormOf1
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
            infoLabel = new Label();
            errorLabel = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            infoLabel.Location = new Point(12, 168);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(929, 120);
            infoLabel.TabIndex = 5;
            infoLabel.Text = "Строка пуста или содержит только пробелы.\r\nВведите что-либо и попробуйте заново";
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            errorLabel.ForeColor = Color.DarkRed;
            errorLabel.Location = new Point(172, 9);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(611, 159);
            errorLabel.TabIndex = 4;
            errorLabel.Text = "ОШИБКА!";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button
            // 
            button.BackColor = Color.White;
            button.Font = new Font("Segoe UI Black", 40F, FontStyle.Bold);
            button.Location = new Point(320, 320);
            button.Margin = new Padding(0);
            button.Name = "button";
            button.Size = new Size(334, 94);
            button.TabIndex = 3;
            button.Text = "ОК";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // NullOrWhiteSpaceErrorWarningFormOf1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(982, 453);
            Controls.Add(infoLabel);
            Controls.Add(errorLabel);
            Controls.Add(button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NullOrWhiteSpaceErrorWarningFormOf1";
            Text = "Ошибка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoLabel;
        private Label errorLabel;
        private Button button;
    }
}