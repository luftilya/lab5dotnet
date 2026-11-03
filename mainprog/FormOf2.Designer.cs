namespace lab5
{
    partial class FormOf2
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
            history_label = new Label();
            button = new Button();
            textBox = new TextBox();
            set_label = new Label();
            get_label = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(-8, 30);
            history_label.Name = "history_label";
            history_label.Size = new Size(1238, 81);
            history_label.TabIndex = 0;
            history_label.Text = "Напечатать слова в обратном порядке";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(440, 250);
            button.Name = "button";
            button.Size = new Size(309, 60);
            button.TabIndex = 10;
            button.Text = "Напечатать";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(318, 177);
            textBox.Name = "textBox";
            textBox.Size = new Size(846, 51);
            textBox.TabIndex = 7;
            // 
            // set_label
            // 
            set_label.AutoSize = true;
            set_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            set_label.Location = new Point(39, 177);
            set_label.Name = "set_label";
            set_label.Size = new Size(272, 46);
            set_label.TabIndex = 6;
            set_label.Text = "ПРЕДЛОЖЕНИЕ:";
            // 
            // get_label
            // 
            get_label.AutoEllipsis = true;
            get_label.AutoSize = true;
            get_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            get_label.Location = new Point(39, 335);
            get_label.Name = "get_label";
            get_label.Size = new Size(659, 46);
            get_label.TabIndex = 11;
            get_label.Text = "ОБРАТНЫЙ ПОРЯДОК ПОЯВИТСЯ ЗДЕСЬ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(382, 133);
            label1.Name = "label1";
            label1.Size = new Size(723, 41);
            label1.TabIndex = 12;
            label1.Text = "Ожидается ввод слов через запятую без пробелов";
            // 
            // FormOf2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 408);
            Controls.Add(label1);
            Controls.Add(get_label);
            Controls.Add(button);
            Controls.Add(textBox);
            Controls.Add(set_label);
            Controls.Add(history_label);
            Name = "FormOf2";
            Text = "Напечатать слова в обратном порядке";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Button button;
        private TextBox word2_textBox;
        private Label setword2_label;
        private TextBox textBox;
        private Label set_label;
        private Label get_label;
        private Label label1;
    }
}