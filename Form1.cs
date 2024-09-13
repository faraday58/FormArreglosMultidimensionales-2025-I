using System;

using System.Windows.Forms;

namespace FormArreglosMultidimensionales_2025_I
{
    public partial class Form1 : Form
    {
        bool changeOperando= false;
        
        Multidimensional m1;
        Multidimensional m2;
        Multidimensional m3;



        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarOperando_Click(object sender, EventArgs e)
        {
            if (!changeOperando)
            {
                m1 = Multidimensional.Read(txtbDisplay.Text);

                lbOperando1.Text = m1.ToString();
                changeOperando = true;
            }
            else
            {
                m2 = Multidimensional.Read(txtbDisplay.Text);
                lbOperando2.Text = m2.ToString();
                changeOperando = false;
            }
           
        }
    }
}
