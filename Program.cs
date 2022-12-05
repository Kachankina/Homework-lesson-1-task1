// Task 1
Console.WriteLine("Please, insert first number");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, insert second number");
int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.WriteLine("First number:" + A + "more than" + B);
}
else
{
    Console.WriteLine("Second number:" + B + "more than" + A);
}

