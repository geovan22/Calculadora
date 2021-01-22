using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caluladora5toDiver
{
    public partial class Form1 : Form
    {
        static Operaciones op = new Operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdResultado_Click(object sender, EventArgs e)
        {
            if (cbxOperacion.Text == "Suma")
            {
                lblres.Text = (op.Suma(double.Parse(txtv1.Text),double.Parse(txtv2.Text))).ToString(); 
            }
            else if(cbxOperacion.Text == "Resta")
            {
                lblres.Text = (op.Resta(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
        }
    }
}
