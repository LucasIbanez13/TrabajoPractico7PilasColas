
public class EjercicioTres
{
    public void Tres()
    {
        Console.Write("Ingresa una expresión infix: ");
        string infix = Console.ReadLine();

        string postfix = ConvertirAPostfix(infix);
        Console.WriteLine("Postfix: " + postfix);
    }

    private int Precedencia(char op)
    {
        if (op == '+' || op == '-') return 1;
        if (op == '*' || op == '/') return 2;
        return 0;
    }

    private string ConvertirAPostfix(string infix)
    {
        Stack<char> operadores = new Stack<char>();
        string postfix = "";

        foreach (char valorRemplazo in infix.Replace(" ", "")) //el Replace, lo que hace es eliminar los espacios en blanco por nada
        {
            if (char.IsLetterOrDigit(valorRemplazo)) //devuelve true si viene una letra o numero 
            {
                postfix += valorRemplazo;
            }
            else if (valorRemplazo == '(')
            {
                operadores.Push(valorRemplazo);
            }
            else if (valorRemplazo == ')')
            {
                while (operadores.Peek() != '(')// el peek devuelve el elemento de la cima de la pila sin eliminarlo 
                    postfix += operadores.Pop();
                operadores.Pop();
            }
            else
            {
                while (operadores.Count > 0 && Precedencia(valorRemplazo) <= Precedencia(operadores.Peek()))
                    postfix += operadores.Pop();
                operadores.Push(valorRemplazo);
            }
        }

        while (operadores.Count > 0)
            postfix += operadores.Pop();

        return postfix;
    }
}
