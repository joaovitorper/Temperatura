using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarClima_Click(object sender, EventArgs e)
        {
            double temperatura = double.Parse(txtTemperatura.Text);
          
           if (txtTemperatura.Text == "") {
                MessageBox.Show("Digite uma temperatura!", "Atenção",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             

            if (temperatura < 15)
            {
                pibClima.Image = Properties.Resources.Frio;
            }
            else if (temperatura <30)

            {
                pibClima.Image= Properties.Resources.Sol;

            }
            else if (temperatura > 30)
            {
                pibClima.Image = Properties.Resources.quente1;



            }
            
        }
    }
}
