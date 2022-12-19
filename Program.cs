

//  .NET - C# - Ejercicios - Clases 1 y 2
//  Built - In Value Types.Estructuras Condicionales y Repetitivas.

/* 
    *************************************************************************
    1.Dado un valor, devolver un mensaje que diga “El valor es mayor que 100” 
    sólo cuando se cumpla dicha condición.
    *************************************************************************
*/
Console.WriteLine("EJERCICIO 1");
// valor por default
int num = 200;

if (num > 100)
{
    Console.WriteLine("El valor es mayor que 100");
};
Console.WriteLine(" ************************************************************************* ");

/* 
    *************************************************************************
    2.Pedir un número entero por teclado y calcular si es par o impar.
    *************************************************************************
*/
Console.WriteLine("EJERCICIO 2");
// si se ingresa por teclado
Console.WriteLine("Ingresar un número: ");
//int num2 = Int32.Parse(Console.ReadLine());
//int sobrante = num2 % 2;
long num2 = Convert.ToInt64(Console.ReadLine());
long sobrante = num2 % 2;
if (sobrante == 0)
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}
Console.WriteLine("*************************************************************************  ");

/* 
    *************************************************************************
    3.Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble
    de un impar. Por ejemplo, 14 cumple con esta condición.
    *************************************************************************
*/
Console.WriteLine("EJERCICIO 3");
// si se ingresa por teclado
Console.WriteLine("Ingresar un número: ");
int num3 = Int32.Parse(Console.ReadLine());
int resto = num3 / 2;
int sobrante2 = resto % 2;
if (sobrante2 == 0)
{
    Console.WriteLine("No cumple con las condiciones");
}
else
{
    Console.WriteLine(num3 + " es el doble de " + resto + " este es impar");
}

Console.WriteLine("*************************************************************************  ");

/* 
    *************************************************************************
    4.Dada un número del 1 al 10, devolver su “versión” en números romanos.
    *************************************************************************
*/
Console.WriteLine("EJERCICIO 4");
// si se ingresa por teclado
Console.WriteLine("Ingresar un número: ");
int numero = Int32.Parse(Console.ReadLine());
switch (numero)
{
    case 1:
        Console.WriteLine(numero + " = en romano I");
        break;
    case 2:
        Console.WriteLine(numero + " = en romano II");
        break;
    case 3:
        Console.WriteLine(numero + " = en romano III");
        break;
    case 4:
        Console.WriteLine(numero + " = en romano IV");
        break;
    case 5:
        Console.WriteLine(numero + " = en romano V");
        break;
    case 6:
        Console.WriteLine(numero + " = en romano VI");
        break;
    case 7:
        Console.WriteLine(numero + " = en romano VII");
        break;
    case 8:
        Console.WriteLine(numero + " = en romano VIII");
        break;
    case 9:
        Console.WriteLine(numero + " = en romano IX");
        break;
    case 10:
        Console.WriteLine(numero + " = en romano X");
        break;
}
Console.WriteLine("*************************************************************************  ");

/* 
    *************************************************************************
    5.Leer el nombre y las edades de dos personas y devolver el nombre del
    menor. En caso de que tengan la misma edad también debe indicarse.
    Devolver también la diferencia de edad en caso de corresponder.
    *************************************************************************
*/
Console.WriteLine("EJERCICIO 5");
// si se ingresa por teclado
Console.WriteLine("Ingresar Nombre de la Persona 1: ");
string nombrePersona1 = Console.ReadLine();
Console.WriteLine("Ingresar Edad de la Persona 1: ");
int edadPersona1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Ingresar Nombre de la Persona 2: ");
string nombrePersona2 = Console.ReadLine();
Console.WriteLine("Ingresar Edad de la Persona 2: ");
int edadPersona2 = Int32.Parse(Console.ReadLine());

if (edadPersona1 < edadPersona2)
{
    int dife = edadPersona2 - edadPersona1;
    Console.WriteLine("Nombre de la Persona mas chica: " + nombrePersona1);
    Console.WriteLine("Diferencia de edad entre ambos " + dife + " años");
}
else if (edadPersona1 == edadPersona2)
{

    Console.WriteLine("Ambas personas tienen la misma edad de" + edadPersona1 + " años");
}
else
{
    int dife = edadPersona1 - edadPersona2;
    Console.WriteLine("Nombre de la Persona mas chica: " + nombrePersona2);
    Console.WriteLine("Diferencia de edad entre ambos " + dife + " años");
}
Console.WriteLine("*************************************************************************  ");

/* 
    *************************************************************************
    6.Escribir un programa que calcule el tipo de un triángulo conociendo la
    longitud de sus 3 lados. También que calcule su perímetro y su área.
    *************************************************************************
*/
Console.WriteLine("EJERCICIO 6");

