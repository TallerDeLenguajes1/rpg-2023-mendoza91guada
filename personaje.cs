namespace EspacioPersonaje
{
    public class Personaje
        {
            //DATOS
            enum tipo{
                luchador= 0,
                ciudadano= 1,
                guardia=2,
            }

            string nombre;
            string apodo;
            DateTime fechaNac;
            int edad;

            //CARACTERISTICAS
            int velocidad;
            int destreza;
            int fuerza;
            int nivel;
            int armadura;
            int salud = 100;

            
        } 

}