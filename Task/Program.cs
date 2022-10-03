void PrintArray(string[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "] ");
}
void FillArray(string[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        arr[i] = Console.ReadLine();
    }
}
void NewArray (string [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Console.Write(arr[i] + " ");
        }
    }
    Console.WriteLine("]");
}