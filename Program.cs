Console.Write("Введите массив данных = ");
string m = Console.ReadLine();
string[] array = m.Split(' ');
string[] newArray = new string[array.Length];
void PrintArray(string[] arr)
{   Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
   
};
PrintArray(array);

void resultArray(string[] arrayAdded, string[] arrayRes) {
    int count = 0;
    for ( int i = 0; i < arrayAdded.Length; i ++) {
        if (arrayAdded[i].Length < 4) {
            arrayRes[count] = arrayAdded[i];
            count ++;

        }
    }
}
resultArray(array, newArray);
PrintArray(newArray);