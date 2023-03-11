namespace L5_KC_1120623
{
    internal class Program
    {
        static void Main(string[] args)
        { //EJERCICIO 1 DETERMINAR EL NÚMERO ENTERO
            Console.WriteLine("Ejercicio 1");
            Console.Write("Número ENTERO: ");

            int numero;
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error: No ha ingresado un número entero válido.");
                return;
            }

            string resultado;
            if (numero > 0)
            {
                resultado = "positivo";
            }
            else if (numero < 0)
            {
                resultado = "negativo";
            }
            else
            {
                resultado = "cero";
            }

            Console.WriteLine($"RESULTADO: El número es {resultado}.");

            // EJERCICIO 2 INGRESAR NÚMERO DEL 1-7 PARA QUE NOS DE UN DÍA DE LA SEMANA 
            Console.WriteLine("Ejercicio 2");
            Console.Write("Ingrese el número de día: ");

            int dia;
            if (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 7)
            {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7.");
                return;
            }

            string nombreDia;
            if (dia == 1)
            {
                nombreDia = "lunes";
            }
            else if (dia == 2)
            {
                nombreDia = "martes";
            }
            else if (dia == 3)
            {
                nombreDia = "miércoles";
            }
            else if (dia == 4)
            {
                nombreDia = "jueves";
            }
            else if (dia == 5)
            {
                nombreDia = "viernes";
            }
            else if (dia == 6)
            {
                nombreDia = "sábado";
            }
            else
            {
                nombreDia = "domingo";
            }

            Console.WriteLine($"DÍA: {nombreDia}");

            Console.WriteLine("Estudiante: [Kenneth Castillo]");
            Console.WriteLine("Carnet: [1120623]\n");

            //TAREA
            Console.Write("Ingrese la cantidad en quetzales (entre 0 y 999.99): ");
            decimal cantidad = Convert.ToDecimal(Console.ReadLine());

            
            int billete100 = 0, billete50 = 0, billete20 = 0, billete10 = 0, billete5 = 0, moneda1 = 0, moneda25 = 0, moneda1c = 0;

           
            billete100 = (int)cantidad / 100;
            cantidad = cantidad % 100;
            billete50 = (int)cantidad / 50;
            cantidad = cantidad % 50;
            billete20 = (int)cantidad / 20;
            cantidad = cantidad % 20;
            billete10 = (int)cantidad / 10;
            cantidad = cantidad % 10;
            billete5 = (int)cantidad / 5;
            cantidad = cantidad % 5;
            moneda1 = (int)cantidad / 1;
            cantidad = cantidad % 1;
            moneda25 = (int)(cantidad / 0.25m);
            cantidad = cantidad % 0.25m;
            moneda1c = (int)(cantidad / 0.01m);

            
            Console.WriteLine("\nDenominaciones:");
            Console.WriteLine("Billetes de 100 quetzales: {0}", billete100);
            Console.WriteLine("Billetes de 50 quetzales: {0}", billete50);
            Console.WriteLine("Billetes de 20 quetzales: {0}", billete20);
            Console.WriteLine("Billetes de 10 quetzales: {0}", billete10);
            Console.WriteLine("Billetes de 5 quetzales: {0}", billete5);
            Console.WriteLine("Monedas de 1 quetzal: {0}", moneda1);
            Console.WriteLine("Monedas de 25 centavos: {0}", moneda25);
            Console.WriteLine("Monedas de 1 centavo: {0}", moneda1c);
        }

    }
}
    
