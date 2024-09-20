using System;
using System.Diagnostics;
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
            try
            {
                if ( txtbDisplay.Text == ""  )
                {
                    throw new ApplicationException("El campo display está vacío");

                }
                errorProvider1.Clear();

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
            catch (ApplicationException ex)
            {
                errorProvider1.SetError(txtbDisplay, ex.Message);
                
            }
           
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                if (m1 == null  || m2 == null )
                {
                    throw new ApplicationException("Ingresar un arreglo" +
                        " de 2 dimensiones en el display");
                }

                m3 = m1 + m2;
                lbResultado.Text = m3.ToString();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
         }
    }
}
