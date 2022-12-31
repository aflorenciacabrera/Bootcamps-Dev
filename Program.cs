//using Bootcamps_Dev;

//  Guía de Ejercicios 3
// .NET - C# - Ejercicios - Clases 5 y 6
// Arreglos y Listas


// Ejercicio1();
Ejercicio2();
// Ejercicio3();
// Ejercicio4();
// Ejercicio5();
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