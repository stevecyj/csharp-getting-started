void DisplayHeader(string title)
{
    Console.WriteLine("\r\n");
    Console.WriteLine(title);
    Console.WriteLine(new string('=', 40));
}

void Q1()
{
    DisplayHeader("Q1");
    Console.WriteLine(1 + (2 + 2) * 3 - 1);
    Console.WriteLine(2 + ((2 + 1) / 3 + 1) * 2);
}

void Q2()
{
    DisplayHeader("Q2");
    Console.WriteLine(120 / 7);
    Console.WriteLine(120 % 7);
}

void Q3()
{
    DisplayHeader("Q3");
    var sum = 0M;
    for (var i = 0; i < 11; i++) sum += i;
    Console.WriteLine(sum);
}

void Q4()
{
    DisplayHeader("Q4");
    Console.WriteLine(9 % 2);
    Console.WriteLine(202 % 2);
}

Q1();
Q2();
Q3();
Q4();