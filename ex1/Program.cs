// void int NewRandomNum [] = 
int number = new Random().Next(10,100);
System.Console.WriteLine(number);
int firstDigit = number/10;
int secondDigit = number%10;

System.Console.WriteLine($"{firstDigit},{secondDigit}");

if (firstDigit>secondDigit)
{
    System.Console.WriteLine(firstDigit);
}
else if (firstDigit==secondDigit)
{
    System.Console.WriteLine("Числа равны");
}
else
{
    System.Console.WriteLine(secondDigit);
}

