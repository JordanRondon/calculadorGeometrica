using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraGeometrica
{
    public class Triangulo
    {
        public float baseTriangulo { get; set; }
        public float alturaTriangulo { get; set; }

        public Triangulo(float baseTriangulo, float alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public float areaTriangulo()
        {
            return baseTriangulo * alturaTriangulo / 2;
        }

        public float perimetroTriangulo()
        {
            return baseTriangulo * 3;
        }
    }
}
