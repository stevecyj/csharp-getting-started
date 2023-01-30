string value1=null;
Console.WriteLine(string.IsNullOrEmpty(value1));

string value2=string.Empty;
Console.WriteLine(string.IsNullOrEmpty(value2));

Console.WriteLine(string.IsNullOrWhiteSpace(value1));
Console.WriteLine(string.IsNullOrWhiteSpace(value2));

string value3="   ";
Console.WriteLine(string.IsNullOrWhiteSpace(value3));