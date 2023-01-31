/*
string value1 = null;
Console.WriteLine("null:" + string.IsNullOrEmpty(value1));

var value2 = string.Empty;
Console.WriteLine(string.IsNullOrEmpty(value2));

Console.WriteLine(string.IsNullOrWhiteSpace(value1));
Console.WriteLine(string.IsNullOrWhiteSpace(value2));

var value3 = "   ";
Console.WriteLine(string.IsNullOrWhiteSpace(value3));
*/

/*
string sentence = "商品     數量     單價";
string sentence2 = "印表機     1     3,500";
Console.WriteLine(sentence);
Console.WriteLine(sentence2);
*/

var sentence = "商品\t數量\t單價";
var sentence2 = "印表機\t1\t3,500";
Console.WriteLine(sentence);
Console.WriteLine(sentence2);

/*string path="d:\\mydocument\\file.txt";
Console.WriteLine(path);

string path2=@"d:\mydocument\file.txt";
Console.WriteLine(path2);

// sql
string query=@"SELECT Id,Name
FROM Members
WHERE Id>5 AND Id <100
ORDER BY Name DESC";
Console.WriteLine(query);*/

/*string value="thi is \"a\" book";
Console.WriteLine(value);

string value2 =@"this is ""a"" book";
Console.WriteLine(value2);*/