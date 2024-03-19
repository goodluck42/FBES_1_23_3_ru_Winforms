using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        MessageBox.Show(@"Form1 Loaded");

        resultTextBox.ReadOnly = true;
    }

    private void clickButton_Click(object sender, EventArgs e)
    {
        resultTextBox.Text = (int.Parse(myTextBox1.Text) + int.Parse(myTextBox2.Text)).ToString();
    }

    private void button_Click(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            switch (button.Text)
            {
                case "button1":
                {
                    MessageBox.Show(@"It's button1");
                    break;
                }
                case "button2":
                {
                    MessageBox.Show(@"It's button2");
                    break;
                }
            }
        }
    }
}