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
                new Person("Per", new DateOnly(1990, 5, 24), true, 168, 70),
                new Person("Lotte", new DateOnly(1964, 6, 24), false, 159, 55),
                new Person("Hansi", new DateOnly(2010, 1, 8), true, 181, 78)
            };
            personArray[1].CPR = "3006921445"; 
        }
        catch (ArgumentException ex) 
        { 
            Console.WriteLine(ex.Message);
        }
        
    }


            
        

    public void LogPersons()
    {
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

