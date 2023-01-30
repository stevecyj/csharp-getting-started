void DisplayHeader(string title)
{
    Console.WriteLine("\r\n");
    Console.WriteLine(title);
    Console.WriteLine(new string('=', 40));
}

void Q1()
{
    DisplayHeader("Q1");
    var str = @"D:\temp\animal.jpg";
    Console.WriteLine(str);
}

void Q2()
{
    DisplayHeader("Q2");
    var str = "我是一個\"好學生\"，會乖乖練習寫作業";
    Console.WriteLine(str);
}

void Q3()
{
    DisplayHeader("Q3");
    var str = "我是第一行文字\r\n" +
              "我是第二行文字\r\n";
    Console.WriteLine(str);
}

void Q4()
{
    DisplayHeader("Q4");
    var str = @"<select>
   <option value=""1"">台北</option>
</select>";
    Console.WriteLine(str);
}

Q1();
Q2();
Q3();
Q4();