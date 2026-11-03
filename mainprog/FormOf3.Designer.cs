namespace lab5
{
    partial class FormOf3
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
            get_label = new Label();
            button = new Button();
            textBox = new TextBox();
            set_label = new Label();
            history_label = new Label();
            SuspendLayout();
            // 
            // get_label
            // 
            get_label.AutoEllipsis = true;
            get_label.AutoSize = true;
            get_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            get_label.Location = new Point(59, 335);
            get_label.Name = "get_label";
            get_label.Size = new Size(1093, 46);
            get_label.TabIndex = 16;
            get_label.Text = "ПРЕДЛОЖЕНИЕ С УДОВЕННЫЕМИ СОГЛАСНЫМИ ПОЯВИТСЯ ЗДЕСЬ";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(460, 250);
            button.Name = "button";
            button.Size = new Size(309, 60);
            button.TabIndex = 15;
            button.Text = "Напечатать";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(338, 177);
            textBox.Name = "textBox";
            textBox.Size = new Size(846, 51);
            textBox.TabIndex = 14;
            // 
            // set_label
            // 
            set_label.AutoSize = true;
            set_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            set_label.Location = new Point(59, 177);
            set_label.Name = "set_label";
            set_label.Size = new Size(272, 46);
            set_label.TabIndex = 13;
            set_label.Text = "ПРЕДЛОЖЕНИЕ:";
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(65, 41);
            history_label.Name = "history_label";
            history_label.Size = new Size(1133, 81);
            history_label.TabIndex = 12;
            history_label.Text = "Удвоить согласные в предложении";
            // 
            // FormOf3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 401);
            Controls.Add(get_label);
            Controls.Add(button);
            Controls.Add(textBox);
            Controls.Add(set_label);
            Controls.Add(history_label);
            Name = "FormOf3";
            Text = "Удвоить все согласные буквы в предложении";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label get_label;
        private Button button;
        private TextBox textBox;
        private Label set_label;
        private Label history_label;
    }
}