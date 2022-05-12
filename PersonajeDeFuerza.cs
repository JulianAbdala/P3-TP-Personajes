namespace tp_Juego
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nombre, int fuerza, int agilidad, int magia)
        {
            Nombre = nombre;
            Fuerza = 100;
            Agilidad = agilidad;
            Magia = magia;
        }


        public override int CalcularDanio()
        {
            return Fuerza + (Agilidad / 2) - Magia;

        }



    }
}
