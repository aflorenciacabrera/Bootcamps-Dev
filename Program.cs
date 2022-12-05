

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

Console.WriteLine("Ingresar Long lado A");
float A = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingresar Long lado B");
float B = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ingresar Long lado C");
float C = Int32.Parse(Console.ReadLine());

float S = (A + B + C) * 1 / 2;
float At = ((S * (S - A)) * (S - B) * (S - C));
Console.WriteLine("Area del triangulo " + At);

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

for (int i = 0; i <= n; i++)
{
    Console.WriteLine("Iteración número: " + i.ToString());
}

Console.WriteLine("************************************************************************* ");

/* 
    *************************************************************************
    9.Pedir 15 números y escribir la suma total
    *************************************************************************
*/
Console.WriteLine("EJERCICIO 9");
int suma = 0;

for (int i = 1; i <= 1; i++)
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

for (int i = 1; i < 5; i++)
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

