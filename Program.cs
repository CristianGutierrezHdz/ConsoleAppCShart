
/* 
    ESTE PROGRAMA TRATA DE RECOPILAR MULTIPLES PROGRAMAS Y ALGORITMOS BASICOS
    RELEVANTES PARA LA RESULUCIONES DE DIFERENTES PROBLEMATICAS

    AUTHOR: Cristian G.
    VERSION: 03 / Enero / 2023
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program // clase
    {
        static void Main(string[] args) // metodo principal
        {
            int respuesta = 1;
            do
            {
                switch (Menu("TIPOS DE DATOS", "OPERADORES", "SENTENCIAS", "CICLOS", "OTROS", "SALIR"))
                {
                    case 1: // ********************* -- TIPOS DE DATOS -- ********************************

                        byte variable = 230;            // rango 0 - 255                   
                        int variable2 = 2147483647;     // rango -2147483648  -  2147483647                 
                        double variable3 = 56.78;
                        bool variable4 = true;          // true - false                   
                        char variable5 = 'm';           // un caracter                  
                        string variable6 = "This is a Chain"; // cadenas de caracteres                    
                        dynamic variable7 = 23;         // la variable de tipo dynamic se adapta a lo que se le asigne ala variable

                        Console.Write("\nTipo de dato: byte, valor: " + variable + "\n");     // byte variable = 230;
                        Console.Write("Tipo de dato: int, valor: " + variable2 + "\n");     // int variable2 = 2147483647;
                        Console.Write("Tipo de dato: double, valor: " + variable3 + "\n");  // double variable3 = 56.78;
                        Console.Write("Tipo de dato: bool, valor: " + variable4 + "\n");    // bool variable4 = true;
                        Console.Write("Tipo de dato: char, valor: " + variable5 + "\n");    // char variable5 = 'm'; 
                        Console.Write("Tipo de dato: string, valor: " + variable6 + "\n");  // string variable6 = "This is a Chain";
                        Console.Write("Tipo de dato: dynamic, valor: " + variable7 + "\n"); // dynamic variable7 = 23;

                        Console.ReadKey(); break;

                    case 2:// ********************* -- OPERADORES -- *********************************
                           // Operadores Relacionales, Hacen relaciones o comparaciones entre un valor y otro <, >, <=, >=, ==, !=                   

                        bool result;
                        int x = 5, y = 10; Console.WriteLine("\nOPERADORES RELACIONALES\nINT X = 5, Y = 10\n");

                        result = (x == y); // Equal to Operator
                        Console.WriteLine("Equal to Operator (x == y): " + result);

                        result = (x > y); // Greater than Operator
                        Console.WriteLine("Greater than Operator (x > y): " + result);

                        result = (x < y); // Less than Operator
                        Console.WriteLine("Less than Operator (x < y): " + result);

                        result = (x >= y); // Greater than Equal to Operator
                        Console.WriteLine("Greater than or Equal to (x >= y): " + result);

                        result = (x <= y); // Less than Equal to Operator
                        Console.WriteLine("Lesser than or Equal to (x <= y): " + result);

                        result = (x != y); // Not Equal To Operator
                        Console.WriteLine("Not Equal to Operator (x != y): " + result);
                        Console.ReadKey(); Console.Clear();

                        Console.WriteLine("\nOPERADORES LOGICOS\nBOOL A = TRUE, B = FALSE\n"); // Operadores logicos &&,||, !                   

                        bool a = true, b = false, result2;
                        Console.WriteLine("bool a = true, b= false");

                        result2 = a && b;  // AND operator
                        Console.WriteLine("AND Operator (a && b): " + result2);

                        result2 = a || b; // OR operator
                        Console.WriteLine("OR Operator (a || b): " + result2);

                        result2 = !a; // NOT operator
                        Console.WriteLine("NOT Operator (!a): " + result2);

                        Console.ReadKey(); Console.Clear(); break;

                    case 3: // ********************* -- SENTENCIAS -- *********************************
                            // If / Switch = estructuras de control

                        byte valor;
                        Console.WriteLine("ingrese un caso: ");
                        valor = Convert.ToByte(Console.ReadLine());

                        switch (valor) // variable a evualar
                        {
                            case 1:
                                Console.WriteLine("Este es el caso x");
                                break;
                            case 2:
                                Console.WriteLine("Este es el caso z");
                                break;
                            case 3:
                                Console.WriteLine("Este es el case 3");
                                break;
                            default: // si los casos anteriores no se dan
                                Console.WriteLine("Entro al case default");
                                break;
                        }

                        String letra;
                        Console.WriteLine("Ingresa una letra: ");
                        letra = Console.ReadLine();

                        switch (letra)
                        {
                            case "x":
                                Console.WriteLine("esto es el caso x");
                                break;
                            default:
                                Console.WriteLine("Esto es el case por default");
                                break;
                        }


                        break;
                    case 4: // ********************* -- CILOS -- *********************************
                            // Ciclos, Bloques de codigos que se ejecutan un determinado numero de veces
                            // WHILE / MIENTRAS

                        byte contador = 1;
                        byte numero;

                        Console.WriteLine("Numero de veces para repetir");
                        numero = Convert.ToByte(Console.ReadLine());

                        while (contador <= numero)
                        {
                            Console.WriteLine("Esta es la vuelta numero " + contador + " dentro del ciclo");
                            contador++;
                        }

                        Console.WriteLine("\nSigiente ciclo...");
                        Console.ReadKey();
                        // DO-WHILE / HACER - MIENTRAS


                        byte num = 15;

                        do
                        {
                            Console.WriteLine("Hola mundo, numero " + num);
                            num--;
                        } while (num >= 10);

                        Console.WriteLine("\nSigiente");
                        Console.ReadKey(); //_______________________________________________________________

                        for (int num1 = 0; num1 < 10; num1++)
                        {
                            Console.WriteLine("Hola mundo con FOR");
                        }

                        string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

                        Console.WriteLine("IMPRIMIENDO LOS VALORES DE UN ARREGLO CON FOREACH");
                        foreach (string dia in diasSemana) // imprime los valores del arreglo de cadenas de caracteres diasSemana
                        {
                            Console.Write(dia + ", ");
                        }

                        Console.WriteLine(); // imprime línea en blanco

                        List<int> listaPrimos = new List<int>();

                        listaPrimos.Add(2);
                        listaPrimos.Add(3);
                        listaPrimos.Add(5);
                        listaPrimos.Add(7);
                        listaPrimos.Add(11);

                        // impresión del contenido de la lista de enteros de 32 bits
                        foreach (int primo in listaPrimos)
                        {
                            Console.WriteLine(primo);
                        }

                        Console.WriteLine(); // imprime línea en blanco


                        break;
                    case 5: // ********************* -- OTROS -- *********************************

                        break;
                    default:
                        string siono = "NO";
                        Console.Write("Desea Salir? (SI / NO): ");
                        siono = Console.ReadLine();
                       
                        if (siono == "SI") respuesta = 10;
                        if (siono == "NO") respuesta = 1;                                                                
                        break;
                }
            } while (respuesta != 10);
                                        
        }

        static byte Menu(string op1, string op2, string op3, string op4, string op5, string op6)
        {
            byte num;
            bool ciclo = true;           
            do
            {
                Console.Clear();
                if (op1 != null) Console.WriteLine("1. " + op1);
                if (op2 != null) Console.WriteLine("2. " + op2);
                if (op3 != null) Console.WriteLine("3. " + op3);
                if (op4 != null) Console.WriteLine("4. " + op4);
                if (op5 != null) Console.WriteLine("5. " + op5);
                if (op6 != null) Console.WriteLine("6. " + op6);

                if (ciclo == false) Console.Write("INGRESE UNA OPCION CORRECTA: ");
                if (ciclo == true) Console.Write("SELECCIONAR LA OPCION: ");
                ciclo = false;
                num = Convert.ToByte(Console.ReadLine());
                
                if (num > 0 && num < 7) ciclo = true;               
            } while (ciclo == false);
            return num;
        }
    }
}