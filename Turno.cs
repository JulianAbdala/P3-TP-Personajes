namespace tp_Juego
{
    static class Turno
    {
        public static void Atacarse(IList<Personaje> ListaPersonajes)
        {
            foreach (Personaje ClasePersonaje in ListaPersonajes)
            {
                ClasePersonaje.Atacar();
            }
        }

        public static void MoverFichas(Imoverse Ficha)
        {
            Ficha.MoverseEjeX();
            Ficha.MoverseEjeY();
        }
    }
}
