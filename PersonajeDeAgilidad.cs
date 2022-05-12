namespace tp_Juego
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nombre, int fuerza, int agilidad, int magia)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Agilidad = agilidad;
            this.Magia = magia;
        }

        public override int CalcularDanio()
        {
            return Fuerza / 2 * Agilidad * Magia / 2;

        }
    }
}
