//using Bootcamps_Dev;

//  .NET - C# - Ejercicios - Clases 5 y 6
//  Arreglos y Listas


// Ejercicio1();
// Ejercicio2();
//Ejercicio3();
// Ejercicio4();
 Ejercicio5();
// Ejercicio6();
// Ejercicio7();
// Ejercicio8();


/***** Ejercicio 1 
Dado que se tiene almacenado en una lista, los resultados de los últimos 10
exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10
notas de los exámenes y el promedio resultante.*/
void Ejercicio1() 
{
    //  arreglo
    double[] calificaciones = { 90, 98, 85, 95, 90, 80, 70, 100, 55,60 };
    // la sumatoria iniciada en 0
    double sumatoria = 0;
    // Resorre con un foreach
    foreach (double calificacion in calificaciones)
    {
        // Ir agregando la calificación a la sumatoria
        sumatoria += calificacion;
        //Muestra las calificaciones
        Console.WriteLine("Calificaciones: " + calificacion);
    }
    // El promedio resulta de dividir la sumatoria entre la cantidad de elementos
    double promedio = sumatoria / calificaciones.Length;
    //Muestra el Promedio
    Console.WriteLine("Promedio: " + promedio);
}

/***** Ejercicio 2 
Dada las edades de 20 personas guardadas en una lista, imprimir por
pantalla cuántos son mayores de edad y cuántos no.*/
void Ejercicio2()
{
    //  arreglo
    int[] edades = { 32, 17,5, 34, 26, 60, 10, 2, 56, 15, 47, 17, 5, 34, 16, 60, 10, 72, 56, 85 };
    int mayores = 0;
    int menores = 0;
    // Resorre con un foreach
    foreach (double edad in edades)
    {
        if (edad >= 18)
        {
            // cuento los mayores 
             mayores = mayores + 1;
        }
        else
        {   
            // cuento los menores 
            menores = menores + 1;
        }
       
       
    }
    //Muestra las edades
    Console.WriteLine("Mayores de Edad: " + mayores);
    Console.WriteLine("Mayores de Edad: " + menores);
}

/***** Ejercicio 3 
Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y
el que tenga menos letras de todos.*/
void Ejercicio3()
{
    string[] nombres = {
        "pedro", "juan","manuel" ,"elena" ,"maría" , "carolina"
    };

    int mayor = nombres[0].Length;
    int menor = nombres[0].Length;
    int pos = 0;
    int pos1 = 0;


    for (int i = 0; i < nombres.Length; i++)
    {
        if (nombres[i].Length > mayor)
        {
      
            mayor = nombres[i].Length;
            pos = i;
        }
    }
    for (int i = 0; i < nombres.Length; i++)
    {
        if (nombres[i].Length < menor)
        {

            menor = nombres[i].Length;
            pos1 = i;
        }

    }
    Console.WriteLine("Nombre con Mayor N° de Letras: " + nombres[pos] +" "+ nombres[pos].Length) ;
    Console.WriteLine("Nombre con Menor N° de Letras: " + nombres[pos1]+ " "+ nombres[pos1].Length)  ;
}

