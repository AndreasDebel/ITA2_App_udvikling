using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5;

public class PersonArray
{
    public Person[] personArray;

    public PersonArray()
    {
        personArray = new Person[]
        {
            new Person("Per", new DateOnly(1990, 5, 24), true, 168, 70),
            new Person("Lotte", new DateOnly(1964, 6, 24), false, 159, 55),
            new Person("Hansi", new DateOnly(1980, 1, 8), true, 181, 78)
        };
    }

}
            
        

        public void LogPersons()
        {
            for (int i = 0; i < personArray.Length; i++)
            {
                Console.WriteLine($"At index pos. {i}, we have {personArray[i].name}.");
            }
        }


            
        
    }

