﻿int GetRandomNumber ()
{ 
    int randomNumber = new Random().Next(0,1000);
    return randomNumber;
}
int randomValue = GetRandomNumber();
Console.WriteLine($"Дано число: {randomValue}");