// See https://aka.ms/new-console-template for more information
Console.Write("Enter Number : ");
string number = Console.ReadLine();
string reverse = "";
for(int i = 0; i < number.Length; i++)
{
    reverse = number[i] + reverse;
}

Console.Write(reverse);
