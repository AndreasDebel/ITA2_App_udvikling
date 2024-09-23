using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5;

    public class DiceCup
    {
        private List<Dice> diceList;
        public List<int> eyesList {  get; private set; }
        public int a_eyes { get; private set; }
        public int b_eyes { get; private set; }

    public DiceCup()
        {
            Dice a = new Dice();
            Dice b = new Dice();
    

        }
        public void ShakeCup()
        {
            a.Roll();
            b.Roll();
        }

        public void LiftCup()
        {
            a_eyes = a.GetEyes();
            b_eyes = b.GetEyes();
        }
    }

