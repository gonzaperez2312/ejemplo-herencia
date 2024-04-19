namespace EjemploHerenciaService
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }

        //La clase hija puede elegir si sobreescribir o no este comportamiento
        public virtual string Mover() {
            return "El animal se está moviendo y es un ";
        }

        //Exige a las clases hijas, que implementen el método
        public abstract string Dormir();
    }
}