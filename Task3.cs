#region task3
int[] arr = { 1, 2, 3, 8, 5 };
int biggest = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > biggest)
    {
        biggest = arr[i];
    }
}
Console.WriteLine(biggest);
#endregion