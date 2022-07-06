//Addition operator:
int resultAdd;
int addA = 23;
int addB = 1;

resultAdd = addA += addB;

Console.WriteLine(resultAdd);

//Subtraction operator:
int resultSub;
int subA = 4;
int subB = 55;

resultSub = subA -= subB;

Console.WriteLine(resultSub);

//Multiplication operator:
int resultMult;
int multA = 12;
int multB = 2;

resultMult = multA *= multB;

Console.WriteLine(resultMult);

//Division & Modulus operators example:
var a = 17;
var b = 4;
var quptient = a / b;
var remainder = a % b;
if (a == 17 && b == 4)
{
    Console.WriteLine(a + " / " + b + " is " + quptient + " reamainder " + remainder); 
 }
else
{
    Console.WriteLine("error");
}








//*Excersise Number 2*\\
Console.WriteLine("Please enter radius of a circle");
double radius = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * radius * radius;
Console.WriteLine($"The area of your cicle with a radius of {radius} is {area}");







//*Thought Exercise*\\
var i = 3;
var j = 4;
var k = ++i * j++;
Console.WriteLine(k);