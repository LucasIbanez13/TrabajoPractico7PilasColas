//Creamos la clase Menu
public class Menu
{
    int opc;
    int corte = 0;

    public void Mostrar() //aqui creamos la funcion
    {
        while (corte == 0) // esto es un while con una bandera de corte
        {
            // esto es un menu mostramos la opciones
            Console.WriteLine("Opciones del menu: ");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");

            Console.WriteLine("Opcion: ");

            opc = Convert.ToInt16(Console.ReadLine());
// esto es una condicional, si opc es mayor a 1 "y" opc es menor a 10 te deja entrar
            if (opc < 1 || opc > 10) // Pero si opc es 11 o 12 se cumple la condicion y te muestra un mensaje
            {
                Console.WriteLine("Ingrese una opcion erronea ");
            }
            switch (opc) //estp es un menu, opc es el valor o numero q vamos a ingresar, por eso pusimos la condicional arriba de 1 a 10
            {
                case 1://en caso de ser 1 se muestra este bloque
                    {
                        //aqui llamamos el otro archivo q es ejercicio uno, la misma mentalidad del archivo Program
                        EjercicioUno ejercicioUno = new EjercicioUno();
                        ejercicioUno.Uno();
                    }
                    break;

                case 10:
                    {
                        Console.WriteLine("Nos vimos");
                        corte = 1; // esta es la variable de corte
                    }
                    break;
            }
        }

    }

}