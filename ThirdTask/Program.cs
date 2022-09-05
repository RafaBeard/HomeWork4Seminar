int [] array = new int[8];
Console.Write("[");

for (int i = 0; i < array.Length; i++)
 {
    array [i] = new Random().Next(0, 50);
    Console.Write(" " + num (i) + " ");
 }
Console.Write("]");

int num (int a)
{
    return array[a];
}