using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5;

public class PersonArray
{
    public Person[]? personArray;

    public PersonArray()
    {
        try 
        {
            personArray = new Person[]
            {
                new Person("Per", "2405901661", true, 168, 70),
                new Person("Lotte", "2406647552", false, 159, 55),
                new Person("Hansi", "0801108683", true, 181, 78)
            };

        }
        catch (ArgumentException ex) 
        {
            Console.WriteLine(ex.Message);
        }

    }


            
        

    public void LogPersons()
    {
        if (personArray == null)
        {
            Console.WriteLine("No persons available to log.");
            return;
        }

        for (int i = 0; i < personArray.Length; i++)
        {
        string pronoun = "";
        string is_teenager = "";
        if (personArray[i].isMale == true) pronoun = "He"; else pronoun = "She";
        if (personArray[i].IsTeenager() == true) is_teenager = "is a teenager"; else is_teenager = "is not a teenager";
        Console.WriteLine($"At index pos. {i}, we have {personArray[i].name}. {pronoun} was born {personArray[i].birthday.ToString()}. {pronoun} is {personArray[i].height} cm tall and wheighs {personArray[i].weight} kg. BMI: {personArray[i].CalcBMI()}. {personArray[i].name} {is_teenager}. CPR: {personArray[i].CPR}");
        }
    }

            
        
}

