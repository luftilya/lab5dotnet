using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_string_tools;

namespace lab5;

public partial class FormOf1 : Form
{
    public FormOf1() 
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(word1_textBox.Text)
            && !string.IsNullOrWhiteSpace(word2_textBox.Text))
        {
            if (word1_textBox.Text.Length == word2_textBox.Text.Length)
                setmostlong_label.Text = "СТРОКИ РАВНЫ";
            else if (StringTools.IsFirstWordLonger(word1_textBox.Text, word2_textBox.Text))
            {
                setmostlong_label.Text = word1_textBox.Text;
                sethowlong_label.Text = StringTools.HowWordLonger(word1_textBox.Text, word2_textBox.Text).ToString();
            }
            else
            {
                setmostlong_label.Text = word2_textBox.Text;
                sethowlong_label.Text = StringTools.HowWordLonger(word1_textBox.Text, word2_textBox.Text).ToString();
            }
        }
    }
}
