using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using WonderfulStringsToolsLib;

namespace Lab5;

public partial class FormOf3 : Form
{
    public FormOf3() 
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBox.Text))
            get_label.Text = StringTools.ToDoubleConsonants(textBox.Text);
        else
            get_label.Text = "ПРЕДЛОЖЕНИЕ С УДВОЕННЫМИ СОГЛАСНЫМИ ПОЯВИТСЯ ЗДЕСЬ";
    }
}
