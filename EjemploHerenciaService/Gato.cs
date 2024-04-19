using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaService
{
    public class Gato : Animal
    {
        public override string Dormir()
        {
            return "El animal que es un gato está durmiendo.";
        }
    }
}
