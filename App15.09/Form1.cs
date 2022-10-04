using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App15._09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            listProdutos.Items.Clear();
            listQuantidade.Items.Clear();
            listPreco.Items.Clear();
            listTotal.Items.Clear();
        }

        private void buttonAddLista_Click(object sender, EventArgs e)
        {
            listProdutos.Items.Add(textboxProdutos.Text);
            listQuantidade.Items.Add(textboxQuatidade.Text);
            listPreco.Items.Add(textboxPreco.Text);
            listTotal.Items.Add(textboxTotal.Text);
            textboxProdutos.Clear();
            textboxQuatidade.Clear();
            textboxPreco.Clear();
            textboxTotal.Clear();
            textboxProdutos.Focus();
        }

        private void textboxProdutos_TextChanged(object sender, EventArgs e)
        {
            Double qta, pr, result;
            if (!textboxQuatidade.Text.Equals("") && !textboxPreco.Text.Equals(""))
            {
                qta = Convert.ToDouble(textboxQuatidade.Text);
                pr = Convert.ToDouble(textboxPreco.Text);
                result = qta * pr;
                textboxTotal.Text = result.ToString();
            }
        }

        private void textboxPreco_TextChanged(object sender, EventArgs e)
        {
            Double qta, pr, result;
            if (!textboxQuatidade.Text.Equals("") && !textboxPreco.Text.Equals(""))
            {
                qta = Convert.ToDouble(textboxQuatidade.Text);
                pr = Convert.ToDouble(textboxPreco.Text);
                result = qta * pr;
                textboxTotal.Text = result.ToString();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int index = listProdutos.SelectedIndex;
            listProdutos.Items.RemoveAt(index);
            listPreco.Items.RemoveAt(index);
            listQuantidade.Items.RemoveAt(index);
            listTotal.Items.RemoveAt(index);

        }

        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listProdutos.SelectedIndex;
            if (index != -1)
            {
                if (listQuantidade.GetSelected(index) == false)
                {
                    listQuantidade.SetSelected(index, true);
                    listPreco.SetSelected(index, true);
                    listTotal.SetSelected(index, true);
                }
            }

        }

        private void listQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listQuantidade.SelectedIndex;
            if (index != -1)
            {
                if (listPreco.GetSelected(index) == false)
                {
                    listPreco.SetSelected(index, true);
                    listProdutos.SetSelected(index, true);
                    listTotal.SetSelected(index, true);
                }
            }
        }
        private void ListPreco_SelectedIndexChanged(object sander, EventArgs e)
        {
            int index = listPreco.SelectedIndex;
            if (index != -1)
            {
                if (listTotal.GetSelected(index) == false)
                {
                    listQuantidade.SetSelected(index, true);
                    listProdutos.SetSelected(index, true);
                    listTotal.SetSelected(index, true);
                }
            }
        }

        private void listTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listTotal.SelectedIndex;
            if (index != -1)
            {
                if (listProdutos.GetSelected(index) == false)
                {
                    listQuantidade.SetSelected(index, true);
                    listPreco.SetSelected(index, true);
                    listTotal.SetSelected(index, true);
                }
            }
        }

        private void buttonFecharVenda_Click(object sender, EventArgs e)
        {
            double valorTotal = 0;

            foreach( var valor in listTotal.Items)
            {
                valorTotal += Convert.ToDouble(valor);
            }
            textBox5.Text = valorTotal.ToString("C");

        }
    }
}
