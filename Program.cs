Console.Write("Введите колличество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string [] array = new string [n];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int count = 0;
 
for(int i=0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        count++;
    }
}

int j = 0;
string [] newArray = new string[count];

for(int i=0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}

Console.Write("Массив после обработки: ");
PrintArray(newArray);
Console.WriteLine();

void FillArray(string [] array)
{
    for(int i=0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array [i] = Convert.ToString(Console.ReadLine());
    }    
}

void PrintArray(string [] array)
{
    Console.Write("[ ");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.Write("]");
}
