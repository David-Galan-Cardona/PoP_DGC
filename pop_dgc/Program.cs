using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        const string Input = "Introdueix ", Day = "el dia", Month = "el mes", Year = "l'any", Correct = "El format no és correcte", NotCorrect= "La data {0}-{1}-{2} és correcta",
            Menu= "A. Saltar\nB. Córrer\nC. Ajupir-se\nD. Amagar-se";
        int dia,mes,any;
        bool validat;
        string opcio;

        Console.WriteLine(Input + Day);
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Input + Month);
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Input + Year);
        any = Convert.ToInt32(Console.ReadLine());
        validat = Valida(dia, mes, any);
        if (validat == false)
        {
            Console.WriteLine(Correct);
        }
        else
        {
            Console.WriteLine(NotCorrect, dia, mes, any);
        }
        Console.WriteLine(Menu);
        opcio = Console.ReadLine();
        opcio = opcio.ToUpper();
        if (opcio == "A")
        {
            Console.WriteLine("Salt0");
        }
        else if (opcio == "B")
        {
            Console.WriteLine("Corr0");
        }
        else if (opcio == "C")
        {
            Console.WriteLine("M'ajupo");
        }
        else if (opcio == "D")
        {
            Console.WriteLine("M'amago");
        }
        else
        {
            Console.WriteLine("Opció incorrecta");
        }
    }

    public static bool Valida(int day, int month, int year)
    {

        if (day < 1 || day > 31)

            return false;

        if (month < 1 || month > 12)

            return false;

        // determinem la quantitat de dies del mes:

        int totalDaysMonth = 0;

        switch (month)
        {

            case 1:

            case 3:

            case 5:

            case 7:

            case 8:

            case 10:

            case 12: totalDaysMonth = 31; break;

            case 4:

            case 6:

            case 9:

            case 11: totalDaysMonth = 30; break;

            case 2: // verifica l'any de traspàs

                if (year % 4 == 0)
                    totalDaysMonth = 29;

                else totalDaysMonth = 28;

                break;

        }

        if (day > totalDaysMonth)

            return false;

        else return true;

    }
}