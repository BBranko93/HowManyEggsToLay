using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyEggsToLay
{
    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                if (Bird.Randomizer.Next(4) == 0)

                    eggs[i] = new BrokenEgg("speckled");

                else

                    eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "speckled");
            }
            return eggs;
        }
    }
}
