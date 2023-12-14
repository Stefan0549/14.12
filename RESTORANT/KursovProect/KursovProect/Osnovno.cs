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
    public partial class Osnovno : Form
    {
        public Osnovno()
        {
            InitializeComponent();
        }

        private void Osnovno_Load(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox7.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox8.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox9.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox10.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox11.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (textBox12.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете бтойка!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (int.Parse(textBox1.Text) != 0)
            {
                listBox1.Items.Add($"{label1.Text} - {textBox1.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox2.Text) != 0)
            {
                listBox1.Items.Add($"{label6.Text} - {textBox2.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox3.Text) != 0)
            {
                listBox1.Items.Add($"{label9.Text} - {textBox3.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox9.Text) != 0)
            {
                listBox1.Items.Add($"{label27.Text} - {textBox9.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox8.Text) != 0)
            {
                listBox1.Items.Add($"{label24.Text} - {textBox8.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox7.Text) != 0)
            {
                listBox1.Items.Add($"{label22.Text} - {textBox7.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox6.Text) != 0)
            {
                listBox1.Items.Add($"{label18.Text} - {textBox6.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox5.Text) != 0)
            {
                listBox1.Items.Add($"{label15.Text} - {textBox5.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox4.Text) != 0)
            {
                listBox1.Items.Add($"{label13.Text} - {textBox4.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox12.Text) != 0)
            {
                listBox1.Items.Add($"{label36.Text} - {textBox12.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox11.Text) != 0)
            {
                listBox1.Items.Add($"{label33.Text} - {textBox11.Text}бр. {Environment.NewLine}");
            }
            if (int.Parse(textBox10.Text) != 0)
            {
                listBox1.Items.Add($"{label31.Text} - {textBox10.Text}бр. {Environment.NewLine}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double everything = (double.Parse(textBox1.Text) * 12) + (double.Parse(textBox2.Text) * 5) + (double.Parse(textBox3.Text) * 4) + (double.Parse(textBox9.Text) * 4) + (double.Parse(textBox8.Text) * 3) + (double.Parse(textBox7.Text) * 5) + (double.Parse(textBox6.Text) * 3) + (double.Parse(textBox5.Text) * 3) + (double.Parse(textBox4.Text) * 3) + (double.Parse(textBox12.Text) * 4) + (double.Parse(textBox11.Text) * 2) + (double.Parse(textBox10.Text) * 4);

            double finalprice = everything;

            string listBoxItems = string.Empty;

            //Сортиране по азбучен ред
            listBox1.Sorted = true;
            foreach (var item in listBox1.Items)
            {
                listBoxItems += item.ToString() + Environment.NewLine;
            }
            MessageBox.Show(listBoxItems + $"{Environment.NewLine}" + $"Дължима сума: {finalprice:f2}лв", "Сметка");
        }
    }
}

