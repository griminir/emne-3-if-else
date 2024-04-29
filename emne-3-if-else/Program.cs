// See https://aka.ms/new-console-template for more information

//oppgave 1

bool areTheyEqual(int num1, int num2)
{
    if (num1 == num2) return true;
    else return false;
}

Console.WriteLine(areTheyEqual(5, 5));

//oppgave 2

int ifmath(int num1, int num2)
{
    if (num1 != num2) return num1 + num2;
    else return num1 * num2;
}
Console.WriteLine(ifmath(1,6));
Console.WriteLine(ifmath(7,7));

//oppgave 3
bool is30(int num1, int num2)
{
    if (num1 == 30 || num2 == 30 || num1 + num2 == 30) return true;
    else return false;
}
Console.WriteLine(is30(5, 30));
Console.WriteLine(is30(30, 2));
Console.WriteLine(is30(15, 15));
Console.WriteLine(is30(1, 2));