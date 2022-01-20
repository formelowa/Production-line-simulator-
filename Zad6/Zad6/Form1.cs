using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad6
{
    public partial class Form1 : Form
    {
        private string login = "osk";
        private string haslo = "osk";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Equals(textBox1.Text) && haslo.Equals(textBox2.Text))
            {
                textBox1.Text = "";
                textBox2.Text = "";
                this.Hide();
                Form formEngine = new Form2(this);
                formEngine.ShowDialog();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Błędne hasło lub login.","Error",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
    }

