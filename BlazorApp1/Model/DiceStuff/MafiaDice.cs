using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Model.DiceStuff
{
    public class MafiaDice : Dice
    {
        //public MafiaDice(int size) : base(size) { }

        public override int GetEyes()
        {
            if (_eyes != 6)
            {
                Roll();
                return _eyes;
            }
            else return _eyes;

        }
    }
}
