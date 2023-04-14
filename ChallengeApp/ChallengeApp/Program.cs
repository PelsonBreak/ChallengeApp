using System.ComponentModel.Design;

var name1 = ("Ewa");
var gender1 = ("female");
var age1 = 29;
var age2 = 33;

if (gender1 == "female" && age1 < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}

if (name1 == "Ewa"  && gender1 == "female" && age2 > 32)
{
    Console.WriteLine("Ewa, lat 33");
}
else
{
    Console.WriteLine("Nie jestem Ewa");
}

string name2 = ("Adam");
string gender2 = ("male");
int age3 = 17;

if (name2 == "Adam" && gender2 == "male" && age3 < 18)
{
    Console.WriteLine("Niepełnoletni mężczynza");
}
else
{
    Console.WriteLine("Nie jestem Adam");
}

if (gender2 == "male")
{
    Console.WriteLine("Adam jest mężczyzną");
}
else
{
    Console.WriteLine("Adam jest kobietą");
}
if (!(gender2 == "male"))
{
    Console.WriteLine("Adam jest mężczyzną");
}
else
{
    Console.WriteLine("Adam jest kobietą");
}