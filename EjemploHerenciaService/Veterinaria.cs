using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjemploHerenciaService
{
    public class Veterinaria
    {
        public List<Animal> Animales { get; set; }

        public List<Gato> Gatos { get; set; }

        public List<Perro> Perros { get; set; }

        public Veterinaria() {
            Animales = new List<Animal>();
            Gatos = new List<Gato>();
            Perros = new List<Perro>();

            //Polimorfismo
            //Gato gato1 = new Gato();
            //Animales.Add(gato1);
        }

        public bool AgregarAnimal(Animal animal) {
            Animales.Add(animal);

            return true;
        }

        public bool AgregarAnimal(Animal animal, string tipo)
        {
            Animales.Add(animal);

            return true;
        }

        public bool AgregarAnimal(Perro animal)
        {
            Animales.Add(animal);

            return true;
        }
    }
}
