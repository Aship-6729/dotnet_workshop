// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte b;
b = 0;

short s;
s = 0;

int i;
i = 42;

long l;
l = 1;

float f;
f = 2.56f;

double d;
d = 14.55;

char c;
c = 'q';

bool value;
value = false;


string sValue = i.ToString();

string aValue = "3.14";

double dValue = Convert.ToDouble(aValue);


Console.WriteLine("byte b = " + b);
Console.WriteLine("short s = " + s);
Console.WriteLine("int i = " + i);
Console.WriteLine("long l = " + l);
Console.WriteLine("float f = " + f);
Console.WriteLine("double d = " + d);
Console.WriteLine("char c = " + c);
Console.WriteLine("bool value = " + value);
Console.WriteLine("string sValue (from int) = " + sValue);
Console.WriteLine("string aValue = " + aValue);
Console.WriteLine("double dValue (converted from string) = " + dValue);