//Console.WriteLine("Ingresar Long lado A");
//float A = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Ingresar Long lado B");
//float B = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Ingresar Long lado C");
//float C = Int32.Parse(Console.ReadLine());

//float S = (A + B + C) * 1 / 2;
//float At = ((S * (S - A)) * (S - B) * (S - C));
//Console.WriteLine("Area del triangulo " + At);

        double[] lados = new double[3];
        bool isConvert;
        int i = 0;
        double area = 1;
        do
        {
            Console.WriteLine($"Ingrese el lado {i + 1}:");
            isConvert = double.TryParse(Console.ReadLine(), out lados[i]);
            i += (isConvert) ? 1 : 0;
        } while (i < 3);

        Array.Sort(lados);

        if (lados[2] >= lados[0] + lados[1])
        {
            Console.WriteLine("no se puede formar un triángulo");
        }
        else
        {
            if ((lados[0] == lados[1]) && (lados[1] == lados[2]))
                Console.WriteLine("El triángulo es equilátero");
            else if ((lados[0] != lados[1]) && (lados[1] != lados[2]))
                Console.WriteLine("El triángulo es escaleno");
            else
                Console.WriteLine("El triángulo es isósceles");


            double perimetro = lados.Aggregate((sum, acu) => sum + acu);
            Console.WriteLine("El perímetro del triángulo es {0} unidades.", perimetro);

            foreach (double lado in lados)
                area *= (perimetro / 2 - lado);

            area *= perimetro / 2;
            area = Math.Pow(area, 0.5);
            Console.WriteLine("El área del triángulo es: {0:0.00} unidades cuadradas", area);
        }

Console.WriteLine(" ************************************************************************* ");

/* 
    *************************************************************************
    7.Desarrolle un programa que calcule el desglose de una cantidad dada, en
    billetes y monedas tal que se minimice la cantidad de monedas y billetes.
    Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,
    donde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe
    imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de
    $20, 1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y
    tratar todos los valores como números, para los cálculos..
    *************************************************************************
*/

Console.WriteLine("EJERCICIO 7");
        double dinero = 0;
        bool isConvert2;
        int[] billetes = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
        int[] cambio = new int[billetes.Length];

        do
        {
            Console.WriteLine($"Ingrese un monto de dinero para calcular:");
            isConvert2 = double.TryParse(Console.ReadLine(), out dinero);
        } while (!isConvert2);

        for (int ij = 0; ij < billetes.Length; ij++)
        {
            cambio[ij] = ((int)(dinero / billetes[ij]));
            dinero = (dinero % billetes[ij]);
        }

        for (int ij = 0; ij < billetes.Length; ij++)
        {
            if (cambio[ij] != 0)
            {
                string tipo = (billetes[ij] > 4) ? "billete" : "moneda";
                Console.WriteLine("se entrega {0} {2} de {1}", cambio[ij], billetes[ij], tipo);
            }
        }
Console.WriteLine(" ************************************************************************* ");

/* 
    *************************************************************************
    8.Pide un número N, y muestra todos los números del 1 al N.
    *************************************************************************
*/


Console.WriteLine("EJERCICIO 8");
// si se ingresa por teclado
Console.WriteLine("Ingresar un número: ");
int n = Int32.Parse(Console.ReadLine());

for (int j = 0; j <= n; j++)
{
    Console.WriteLine("Iteración número: " + j.ToString());
}

Console.WriteLine("************************************************************************* ");

/* 
    *************************************************************************
    9.Pedir 15 números y escribir la suma total
    *************************************************************************
*/
Console.WriteLine("EJERCICIO 9");
    int suma = 0;

    for (int a = 1; a <= 1; a++)
    {
        // si se ingresa por teclado
        Console.WriteLine("Ingresar un número: ");
        n = Int32.Parse(Console.ReadLine());
        suma = suma + n;
    }
Console.WriteLine("La suma total es de: " + suma);

Console.WriteLine("************************************************************************* ");

/* 
    *************************************************************************
    10.Pide 5 números e indica si alguno es múltiplo de 3.
    *************************************************************************
*/
Console.WriteLine("EJERCICIO 10");

int num5;
//bool multiplo_3 = false;

for (int b = 1; b < 5; b++)
{
    // si se ingresa por teclado
    Console.WriteLine("Ingresar un número: ");
    num5 = Int32.Parse(Console.ReadLine());
    if (num5 % 3 == 0)
    {
        //multiplo_3 = true; // si se ejecuta esta instrucción significa que al menos hay un múltiplode 3.
        Console.WriteLine(num5 + " es multiplo de 3 ");
    }
    else
        Console.WriteLine(num5 + " no es multiplo de 3 ");
}
Console.WriteLine("************************************************************************* ");

