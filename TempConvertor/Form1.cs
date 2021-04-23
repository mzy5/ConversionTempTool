using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCtoF_Click(object sender, EventArgs e)
        {
            Double valFromCelsius;
            bool conversionIsSuccessful;
            conversionIsSuccessful = Double.TryParse(txtFromC.Text, out valFromCelsius);
            if (conversionIsSuccessful == true)
            {
                var valToFahrenheit = (valFromCelsius * 9 / 5) + 32;
                txtToF.Text = Convert.ToString(valToFahrenheit);
            }
        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            Double valFromFahrenheit;
            bool conversionIsSuccessful;
            conversionIsSuccessful = Double.TryParse(txtFromF.Text, out valFromFahrenheit);
            if (conversionIsSuccessful == true)
            {
                var valToCelsius = (valFromFahrenheit * 32 - 32) * 5/9;
                txtToC.Text = Convert.ToString(valToCelsius);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.Show();
        }
    }
}
