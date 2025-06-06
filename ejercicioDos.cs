public class ejercicioDos
{
    public void Dos()
    {
        Stack<string> pilaBalanceada = new Stack<string>();
        int corteDos = 0;
        string valorPilaBalanceada;

        while (corteDos == 0)
        {
            Console.WriteLine("Ingrese una opcion");
            Console.WriteLine("1. Agregar expresion matematica");
            Console.WriteLine("2. Verificar parentesis balanceados");
            Console.WriteLine("3. Salir de ejercicio Dos");
            int opcEjemploDos = Convert.ToInt16(Console.ReadLine());

            if (opcEjemploDos == 1)
            {
                Console.WriteLine("Ingrese una expresion matematica");
                valorPilaBalanceada = Console.ReadLine();
                pilaBalanceada.Push(valorPilaBalanceada);
            }
            if (opcEjemploDos == 2)
            {
                foreach (string expresion in pilaBalanceada)
                {
                    Stack<char> pilaParentesis = new Stack<char>();
                    bool balanceado = true;
                    bool tieneParentesis = false;

                    foreach (char caracter in expresion)
                    {
                        if (caracter == '(')
                        {
                            pilaParentesis.Push(caracter);
                            tieneParentesis = true;
                        }
                        else if (caracter == ')')
                        {
                            tieneParentesis = true;
                            if (pilaParentesis.Count == 0)
                            {
                                balanceado = false;
                                break;
                            }
                            pilaParentesis.Pop();
                        }
                    }

                    if (pilaParentesis.Count > 0)
                    {
                        balanceado = false;
                    }

                    if (balanceado && tieneParentesis)
                    {
                        Console.WriteLine($"Balanceado: {expresion}");
                    }
                    else
                    {
                        Console.WriteLine($"No balanceado: {expresion}");
                    }
                }
            }
            if (opcEjemploDos == 3)
            {
                Console.WriteLine("Saliendo de ejercicio Dos...");
                corteDos = 1;
            }
        }
    }
}