/* 
    *************************************************************************
    11.Escriba un programa que solicite una contraseña (el texto de la contraseña
    no es importante) y la vuelva a solicitar hasta que las dos contraseñas
    coincidan.
    *************************************************************************
*/

Console.WriteLine("EJERCICIO 11");

Console.WriteLine("CONFIRME SU CONTRASEÑA");
Console.WriteLine("Ingresar contraseña: ");
string password_1 = Console.ReadLine();
Console.WriteLine("Repetir contraseña: ");
string password_2 = Console.ReadLine();

while (password_1 != password_2)
{
    Console.WriteLine("Las contraseñas no coinciden. Inténtelo de nuevo.");

    Console.WriteLine("Ingresar contraseña: ");
    password_1 = Console.ReadLine();
    Console.WriteLine("Repetir contraseña: ");
    password_2 = Console.ReadLine();
}
Console.WriteLine("Contraseña confirmada");

Console.WriteLine("************************************************************************* ");

/* 
    *************************************************************************
    12.Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres
    peticiones no debe solicitar más la contraseña y terminar el programa.
    *************************************************************************
*/

Console.WriteLine("EJERCICIO 12");

Console.WriteLine("CONFIRME SU CONTRASEÑA");

int cont = 1;
while (cont <= 3)
{
    Console.WriteLine("Ingresar contraseña: ");
    string pass1 = Console.ReadLine();
    Console.WriteLine("Repetir contraseña: ");
    string pass2 = Console.ReadLine();

    if (pass1 == pass2)
    {
        Console.WriteLine("Contraseña confirmada");
        cont = 4;
    }
    else if (cont == 3)
    {
        Console.WriteLine("Has fallado los 3 intentos");
    }
    else
    {
        Console.WriteLine("Las contraseñas no coinciden. Inténtelo de nuevo.");
    }
    cont = cont + 1;
}
Console.WriteLine("************************************************************************* ");

/* 
    *************************************************************************
    13.Proponer al usuario que adivine un número a base de intentarlo..
    *************************************************************************
*/

Console.WriteLine("EJERCICIO 13");
    Random rand = new Random();
    int random = rand.Next(0, 100);
    Console.Write(random);
    int numero6;
    int ik = 0;
    bool isConvert3 = false;
    Console.WriteLine("Adivina un número del 1 al 100!!! ");
    do
    {
        ik += 1;
        Console.WriteLine("Ingresa tu corazonada n° {0}: ", ik);
        isConvert3 = int.TryParse(Console.ReadLine(), out numero6);

    } while ((random != numero6));
    Console.WriteLine("adivinaste!!!");
Console.WriteLine("************************************************************************* ");
/* 
    *************************************************************************
    14.Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o
    «menor».
    *************************************************************************
*/

Console.WriteLine("EJERCICIO 14");
    Random rand2 = new Random();
    int random2 = rand.Next(0, 100);
    Console.WriteLine("numero random para salir: " + random);

    string texto;
    int numero7;
    int il = 0;
    bool isConvert4 = false;
    Console.WriteLine("Adivina un número del 1 al 100!!! ");
    do
    {
        i += 1;
        Console.WriteLine("Ingresa tu corazonada n° {0}: ", il);
        isConvert4 = int.TryParse(Console.ReadLine(), out numero7);
        texto = (isConvert4 && numero7 > random) ? "es menor" : "es mayor";
        if (isConvert4)
        {
            texto = (numero7> random) ? "es menor" : "es mayor";
            texto = (numero7 == random) ? "el correcto!!!! ADIVINASTE!!!" : texto;
            Console.WriteLine("El número oculto es {0}", texto);
        }
        else
            Console.WriteLine("INGRESASTE CUALQUIER COSA");
    } while ((random != numero));
Console.WriteLine("************************************************************************* ");
/* 
    *************************************************************************
    15.Crea un programa que permita sumar N números. El usuario decide cuándo
    termina de introducir números al indicar la palabra ‘fin’.
    *************************************************************************
*/

Console.WriteLine("EJERCICIO 15");
    string text = "";
    double nume;
    bool isConverti = false;
    double sum = 0;
    int im = 0;
    Console.WriteLine("Sumador de números, con la palabra fin se sale ");
    do
    {
        im += 1;
        Console.WriteLine("Ingresa tu n° {0}: ", im);
        text = Console.ReadLine();
        isConverti = double.TryParse(text, out nume);

        if (isConverti)
            sum += nume;


    } while (text != "fin");
    Console.WriteLine("la suma de todos los número dio {0}", sum);
Console.WriteLine("************************************************************************* ");