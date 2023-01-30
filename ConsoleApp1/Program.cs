// See https://aka.ms/new-console-template for more information

/*checked
{
    int number = 65535;
    int result = number * number;
    Console.WriteLine(result);
}*/

/*
var A1 = 1.2;
Console.WriteLine(A1);

var B1 = 1.2F;
Console.WriteLine(B1);

var C1 = 1.2M;
Console.WriteLine(C1);

var number1 = 0.3;
var number2 = 0.1;
var result = number1 - number2;
Console.WriteLine(result);

var isEqual = result == 0.2;
Console.WriteLine(isEqual);

var number3 = 0.2;
var isEqual3 = number3 == 0.2;
Console.WriteLine(isEqual3);

var result2 = result * 100;
Console.WriteLine(result2);

var number4 = 0.3M;
var number5 = 0.1M;
var result3 = number4 - number5;
Console.WriteLine(result3);
bool isEqual4=(result3==0.2M);
Console.WriteLine(isEqual4);

decimal result4=result3*100;
Console.WriteLine(result4);
*/

/*int result =10/4;
Console.WriteLine(result);

double result2 =10/4;
Console.WriteLine(result2);*/

decimal total=330M;
decimal tax=total*0.05M;
int result=(int)Math.Round(tax,MidpointRounding.AwayFromZero);
Console.WriteLine(result);