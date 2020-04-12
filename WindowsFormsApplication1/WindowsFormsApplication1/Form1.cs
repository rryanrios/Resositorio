using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool validar = false;
        string operador;
        int a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtPainel.Text = txtPainel.Text + bt.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPainel.Text = "";
            lblRes.Text = "";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a += Convert.ToInt32(txtPainel.Text);
                lblRes.Text = Convert.ToString(a);
                txtPainel.Text = "";
                operador = "+";
            } else
            {
                lblRes.Text = txtPainel.Text + btnSoma.Text;
                a = Convert.ToInt32(txtPainel.Text);
                operador = "+";
                validar = true;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a += Convert.ToInt32(txtPainel.Text);
                lblRes.Text = Convert.ToString(a);
                txtPainel.Text = "";
                operador = "+";
            }
            else
            {
                lblRes.Text = txtPainel.Text + btnSoma.Text;
                a = Convert.ToInt32(txtPainel.Text);
                operador = "+";
                validar = true;
            }
        }
    }
}
