namespace tp_Juego
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia (string nombre, int fuerza, int magia, int agilidad)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Magia = magia; 
            this.Agilidad = agilidad; 
        }

        public PersonajeDeMagia(string nombre2, int fuerza2, int agilidad2)
        {
            this.Nombre = nombre2;
            this.Fuerza= fuerza2;
            this.Magia = 60;        
            this.Agilidad= agilidad2;
        }
        public override int CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4;

        }
        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de danio gracias a su magia!");
        }
    }
}
