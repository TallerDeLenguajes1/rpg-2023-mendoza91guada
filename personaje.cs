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
            private double destreza {get => destreza; set => destreza = value;}
            private double fuerza {get => fuerza; set => fuerza = value;}
            private int nivel;
            private int armadura;
            private int salud = 100;

            
        } 

}