//first question is way too confusing
int hours, day;


Console.WriteLine("How many hours will you be parking your car?");
hours = Convert.ToInt32(Console.ReadLine());
if (hours == 1)
{
    Console.WriteLine("That will be $4.00");
}
if  (hours == 2)
{
    Console.WriteLine("That will be $6.00");
}
if (hours == 3)
{
    Console.WriteLine("That will be $8.00");
}
if (hours == 4)
{
    Console.WriteLine("That will be $10.00");
}
if (hours == 5)
{
    Console.WriteLine("That will be $12.00");
}
if (hours == 6)
{
    Console.WriteLine("That will be $14.00");
}
if (hours == 7)
{
    Console.WriteLine("That will be $16.00");
}
if (hours == 9)
{
    Console.WriteLine("That will be $18.00");
}
if (hours == 10)
{
    Console.WriteLine("That will be $20.00");
}
if (hours > 10)
{
    Console.WriteLine("Too many hours");
}
else if (hours < 1)
{
    Console.WriteLine("No");
}


Console.WriteLine("What Catagory Hurracaine is it outside?");
day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Catagory 1 - 74-95 mph");
        break;
    case 2:
        Console.WriteLine("Catagory 2 - 96-110 mph");
        break;
    case 3:
        Console.WriteLine("Catagory 3 - 111-130 mph");
        break;
    case 4:
        Console.WriteLine("Catagory 4 - 131-155 mph");
        break;
    case 5:
        Console.WriteLine("Catagory 5 - Anything greater than mph");
        break;
}