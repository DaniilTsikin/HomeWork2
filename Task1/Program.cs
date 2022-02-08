int GetRandomNumber ()
{ 
    int randomNumber = new Random().Next(0,1000);
    return randomNumber;
}
int randomValue = GetRandomNumber();
Console.WriteLine($"Дано число: {randomValue}");

int secondNumber = (randomValue % 100 - randomValue % 10) / 10;
Console.WriteLine(secondNumber);
if (randomValue >= 100)
{
    Console.WriteLine($"Второе число: {secondNumber}");
}
