﻿//Zadanie 1
int a = 5;
int b = 5;

if (a == b)
{
    Console.WriteLine($"{a} i {b} są równe");
}
else
{
    Console.WriteLine($"{a} i {b} nie są równe");
}

//Zadanie 2
Console.WriteLine("Podaj liczbę:");

Int32.TryParse(Console.ReadLine(), out int number);

if (number % 2 == 0)
{
    Console.WriteLine($"{number} jest liczbą parzystą");
}
else
{
    Console.WriteLine($"{number} jest liczbą nieparzystą");
}

//Zadanie 3
Console.WriteLine("Podaj liczbę:");

Int32.TryParse(Console.ReadLine(), out int number3);

if (number3 > 0)
{
    Console.WriteLine($"{number3} jest liczbą dodatnią");
}
else if (number3 < 0)
{
    Console.WriteLine($"{number3} jest liczbą ujemną");
}
else
{
    Console.WriteLine($"{number3} nie jest ani liczbą dodatnią, ani ujemną");
}

//Zadanie 4
Console.WriteLine("Podaj rok:");

Int32.TryParse(Console.ReadLine(), out int year);

if (year % 4 == 0 && !(year % 400 == 0))
{
    Console.WriteLine($"{year} jest rokiem przestępnym");
}
else
{
    Console.WriteLine($"{year} nie jest rokiem przestępnym");
}

//Zadanie 5
Console.WriteLine("Podaj swój wiek:");

Int32.TryParse(Console.ReadLine(), out int age);

if (age >= 35)
{
    Console.WriteLine("Możesz zostać prezydentem");
}
else if (age >= 30)
{
    Console.WriteLine("Możesz zostać senatorem");
}

else if (age >= 21)
{
    Console.WriteLine("Możesz zostać posłem");
}

else if (age >= 18)
{
    Console.WriteLine("Możesz zostać premierem");
}

else 
{
    Console.WriteLine("Jesteś niepełnoletni, nie możesz sprawować funkcji publicznych");
}

//Zadanie 6
Console.WriteLine("Podaj swój wzrost (cm):");

Int32.TryParse(Console.ReadLine(), out int height);

if (height <= 150)
{
    Console.WriteLine("Jesteś krasnoludem");
}

else if (height <= 160)
{
    Console.WriteLine("Jesteś niski");
}

else if (height <= 170)
{
    Console.WriteLine("Z Twoim wzrostem jest średnio, ale może jeszcze urośniesz");
}

else if (height <= 180)
{
    Console.WriteLine("Nie jest źle, ale kariery siakarskiej nie zrobisz");
}

else if (height <= 200)
{
    Console.WriteLine("Możesz zostać siatkarzem");
}
else
{
    Console.WriteLine("Może nawet będziesz mógł blokować na stojąco ;)");
}

//Zadanie 7
Console.WriteLine("Podaj 1. liczbę:");

Int32.TryParse(Console.ReadLine(), out int num1);

Console.WriteLine("Podaj 2. liczbę:");

Int32.TryParse(Console.ReadLine(), out int num2);

Console.WriteLine("Podaj 3. liczbę:");

Int32.TryParse(Console.ReadLine(), out int num3);

if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine($"{num1} jest największa z podanych");
}

else if (num2 >= num3)
{
    Console.WriteLine($"{num2} jest największa z podanych");
}

else
{
    Console.WriteLine($"{num3} jest największa z podanych");
}

//Zadanie 8
Console.WriteLine("Wpisz wynik z matematyki:");

Int32.TryParse(Console.ReadLine(), out int mathResult);

Console.WriteLine("Wpisz wynik z fizyki:");

Int32.TryParse(Console.ReadLine(), out int physicsResult);

Console.WriteLine("Wpisz wynik z chemii:");

Int32.TryParse(Console.ReadLine(), out int chemistryResult);

if ((mathResult > 70 && physicsResult > 55 && chemistryResult > 45 && mathResult + physicsResult + chemistryResult > 180) || (mathResult + physicsResult > 150 || mathResult + chemistryResult > 150))
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}

