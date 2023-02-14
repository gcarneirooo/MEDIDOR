using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    public partial class MEDIDAS : Form
    {
        public MEDIDAS()
        {
            InitializeComponent();
        }

        private void buttonconvert_Click(object sender, EventArgs e)
        {
            if (this.OPTION.SelectedIndex == 0)
            {
                float celsius = 0;
                if
                    (float.TryParse(TxtConverter.Text, out celsius))
                {
                    float fahren = (float)(celsius * 9 / 5 + 32);
                    TxtConvertido.Text = $"{fahren:N2}";
                }
                else
                {
                    MessageBox.Show("Valor Inválido");
                    TxtConvertido.Text = "";
                }
            }
            else if (this.OPTION.SelectedIndex == 1)
            {
                float fahren = 0;
                if
                    (float.TryParse(TxtConverter.Text, out fahren))
                {
                    float celsius = (float)(fahren - 32 * 5/ 9);
                    TxtConvertido.Text = $"{celsius:N2}";
                }
                else
                {
                    MessageBox.Show("Valor Inválido");
                    TxtConvertido.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Selecione o tipo de conversão!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OPTION_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
