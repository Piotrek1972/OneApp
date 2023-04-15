string name = "Piotrek";
var age = 50;
bool Mężczyzna = true;
string result1 = "Mężczyzna poniżej 50-tki";
string result2 = "Mężczyzna po 50-tce";
string result3 = "Piotrek, w wieku 50 lat";
string result4 = "Kobietą poniżej 50-tki";
string result5 = "Kobietą po 50-tce";
string result6 = "Nie jestes Piotrkiem, ale 50 letnią kobietą";
if (Mężczyzna == true && age < 50)
{
    Console.WriteLine(result1);
}
if (Mężczyzna == true && age > 50)
{
    Console.WriteLine(result2);
}
else if (Mężczyzna == true && name == "Piotrek" && age == 50)
{
    Console.WriteLine(result3);
}
if (Mężczyzna == false && age < 50)
{
    Console.WriteLine(result4);
}
if (Mężczyzna == false && age > 50)
{
    Console.WriteLine(result5);
}
else if (Mężczyzna == false && age == 50)
{
    Console.WriteLine(result6);
}