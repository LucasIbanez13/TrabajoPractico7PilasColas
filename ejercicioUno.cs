public class EjercicioUno
{
    public void Uno()
    {
        Stack<string> cadena = new Stack<string>();

        int corteUno = 0;
        string valorCadena;


        while (corteUno == 0)
        {
            Console.WriteLine("Ingrese una opcion: ");
            Console.WriteLine("1. Agregar textos a la Lista");
            Console.WriteLine("2. Mostrar la Lista invertida");
            Console.WriteLine("3. Salir de ejercicio Uno");
            int opcEjemploUno = Convert.ToInt16(Console.ReadLine());
            if (opcEjemploUno == 1)
            {
                Console.WriteLine("Agregue una palabra al texto");
                valorCadena = Console.ReadLine();
                cadena.Push(valorCadena);
            }
            if (opcEjemploUno == 2)
            {
                string [] cadenaInvertida = cadena.ToArray();
                

                foreach (string cadenaIn in cadenaInvertida)
                {
                    Console.WriteLine(cadenaIn);
                }
            }
            if (opcEjemploUno == 3)
            {
                Console.WriteLine("Saliendo de  ejercicio uno...");
                corteUno = 1;
            }
        }
        
    }
}