namespace tp_Juego
{
    public class Enemigo : Imoverse
    {
        public int Vida { get; set; }
        public int Level { get; set; }

        public  Enemigo (int vida, int level)
        {
            Vida = vida;
            Level = level;
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


