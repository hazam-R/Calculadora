using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;

                a = Convert.ToInt32(textBoxVariableA.Text);
                b = int.Parse(txtBoxVariableB.Text);

                resultado = a + b;

                MessageBox.Show("El Resultado es: " + resultado.ToString(), "Sistema"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conversion de datos", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            textBoxVariableA.Text = "";
            txtBoxVariableB.Clear();
            textBoxVariableA.Focus();
        }
    }
}
