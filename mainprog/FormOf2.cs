using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wonderful_string_tools;

namespace lab5;

public partial class FormOf2 : Form
{
    public FormOf2() 
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox.Text))
            get_label.Text = StringTools.ReverseWordsPrint(textBox.Text);
    }
}
