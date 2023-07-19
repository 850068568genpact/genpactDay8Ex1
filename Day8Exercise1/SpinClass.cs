using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Excercise1
{
    public class SpinClass
    {
        public void FirstSpin(int energy, int winprobability)
            {
                energy += 1; winprobability += 10;
            }
        public void SecondSpin(int energy, int winprobability)
            {
                energy += 2; winprobability += 20;
            }
        public void ThirdSpin(int energy, int winprobability)
            {
                energy -= 3; winprobability -= 30;
            }
        public void FourthSpin(int energy, int winprobability)
            {
                energy += 4; winprobability += 40;
            }
        public void FifthSpin(int energy, int winprobability)
            {
                energy -= 5; winprobability -= 50;
            }
        public void SixthSpin(int energy, int winprobability)
            {
                energy -= 1; winprobability -= 60;
            }
        public void SeventhSpin(int energy, int winprobability)
            {
                energy += 1; winprobability += 70;
            }
        public void EighthSpin(int energy, int winprobability)
            {
                energy -= 2; winprobability -= 20;
            }
        public void NinthSpin(int energy, int winprobability)
            {
                energy -= 3; winprobability -= 30;
            }
        public void TenthSpin(int energy, int winprobability)
            {
                energy += 10; winprobability += 100;
            }
    }
}