else
{
    Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
}

//Zadanie 9
Console.WriteLine("Wpisz aktualną temperaturę:");

Int32.TryParse(Console.ReadLine(), out int temperature);

if (temperature < 0)
{
    Console.WriteLine("Cholernie piździ");
}

else if (temperature >= 0 && temperature < 10)
{
    Console.WriteLine("Zimno");
}

else if (temperature >= 10 && temperature < 20)
{
    Console.WriteLine("Chłodno");
}

else if (temperature >= 20 && temperature < 30)
{
    Console.WriteLine("W sam raz");
}

else if (temperature >= 30 && temperature < 40)
{
    Console.WriteLine("Zaczyna być słabo, bo gorąco");
}

else 
{
    Console.WriteLine("A weź, wyprowadzam się na Alaskę");
}

//Zadanie 10
Console.WriteLine("Podaj długość 1. boku:");

Int32.TryParse(Console.ReadLine(), out int a10);

Console.WriteLine("Podaj długość 2. boku:");

Int32.TryParse(Console.ReadLine(), out int b10);

Console.WriteLine("Podaj długość 3. boku:");

Int32.TryParse(Console.ReadLine(), out int c10);

if (a10 < b10 + c10 && b10 < a10 + c10 && c10 < a10 + b10)
{
    Console.WriteLine("Można zbudować trójkąt");
}

else
{
    Console.WriteLine("Nie można zbudować trójkąta");
}

//Zadanie 11
Console.WriteLine("Wpisz ocenę:");

Int32.TryParse(Console.ReadLine(), out int grade);

switch (grade)
{
    case 1:
        Console.WriteLine("Niedostateczny");
        break;

    case 2:
        Console.WriteLine("Dopuszczający");
        break;

    case 3:
        Console.WriteLine("Dostateczny");
        break;

    case 4:
        Console.WriteLine("Dobry");
        break;

    case 5:
        Console.WriteLine("Bardzo dobry");
        break;

    case 6:
        Console.WriteLine("Celujący");
        break;

    default:
        Console.WriteLine("Podałeś liczbę spoza zakresu ocen (1-6)");
        break;
}

//Zadanie 12
Console.WriteLine("Wpisz numer dnia tygodnia:");

Int32.TryParse(Console.ReadLine(), out int dayNumber);

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Poniedziałek");
        break;

    case 2:
        Console.WriteLine("Wtorek");
        break;

    case 3:
        Console.WriteLine("Środa");
        break;

    case 4:
        Console.WriteLine("Czwartek");
        break;

    case 5:
        Console.WriteLine("Piątek");
        break;

    case 6:
        Console.WriteLine("Sobota");
        break;

    case 7:
        Console.WriteLine("Niedziela");
        break;

    default:
        Console.WriteLine("Podałeś zły numer");
        break;
}

//Zadanie 13

Console.WriteLine("Podaj pierwszą liczbę");

Double.TryParse(Console.ReadLine(), out double a13);

Console.WriteLine("Podaj drugą liczbę");

Double.TryParse(Console.ReadLine(), out double b13);

double wynik = 0;

Console.WriteLine("Podaj numer operacji do wykonania:");
Console.WriteLine("1. Dodawanie");
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");

Int32.TryParse(Console.ReadLine(), out int operation);

switch (operation)
{
    case 1:
        wynik = a13 + b13;
        Console.WriteLine($"Twój wynik to: {wynik}");
        break;

    case 2:
        wynik = a13 - b13;
        Console.WriteLine($"Twój wynik to: {wynik}");
        break;

    case 3:
        wynik = a13 * b13;
        Console.WriteLine($"Twój wynik to: {wynik}");
        break;

    case 4:
        if (b13 != 0)
        {
            wynik = a13 / b13;
            Console.WriteLine($"Twój wynik to: {wynik}");
        }
        else
        {
            Console.WriteLine("Nie można dzielić przez zero!");
        }
        break;

    default:
        Console.WriteLine("Podałeś zły numer operacji");
        break;
}