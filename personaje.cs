namespace EspacioPersonaje
{
    public class Personaje
        {
            //DATOS
            public enum tipo{
                luchador= 0,
                ciudadano= 1,
                guardia=2,
            }

            public string nombre;
            public string apodo;
            public DateTime fechaNac;
            public int edad;

            //CARACTERISTICAS
            private int velocidad;
            private int destreza;
            private int fuerza;
            private int nivel;
            private int armadura;
            private int salud = 100;

            
        } 

}