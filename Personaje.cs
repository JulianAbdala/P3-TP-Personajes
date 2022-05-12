namespace tp_Juego
{
    public abstract class Personaje : Imoverse
    {
        //Parametros
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }

        public abstract int CalcularDanio();
        public virtual void Atacar()
        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de danio");
        }
        public int MoverseEjeX() //No se que valor ponerles, pense en hacerlo void pero no me dejaba
        {
            return 1;
        }
        public int MoverseEjeY()
        {
            return 1;
        }
    }
}