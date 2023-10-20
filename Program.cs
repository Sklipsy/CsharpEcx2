// See https://aka.ms/new-console-template for more information...
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Security.Claims;
using System.Threading.Channels;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;






/*
//ALTERNATIV KOD FOR UPPG 1 - 2 DONE<-
UserInput.GetTextFromUser();// ID
public class UserInput
{
    public static string GetTextFromUser()
    {
        Console.Write ("Please enter a word ");
        string a = Console.ReadLine();
        return a;
    }
}
*/

/*
//nr1-2 done
Console.Write("ENTER A WORD: ");
string text = Console.ReadLine();
return;
string userInput = Console.ReadLine();
Console.WriteLine(userInput);
*/


/*
//nr3 done
string message = "Please enter a number";
Console.WriteLine(message);
string userInput = Console.ReadLine();
return;
*/


/*
//nr4 DONE
string a = "number: ";
//Console.WriteLine();
Console.WriteLine($"Please enter a {a}");
string b = Console.ReadLine();
return;
*/




//nr5
/*
public class NameConcatenator
{
    public static string a(string firstName, string lastName)
    {
        
        string fullName = lastName + ", " + firstName;
        return fullName;
    }

    public static void Main()
    {
        string firstName = "Thomas";
        string lastName = "Payne";

       
        string fullName = a(firstName, lastName);

        
        Console.WriteLine(fullName); 
    }
}
*/


//-->MER FUNGERANDE KOD NEDAN MED FLER OBJECTS<-

/*
//.Length metoden
string message = "Please enter a number";
Console.WriteLine(message.Length);
string userInput = Console.ReadLine();
*/

/*
string message = "LETTERS = QWEERTTYUTUIYYUIZXCVXBXCBXCBXBC";
Console.WriteLine(message);
string userInput = Console.ReadLine();
*/

/*
//.Split metoden.
string a = "fas jp af sjkp f asj kafjs kpjkasf";
string[] b = a.Split(' ');
Console.WriteLine(b[2]);
*/