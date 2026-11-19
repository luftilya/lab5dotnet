using Lab5.SubForms.SubFormsOf1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using WonderfulStringsToolsLib;

namespace Lab5;

public partial class FormOf2 : Form
{
    public FormOf2() 
        => InitializeComponent();

    private void button_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
            new NullOrWhiteSpaceErrorWarningFormOf1().ShowDialog();

        var bannedSignes = " .;/|\\`~@#№$%^:&?*()+=<>";

        foreach(char sign in textBox.Text)
        {
            if (bannedSignes.Contains(sign))
            {
                new SpliterErrorWarningFormOf1().ShowDialog();
                return;
            }
        }

        get_label.Text = StringTools.ReverseWordsPrint(textBox.Text);
    }
}
