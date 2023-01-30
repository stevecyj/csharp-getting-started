/*string newsContent = "衛生署今天下午將召開記者會, 今天本土確診人數0人, 境外移入確診人數0人, 請大家繼續保持下去, 隨時洗手";
string newsBrief=newsContent.Substring(0,10);
Console.WriteLine(newsBrief);

string news = "[健康]今天下午將召開記者會";
string newsType=news.Substring(1,2);
Console.WriteLine(newsType);

string starRow=new string('*',10);
Console.WriteLine(starRow);*/

/*var s1 = "test";
var s2 = "test";
var s3 = "test1".Substring(0, 4);
object s4 = s3;

Console.WriteLine($"{object.ReferenceEquals(s1,s2)} {s1==s2} {s1.Equals(s2)}");
Console.WriteLine($"{object.ReferenceEquals(s1,s3)} {s1==s3} {s1.Equals(s3)}");
Console.WriteLine($"{object.ReferenceEquals(s1,s4)} {s1==s4} {s1.Equals(s4)}");*/

/*
string valueA="ab";
string valueB="ac";
int result=valueA.CompareTo(valueA);
Console.WriteLine(result);
*/

/*string valueA="AllEn";
string valueB="aLLeN";
int result=string.Compare(valueA,valueB,StringComparison.CurrentCultureIgnoreCase);
Console.WriteLine(result);*/

/*string url="http://www.google.com/";
bool isHttps=url.StartsWith("https://");
if (isHttps == false)
{
    Console.WriteLine("url should start with https://, please try again after modifying");
}*/

/*string title="Tips:快速連結到google的小技巧";
bool isTips=title.StartsWith("tips:",StringComparison.CurrentCultureIgnoreCase);
if (isTips == true)
{
    Console.WriteLine("這是一篇教授技巧的文章");
}*/

/*string path=@"d:\temp";
bool isValidPath=path.EndsWith("\\");
if (isValidPath == false)
{
    Console.WriteLine("結尾請加反斜線");
}*/

// var sentence = "this's a book";
/*
var location = sentence.IndexOf('\'');
if (location < 0)
    Console.WriteLine("沒有單引號");
else
    Console.WriteLine("不允許輸入單引號，請修改後再試一次");
    */

/*var location = sentence.IndexOfAny(new[] { 'a', 's' });
if (location < 0)
    Console.WriteLine("字串裡沒有'a'或's'");
else
    Console.WriteLine("'a','s'的位置是{0}", location);*/

/*var email = "jojo@gmail.com";
var isGmail = email.Contains("gmail");
if (isGmail) Console.WriteLine("請輸入 gmail 以外的 email");*/

/*string template = "台積電:2021/05/10;520;up";
int startIndex=template.IndexOf(';')+1;
int endIndex=template.IndexOf(';',startIndex);
int length=endIndex-startIndex;
string value=template.Substring(startIndex,length);
Console.WriteLine(value);*/

/*string value="abab";
string result=value.Replace('a','c');
Console.WriteLine(result);*/

var template = "台積電,2021/05/10,520;up";
template = template.Replace(',', ';');
var items = template.Split(";");
Array.ForEach(items, Console.WriteLine);