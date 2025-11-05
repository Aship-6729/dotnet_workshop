// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] num = { 1, 4, 2,6, 5 };

Array.Sort(num);
Array.Reverse(num);

for(int i=0; i< num.Length; i++)
{
    Console.WriteLine(num[i]);
}

Array.IndexOf(num, 4);