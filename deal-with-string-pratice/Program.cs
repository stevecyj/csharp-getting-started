void DisplayHeader(string title)
{
    Console.WriteLine("\r\n");
    Console.WriteLine(title);
    Console.WriteLine(new string('=', 40));
}

void Q1()
{
    DisplayHeader("Q1");
    var str = " abc ";
    str = str.TrimStart();
    str = str.TrimEnd();
    Console.WriteLine(str.Length);
}

void Q2()
{
    DisplayHeader("Q2");
    var str = "Allen Kuo";
    Console.WriteLine(str.ToUpper());
}

void Q3()
{
    DisplayHeader("Q3");
    var str = "aLLeN kUO";
    /*
    TextInfo myTI = new CultureInfo(en-US", false).TextInfo;
    Console.WriteLine("\"{0}\" to titlecase: {1}",str,myTI.ToTitleCase(str));
*/
    var items = str.Split(' ');
    var result = string.Empty;
    foreach (var s in items) result += s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower() + ' ';

    Console.WriteLine(result);
}

Q1();
Q2();
Q3();