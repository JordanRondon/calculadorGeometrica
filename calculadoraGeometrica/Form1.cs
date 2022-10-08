using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraGeometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float baseTrian = float.Parse(txtBaseTriangulo.Text);
            float alturaTrian = float.Parse(txtAlturaTriangulo.Text);
            Triangulo t = new Triangulo(baseTrian, alturaTrian);

            txtAreaTriangulo.Text = Convert.ToString(t.areaTriangulo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float baseTrian = float.Parse(txtBaseTriangulo.Text);
            float alturaTrian = float.Parse(txtAlturaTriangulo.Text);
            Triangulo t = new Triangulo(baseTrian, alturaTrian);

            txtPerimetroTriangulo.Text = Convert.ToString(t.perimetroTriangulo());
        }

        private void btnAreaCuadrilatero_Click(object sender, EventArgs e)
        {
            float baseC= float.Parse(txtBaseCuadrilatero.Text);
            float alturaC = float.Parse(txtAlturaCuadrilatero.Text);
            Cuadrilatero c = new Cuadrilatero(baseC, alturaC);

            txtAreaCuadrilatero.Text = Convert.ToString(c.area());
        }

        private void btnPerimetroCuadrilatero_Click(object sender, EventArgs e)
        {
            float baseC = float.Parse(txtBaseCuadrilatero.Text);
            float alturaC = float.Parse(txtAlturaCuadrilatero.Text);
            Cuadrilatero c = new Cuadrilatero(baseC, alturaC);

            txtPerimetroCuadrilatero.Text = Convert.ToString(c.perimetro());
        }
    }
}
