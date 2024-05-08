using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240805
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblApresentacao_Click(object sender, EventArgs e)
        {

        }

        private void bttConcatenar_Click(object sender, EventArgs e)
        {
            if(txbNome.Text == "" || txbSobrenome.Text == "")
            {
                MessageBox.Show("Campo(s) vazio(s).", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string nome_completo;
                nome_completo = txbNome.Text + " " + txbSobrenome.Text;

                txbApresentacao.Text = nome_completo;

                cbxNomesAdicionados.Items.Add(nome_completo);
                txbNome.Clear();
                txbSobrenome.Clear();
            }

        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            /*txbNome.Text = null;
            txbSobrenome.Text = null;
            txbApresentacao.Text = null;*/

            txbNome.Clear();
            txbSobrenome.Clear();
            txbApresentacao.Clear();

        }

        private void cbxNomesAdicionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mostrar;
            mostrar = cbxNomesAdicionados.SelectedItem.ToString();

            lblSelecionado.Text = mostrar;
        }

    }
}
