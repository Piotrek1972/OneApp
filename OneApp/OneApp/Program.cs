string name = "Piotrek";
var age = "50";
bool mężczyzna = true;
string resualt1 = "Mężczyzna poniżej 50-tki";
string resualt2 = "Kobieta poniżej 50-tki";
string resualt3 = "Piotrek 50 latek";
if (mężczyzna == true && age < 50)
{
    Console.WriteLine(resualt1);
}
if (mężczyzna == false && age < 50)
{
    Console.WriteLine(resualt2);
}
else if (name == "Piotrek" && age == 50)
{
    Console.WriteLine(resualt3);
}
