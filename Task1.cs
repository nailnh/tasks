#region task1
Console.WriteLine("Enter your exam result:");
int pts = int.Parse(Console.ReadLine());

if (pts >= 0 && pts < 51)
{
    Console.WriteLine("Your grade is F, You have failed");
}else if (pts >= 51 && pts < 61)
{
    Console.WriteLine("Your grade is E");
}else if(pts >= 61 && pts < 71)
{
    Console.WriteLine("Your grade is D");
}else if (pts >= 71 && pts < 81)
{
    Console.WriteLine("Your grade is C");
}else if (pts >= 81 && pts < 91)
{
    Console.WriteLine("Your grade is B");
}else if (pts >= 91 && pts <= 100)
{
    Console.WriteLine("Your grade is A");
}else
{
    Console.WriteLine("Enter a valid amount of points");
}

#endregion 
//Fun fact: "E" eslinde yoxdur :)