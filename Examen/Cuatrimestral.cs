using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Cuatrimestral: Asignatura
    {
        //atributos
        public int cuatrimestre { get; set; }
        public double notateorica { get; set; }

        //constructor
        public Cuatrimestral(int codigo, string nom, double pract, int cuatri, double Nt):base (codigo,nom,pract)
        {
            this.cuatrimestre = cuatri;
            this.notateorica = Nt;
        }

        //metodo
        public double NotaFinal()
        {
            double Nota;
            Nota = practicas + notateorica;
            return Nota;
        }

        public string MostrarNotaFinal () 
        {
            string Mostrar;
            Mostrar = "nombre de la asignatura: " + nombre + Environment.NewLine;
            Mostrar += "codigo de la asignatura: " + codigo + Environment.NewLine;
            Mostrar += "cuatrimestre a cursar: " + cuatrimestre + Environment.NewLine;
            Mostrar += "la nota final de la asignatura en este cuatrimestre es de: " + NotaFinal() + Environment.NewLine;
            return Mostrar;
        }
    }
}
