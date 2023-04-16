//Program wskazuje ile jakich cyfr jest zadanej liczbie
Console.WriteLine("Zadana liczba 1410");
int number = 1410;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

List<char> numbers = new List<char>();

numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

foreach (var digiti in numbers)
{
 int cont = 0;
 foreach (var sing in letters)
 {
 if (digiti == sing)
 { 
  cont++;
 }
}
 Console.WriteLine(digiti + " w zadanej liczbie jest " + cont);
 }