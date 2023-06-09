﻿int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine()) + 30;

if (minutes >= 60)
{
    hours += 1;
    minutes -= 60;
}

if (hours >= 24)
{
    hours = 0;
}

Console.WriteLine($"{hours}:{minutes:D2}");