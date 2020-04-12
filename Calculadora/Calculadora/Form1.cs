using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        string op;
        float a = 0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumerador(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtPainel.Text = txtPainel.Text + bt.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPainel.Text = "";
            lblRes.Text = "";
            a = 0;
            validar = false;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(txtPainel.Text);
                lblRes.Text = Convert.ToString(a) + "+";
                txtPainel.Text = "";
                op = "+";
            }
            else
            {
                lblRes.Text = txtPainel.Text + btnSoma.Text;
                a = Convert.ToInt32(txtPainel.Text);
                txtPainel.Text = "";
                op = "+";
                validar = true;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                lblRes.Text = lblRes.Text + txtPainel.Text + "=";
                txtPainel.Text = Convert.ToString(a + Convert.ToInt32(txtPainel.Text));
            }
            else if (op == "-")
            {
                lblRes.Text = lblRes.Text + txtPainel.Text + "=";
                txtPainel.Text = Convert.ToString(a - Convert.ToInt32(txtPainel.Text));
            }
            else if (op == "*")
            {
                lblRes.Text = lblRes.Text + txtPainel.Text + "=";
                txtPainel.Text = Convert.ToString(a * Convert.ToInt32(txtPainel.Text));
            }
            else if (op == "/")
            {
                lblRes.Text = lblRes.Text + txtPainel.Text + "=";
                txtPainel.Text = Convert.ToString(a / Convert.ToInt32(txtPainel.Text));
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txtPainel.Text);
                lblRes.Text = Convert.ToString(a) + "-";
                txtPainel.Text = "";
                op = "-";
            }
            else
            {
                lblRes.Text = txtPainel.Text + btnSub.Text;
                a = Convert.ToInt32(txtPainel.Text);
                txtPainel.Text = "";
                op = "-";
                validar = true;
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(txtPainel.Text);
                lblRes.Text = Convert.ToString(a) + "*";
                txtPainel.Text = "";
                op = "*";
            }
            else
            {
                lblRes.Text = txtPainel.Text + btnMult.Text;
                a = Convert.ToInt32(txtPainel.Text);
                txtPainel.Text = "";
                op = "*";
                validar = true;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(txtPainel.Text);
                lblRes.Text = Convert.ToString(a) + "/";
                txtPainel.Text = "";
            }
            else
            {
                lblRes.Text = txtPainel.Text + btnDiv.Text;
                a = Convert.ToInt32(txtPainel.Text);
                txtPainel.Text = "";
                op = "/";
                validar = true;
            }
        }

      
    }
}
