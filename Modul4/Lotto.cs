using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4
{
public class Lotto
{
    private int _lottoNumber;
    private int _size;
    private Random _random;

        public Lotto()
        {
            _random = new Random();
            _size = 35;
        }

        public Lotto(int size)
        {
            _random = new Random();
            _size = size;
        }

        public void Draw()
        {
            List<int> tickets = new List<int>();
            for (int i = 1; i <= 35; i++)
            {
                tickets.Add(i);
            }

            //foreach (int ticket in tickets)
            //{
            //    Console.WriteLine(ticket);
            //}
            //_random = new Random();
            int draws = 1;

            while (tickets.Count > 0)
            {
                int index = _random.Next(tickets.Count);
                int _lottoNumber = tickets[index];

                Console.WriteLine($"{draws} Drawn Lotto number: {_lottoNumber}");

                draws++;

                tickets.RemoveAt(index);
            }
        }
    }




}
