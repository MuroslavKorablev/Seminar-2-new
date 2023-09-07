// void int NewRandomNum [] = 
void FindMaxDigit(int number)
{   int firstDigit = number/10;
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
}

int num = new Random().Next(10,100);
System.Console.WriteLine(num);
int num1 = new Random().Next(10,100);
System.Console.WriteLine(num1);
int num2 = new Random().Next(10,100);
System.Console.WriteLine(num2);

FindMaxDigit(num);
FindMaxDigit(num1);
FindMaxDigit(num2);


