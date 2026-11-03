namespace lab5
{
    partial class FormOf1
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
            setword1_label = new Label();
            word1_textBox = new TextBox();
            setword2_label = new Label();
            word2_textBox = new TextBox();
            button = new Button();
            mostlong_label = new Label();
            howlong_label = new Label();
            setmostlong_label = new Label();
            sethowlong_label = new Label();
            SuspendLayout();
            // 
            // history_label
            // 
            history_label.AutoSize = true;
            history_label.Font = new Font("Segoe UI Black", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            history_label.Location = new Point(12, 9);
            history_label.Name = "history_label";
            history_label.Size = new Size(1256, 60);
            history_label.TabIndex = 0;
            history_label.Text = "Определить, какое из двух слов длиннее и насколько";
            // 
            // setword1_label
            // 
            setword1_label.AutoSize = true;
            setword1_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setword1_label.Location = new Point(89, 128);
            setword1_label.Name = "setword1_label";
            setword1_label.Size = new Size(273, 46);
            setword1_label.TabIndex = 1;
            setword1_label.Text = "ПЕРВОЕ СЛОВО:";
            // 
            // word1_textBox
            // 
            word1_textBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            word1_textBox.Location = new Point(368, 128);
            word1_textBox.Name = "word1_textBox";
            word1_textBox.Size = new Size(846, 51);
            word1_textBox.TabIndex = 2;
            // 
            // setword2_label
            // 
            setword2_label.AutoSize = true;
            setword2_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setword2_label.Location = new Point(86, 210);
            setword2_label.Name = "setword2_label";
            setword2_label.Size = new Size(276, 46);
            setword2_label.TabIndex = 3;
            setword2_label.Text = "ВТОРОЕ СЛОВО:";
            // 
            // word2_textBox
            // 
            word2_textBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            word2_textBox.Location = new Point(368, 210);
            word2_textBox.Name = "word2_textBox";
            word2_textBox.Size = new Size(846, 51);
            word2_textBox.TabIndex = 4;
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button.Location = new Point(490, 291);
            button.Name = "button";
            button.Size = new Size(309, 60);
            button.TabIndex = 5;
            button.Text = "Определить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // mostlong_label
            // 
            mostlong_label.AutoSize = true;
            mostlong_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mostlong_label.Location = new Point(128, 383);
            mostlong_label.Name = "mostlong_label";
            mostlong_label.Size = new Size(433, 46);
            mostlong_label.TabIndex = 6;
            mostlong_label.Text = "САМОЕ ДЛИННОЕ СЛОВО";
            // 
            // howlong_label
            // 
            howlong_label.AutoSize = true;
            howlong_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            howlong_label.Location = new Point(154, 488);
            howlong_label.Name = "howlong_label";
            howlong_label.Size = new Size(385, 46);
            howlong_label.TabIndex = 7;
            howlong_label.Text = "НАСКОЛЬКО ДЛИННЕЕ";
            // 
            // setmostlong_label
            // 
            setmostlong_label.AutoSize = true;
            setmostlong_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            setmostlong_label.Location = new Point(797, 383);
            setmostlong_label.Name = "setmostlong_label";
            setmostlong_label.Size = new Size(363, 46);
            setmostlong_label.TabIndex = 8;
            setmostlong_label.Text = "ЕЩЁ НЕ ОПРЕДЕЛЕНО";
            // 
            // sethowlong_label
            // 
            sethowlong_label.AutoSize = true;
            sethowlong_label.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sethowlong_label.Location = new Point(797, 488);
            sethowlong_label.Name = "sethowlong_label";
            sethowlong_label.Size = new Size(363, 46);
            sethowlong_label.TabIndex = 9;
            sethowlong_label.Text = "ЕЩЁ НЕ ОПРЕДЕЛЕНО";
            // 
            // FormOf1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 623);
            Controls.Add(sethowlong_label);
            Controls.Add(setmostlong_label);
            Controls.Add(howlong_label);
            Controls.Add(mostlong_label);
            Controls.Add(button);
            Controls.Add(word2_textBox);
            Controls.Add(setword2_label);
            Controls.Add(word1_textBox);
            Controls.Add(setword1_label);
            Controls.Add(history_label);
            Name = "FormOf1";
            Text = "Определить, какое из двух слов длиннее и насколько";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label history_label;
        private Label setword1_label;
        private TextBox word1_textBox;
        private Label setword2_label;
        private TextBox word2_textBox;
        private Button button;
        private Label mostlong_label;
        private Label howlong_label;
        private Label setmostlong_label;
        private Label sethowlong_label;
    }
}