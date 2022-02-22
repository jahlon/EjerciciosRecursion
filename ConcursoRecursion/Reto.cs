using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoRecursion
{
    internal class Reto
    {
        public string Pregunta { get; }
        public int Tiempo { get; }

        public Reto(string pregunta, int tiempo)
        {
            Pregunta = pregunta;
            Tiempo = tiempo;
        }
    }
}
