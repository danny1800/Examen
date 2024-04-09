using System;
using System.Collections.Generic;:
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Anual:Asignatura
    {
        //atributos
        public double Nt1cuatri {  get; set; }
        public double Nt2cuatri { get; set; }

        //constructor
        public Anual (int codigo, string nom, double pract, double ntc1, double ntc2):base (codigo, nom, pract)
        {
           this.Nt1cuatri = ntc1;
           this.Nt2cuatri = ntc2;
        }

        //metodo
        public double NotaFinal () 
        {
            double Nt;
            Nt = (Nt1cuatri + Nt2cuatri)/2;
            return Nt;
        }

        public string MostrarNotafinal () 
        {
            string datos;
            datos = "nombre de la asignatura: " + nombre + Environment.NewLine;
            datos += "codigo de la asignatura: " + codigo + Environment.NewLine;
            datos += "la nota final de esta asignatura es de: " + NotaFinal() + Environment.NewLine;
            return datos;
        }

    }
}
