using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaService
{
    public class Perro : Animal
    {
        public string Raza { get; set; }

        public override string Mover()
        {
            return base.Mover() + $"Perro de raza {Raza}";
        }

        public override string Dormir()
        {
            return "Esto es un perro y duerme 16 hs por día.";
        }
    }
}
