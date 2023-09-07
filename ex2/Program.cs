// Напишите программу которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
int num1 = new Random().Next(100, 1000);
System.Console.WriteLine(num1);

deleteSecondDigit(num1);

void deleteSecondDigit(int number)
{
    int firstDigit = number / 100; // Получаем первую цифру
    int thirdDigit = number % 10;  // Получаем третью цифру
    int result = firstDigit * 10 + thirdDigit; // Соединяем первую и третью цифры, удаляя вторую
    System.Console.WriteLine(result); // Выводим результат
}



