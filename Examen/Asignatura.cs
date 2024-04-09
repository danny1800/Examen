using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Asignatura
    {
        //atributos
        public int codigo {  get; set; }
        public string nombre { get; set; }
        public double practicas { get; set;}

        //constructor
        public Asignatura (int codigo, string nom, double pract) 
        {
            this.codigo = codigo;
            this.nombre = nom;
            this.practicas = pract;
        }
    }
}
