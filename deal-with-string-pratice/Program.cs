using System.Globalization;

void DisplayHeader(string title)
{
    Console.WriteLine("\r\n");
    Console.WriteLine(title);
    Console.WriteLine(new string('=', 40));
}

void Q1()
{
    DisplayHeader("Q1");
    string str = " abc ";
    str=str.TrimStart();
    str=str.TrimEnd();
    Console.WriteLine(str.Length);
}

void Q2()
{
    DisplayHeader("Q2");
    string str = "Allen Kuo";
    Console.WriteLine(str.ToUpper());
}

void Q3()
{
    DisplayHeader("Q3");
    string str = "aLLeN kUO";
    TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
    Console.WriteLine("\"{0}\" to titlecase: {1}",str,myTI.ToTitleCase(str));
}

Q1();
Q2();
Q3();