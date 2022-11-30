/*
Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input another number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("max = " + num1);
}
else
{
    Console.Write("max = " + num2);
}
*/

/*
Console.Write("Input the first umber: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > num1)
{
    max = num2;
    if(num3 > num2)
    {
        max = num3;
    }
}

Console.Write("max = " + max);

*/

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.Write("Число чётное");
}
else
{
    Console.Write("Число нечётное");
}
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num)
{
    Console.Write(current + " ");
    current +=2;
}