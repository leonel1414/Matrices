int[] array = new int[2];
array[0] = 1;
array[1] = 2;

Console.Write("Array = (");
foreach (int i in array) {
    Console.Write(i + " ");
}
Console.Write(")\n");




//Segundo  Ejemplo
int[] array2 = new int[] { 1,2,3,4};

Console.Write("Array 2 = (");
foreach (int i in array2)
{
    Console.Write(i + " ");
}
Console.Write(")\n");

//Metodos
Console.WriteLine($"El promedio del array 2 es: {array2.Average()}");


//Array 3

int[] array3 = { 1, 2, 3,4,5,6};
Console.Write("Array 3 = (");
foreach (int i in array3)
{
    Console.Write(i + " ");
}
Console.Write(")\n\n");

//2D
//Declaramos un array conociendo el numero de elementos pero sin los elementos

Console.WriteLine("Array de 2D");
int[,] arr2D = new int[2,2];
for (int i = 0; i< 2; i++) {
    for (int j = 0; j <2; j++) {
        arr2D[i,j] = (i +j);
        Console.Write(arr2D[i, j] + " ");
    }
    Console.WriteLine();
}

 