/***** Ejercicio 4 
Crear una variable para guardar los nombres de elementos para una “lista de
supermercado”. Solicitar al usuario que ingrese el nombre de un elemento
que va a comprar en el super y verificar que el elemento esté en la lista. Si no
está, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar
que sí estaba. Al finalizar mostrar por pantalla los elementos que no compró y
los que compró, pero no estaban en la lista. Si se quiere, mostrar también
todos los elementos que el usuario compró. Para salir el usuario debe
ingresar “fin”..*/
void Ejercicio4()
{
    //List<string> listaSuper = new List<string>{
    //    "leche", "azucar","fideo" ,"polenta" ,"carne" , "verduras","jugo", "café"
    //};
    List<string> complist = new List<string>(){
        "leche", "azucar","fideo" ,"polenta" ,"carne" , "verduras","jugo", "café"
    };
    List<string> ListaCompra = new List<string>();
   
    string[] result = { };
    string[] listasuper2 = {
        "leche", "azucar","fideo" ,"polenta" ,"carne" , "verduras","jugo", "café"
    };
    Console.WriteLine("Ingresar compra del supermercado: ");
    string compra = Console.ReadLine();
  
    foreach (string comp in complist) { 
        if (compra == comp)
        {
           
            //complist.Remove(compra);
            result = listasuper2.Where(val => val != compra).ToArray();

        }
        if (compra != comp)
        {
          
            complist = complist.Append(compra).ToList();
            //Para finalizar el for.
            //i = complist.Count() + 1;
        }

    }
 
    Console.WriteLine("**********************:  " );
    Console.WriteLine("El producto "+ compra+" no esta en la lista:  ");
    Console.WriteLine(String.Join("\n", complist));
    Console.WriteLine("El producto "+ compra+" ya esta en la lista: ");
    Console.WriteLine(String.Join("\n", result));

   
}

/***** Ejercicio 5 
Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en
lugares pares. Imprimir la matriz por pantalla.*/
void Ejercicio5()
{
    int[,] matriz5x5 = { 
        { 1, 2, 33, 4, 5 }, 
        {6 , 7, 8, 16, 10 },
        {15 , 17, 7, 59,70 },
        {6 , 20, 75, 9, 50 },
        {66 , 7, 35, 89, 90 }
    };
    //Matriz aux para mostrar por pantalla
    string[,] matriz5x5aux = new string[5, 5];
    long sobrante;

    for (int f = 0; f < matriz5x5.GetLength(0); f++)
    {

        for (int c = 0; c < matriz5x5.GetLength(1); c++)
        {
            // Console.Write(matriz5x5[f, c] + " ");
              sobrante = matriz5x5[f, c] % 2;
            if (sobrante == 0)
            {
                //Console.Write("P ");
                //matriz5x5[f, c] =  4 ;
                matriz5x5aux[f, c] = "P";
            }
            else
            {
                //Console.Write("I ");
                matriz5x5aux[f, c] = "I";
            }
            //matriz5x5[f, c] = matriz5x5[f, c];
           
            
            Console.Write(matriz5x5aux[f, c] + " ");

        }
        Console.WriteLine();
       
    }
   // int[,] theArray = new int[5, 10];
   //Console.WriteLine("The array has {0} dimensions.", theArray.Rank);
}
/***** Ejercicio 6 
Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los
días de la semana. La estructura es para registrar la temperatura diaria de
una cabina de pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la
matriz de forma aleatoria para el mes de mayo donde el primer día inicia en
lunes y el último (31) se ubica en el miércoles (la matriz puede ser inicializada
con valores aleatorios desde el principio del programa, no es necesario pedir
los valores al usuario para cada posición). Se nos pide hacer lo siguiente:
a. Obtener la temperatura más alta y baja de la semana y que día se
produjo (lunes, martes, etc.)
b. Promedio de temperatura de la semana.
c. Temperatura más alta del mes y su día..*/
void Ejercicio6()
{
}
/***** Ejercicio 7 
Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la
primera fila y la primera columna se debe guardar los números (de 0 a 9),
estando el cero en la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado usando los números que se dispone, por ejemplo,
en la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones del array o
arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla.*/
void Ejercicio7()
{
}
/***** Ejercicio 8 
Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la
cantidad que el programador decida, pero no más de la mitad de los lugares
disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que
hay una X, ingresando la fila y la columna por separado. Informar si acertó o
no por cada ingreso. Se debe pedir al usuario ingresar valores por tantas X
que se haya guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya
sea porque se terminaron los 3 intentos, o el jugador acertó todas las X)
imprimir por pantalla la matriz con sus correspondientes X, mostrando un *
donde no haya nada..*/
void Ejercicio8()
{
}
