using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeAppsTDS06
{
    public partial class FmrIMC : Form
    {
        public FmrIMC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FmrIMC_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtAltura;
            txtAltura.Focus();
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double peso, altura, resultado;
            if (txtAltura.Text == "" || txtPeso.Text == "")
            {
                MessageBox.Show("Não há calculos sem valores! Por favor digite os campos: altura e peso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                altura = Convert.ToDouble(txtAltura.Text);
                peso = Convert.ToDouble(txtPeso.Text);
                resultado = peso / (altura * altura);
                lblIMCResult.Text = resultado.ToString("F");
                txtAltura.Text = "";
                txtPeso.Text = "";

                if (resultado < 18.9)
                {
                    lblIMCResultado.Text = "MAGREZA";
                }
                else if (resultado >= 18.9 && resultado <= 24.9)
                {
                    lblIMCResultado.Text = "NORMAL";
                }
                else if (resultado >= 25.9 && resultado <= 29.9)
                {
                    lblIMCResultado.Text = "SOBREPESO";
                }
                else if (resultado >= 30.9 && resultado <= 39.9)
                {
                    lblIMCResultado.Text = "OBESIDADE";
                }
                else
                {
                    lblIMCResultado.Text = "OBESIDADE GRAVE";
                }
            }
        }
        private void lblIMCResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
