namespace tp_Juego
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nombre, int fuerza, int agilidad, int magia)
        {
            this.Nombre = nombre;
            this.Fuerza = 100;
            this.Agilidad = agilidad;
            this.Magia = magia;
        }


        public override int CalcularDanio()
        {
            return this.Fuerza + (this.Agilidad / 2) - this.Magia;

        }



    }
}
