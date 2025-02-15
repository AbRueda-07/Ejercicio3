void saludar()
{
    Console.WriteLine("Qué hubo!!!");
}

void menu()
{

    Console.WriteLine("Elija una opcíon del menú");
    int opcion;
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("1. Suma");
 
            Console.WriteLine("Ingrese el primer número");
            Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número");
            Console.ReadLine();
            int suma(int n1, int n2)
            {
                int resultado = 0;
                resultado = n1 + n2;
                return resultado;

                Console.WriteLine($"la suma es: {resultado}");

            } break;

        case 2:
            Console.WriteLine("2. Resta");

            Console.WriteLine("Ingrese el primer número");
            Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número");
            Console.ReadLine();
            int resta(int n1, int n2)
            {
                int resultado = 0;
                resultado = n1 + n2;
                return resultado;

                Console.WriteLine($"la resta es: {resultado}");
            }break;

        case 3:
            Console.WriteLine("3. Multiplicación");

            Console.WriteLine("Ingrese el primer número");
            Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número");
            Console.ReadLine();
            int mult(int n1, int n2)
            {
                int resultado = 0;
                resultado = n1 + n2;
                return resultado;

                Console.WriteLine($"la multiplicación es: {resultado}");
            } break;
        case 4:
            Console.WriteLine("4. División");

            Console.WriteLine("Ingrese el primer número");
            Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número");
            Console.ReadLine();
            int div(int n1, int n2)
            {
                int resultado = 0;
                resultado = n1 + n2;
                return resultado;

                Console.WriteLine($"la división es: {resultado}");
            } break;

        case 5:
            Console.WriteLine("5. Salir");
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }


}


