using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovProect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form1 firstform = new Form1();
            Osnovno osnovno1 = new Osnovno();
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Въведи колко човека искате на една маса", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Smoke_rb.Checked == false && NoSmoke_rb.Checked == false)
            {
                MessageBox.Show("Трябва да селектираш едната от двете опции - пушачи или не пушачи!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(textBox1.Text) < 2 || int.Parse(textBox1.Text) >= 10)
            {
                MessageBox.Show("Бройката на хората на една маса, трябва да е в диапазона от 2 - 10", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (card_rb.Checked == false && cesh_rb.Checked == false)
            {
                MessageBox.Show("Трябва да селектираш едната от двете опции - в брой или с карта!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                osnovno1.Show();
                firstform.Hide();
            }
        }
    }
}
