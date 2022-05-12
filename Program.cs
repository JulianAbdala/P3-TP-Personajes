namespace tp_Juego
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego");
            List<Personaje> listaPersonajes = new List<Personaje>();
            listaPersonajes.Add(new PersonajeDeFuerza("ARagorn", 25, 5, 10));
            listaPersonajes.Add(new PersonajeDeAgilidad("Legolas", 12, 60, 30)); //Legolas esta OP
            listaPersonajes.Add(new PersonajeDeMagia("Gandalf", 10, 15));

            List<Enemigo> listaEnemigos = new List<Enemigo>();
            listaEnemigos.Add(new Enemigo(250, 15));

            Turno.Atacarse(listaPersonajes);

            foreach (Imoverse personajeMov in listaPersonajes) //Trate de hacerlo como en clase pero creo que no lo hice andar
            {
                Turno.MoverFichas(personajeMov);
            }
         
            foreach (Imoverse enemigoMov in listaEnemigos)
            {
                Turno.MoverFichas(enemigoMov);
            }
        }
    }
}
