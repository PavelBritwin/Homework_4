// See https://aka.ms/new-console-template for more information
Random rnd = new Random();
int x1 = rnd.Next(1,100);
Console.WriteLine($"x1: {x1}");
int x2 = rnd.Next(1,100);
Console.WriteLine($"x2: {x2}");
int [] firstArray = new int[Math.Abs(x1-x2)+1];
int x3 = rnd.Next(1,100);
Console.WriteLine($"x3: {x3}");
int x4 = rnd.Next(1,100);
Console.WriteLine($"x4: {x4}");
Console.Write("First array: ");
int [] secondArray = new int[Math.Abs(x3-x4)+1];
for (int i = Math.Min(x1,x2); i < Math.Max(x1,x2)+1; i++)
{
    firstArray[i - Math.Min(x1,x2)] = i;
    Console.Write(firstArray[i - Math.Min(x1,x2)]+" ");
}
Console.WriteLine();
Console.Write("Second array: ");
for (int i = Math.Min(x3,x4); i < Math.Max(x3,x4)+1; i++)
{
    secondArray[i - Math.Min(x3,x4)] = i;
    Console.Write(secondArray[i - Math.Min(x3,x4)]+" ");
}
string result = "";
for (int j = 0; j < firstArray.Length; j++)
{
    if (Array.Exists(secondArray, element => element == firstArray[j]))
        result += firstArray[j].ToString() + " ";
}
if (result == "") result = "No crossed items";
Console.WriteLine();
Console.WriteLine("Common numbers: "+result);