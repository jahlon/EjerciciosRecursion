using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcursoRecursion
{
    internal class ConcursoModel
    {
        public List<Reto> Retos { get; }
        private int _indiceRetos = 0;

        public ConcursoModel()
        {
            List<Reto> tempList = new List<Reto>
            {
                new Reto("Imprimir números naturales hasta un número dado", 300),
                new Reto("Imprimir los números naturales desde un número dado hasta 1", 300),
                new Reto("Sumar los primeros N números naturales", 300),
                new Reto("Imprimir los dígitos de un número dado sin convertir el número a string", 480),
                new Reto("Contar los dígitos en un número dado sin convertir el número a string", 480),
                new Reto("Imprimir los números pares en un rango dado", 480),
                new Reto("Indicar si una palabra dada es palíndromo", 600),
                new Reto("Calcular el factorial de un número dado", 300),
                new Reto("Elevar un número dado a una potencia dada", 480)
            };

            var random = new Random();
            Retos = tempList.OrderBy(item => random.Next()).ToList();

        }

        public Reto SiguienteReto()
        {
            Reto reto = null;
            if (_indiceRetos < Retos.Count)
            {
                reto = Retos[_indiceRetos];
                _indiceRetos++;
            }
            return reto;
        }


    }
}
