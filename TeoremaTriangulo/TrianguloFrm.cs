using System;
using System.Drawing;
using System.Windows.Forms;

namespace TeoremaTriangulo
{
    public partial class TrianguloFrm : Form
    {
        public TrianguloFrm()
        {
            InitializeComponent();
            MostrarControlesResultados(false);
            imgTry.SizeMode = PictureBoxSizeMode.Zoom; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {}
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);

                Triangulo t = new Triangulo(a, b, c);
                if (t.getExiste())
                {
                    txtExistencia.Text = "Sí existe";
                    CambiarVisibilidadResultados(true);

                    txtPerimetro.Text = t.getPerimetro().ToString("N2"); 
                    txtArea.Text = t.getArea().ToString("N2"); 
                    txtTipo.Text = t.getTipo(); 

                    if (t.getTipo() == "Equilátero") imgTry.Image = Properties.Resources.TriEquilatero;
                    else if (t.getTipo() == "Isósceles") imgTry.Image = Properties.Resources.TriIsoceles;
                    else imgTry.Image = Properties.Resources.TriEscaleno;
                }
                else
                {
                    txtExistencia.Text = "No existe";
                    CambiarVisibilidadResultados(false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los datos de entrada."); 
                CambiarVisibilidadResultados(false);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtA.Clear(); txtB.Clear(); txtC.Clear();
            txtExistencia.Clear(); txtPerimetro.Clear(); txtArea.Clear(); txtTipo.Clear();
            imgTry.Image = null;
        }

        private void CambiarVisibilidadResultados(bool estado)
        {
            lblParametro.Visible = estado;
            lblArea.Visible = estado;
            lblTipo.Visible = estado;
            lblVisualiza.Visible = estado;

            txtPerimetro.Visible = estado;
            txtArea.Visible = estado;
            txtTipo.Visible = estado;
            imgTry.Visible = estado;
        }

        private void MostrarControlesResultados(bool estado)
        {
            lblParametro.Visible = estado;
            lblArea.Visible = estado;
            lblTipo.Visible = estado;
            lblVisualiza.Visible = estado;

            txtPerimetro.Visible = estado;
            txtArea.Visible = estado;
            txtTipo.Visible = estado;
            imgTry.Visible = estado;
        }
    }
}