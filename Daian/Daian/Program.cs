using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daian
{
    class Program
    {
        static void Main(string[] args)
        {
            // cele mai folosite tipuri de date: string, char, int, double, bool
            string sentence = "Daian";
            char letter = 'c';

            int firstNumber = 1;
            double secondNumber = 1.2;
            float thirdNumber = 1.3f;

            bool condition = false;

            // Operatori
            // Aritmetici: +,-,*,/,%,++,--
            double sum = firstNumber + secondNumber;
            // % (modulo) acesta va afisa restul impartirii a doua numere.
            // ++ incremetarea va adauga valoarea 1
            // -- decrementarea va scadea cu 1
            Console.WriteLine(sum);

            //==========================================
            // 2. Operatorii relationali (de comparatie)  ==, !=, >, <, >=, <=

            // == ne ajuta sa facem comparatia a doua numere == firstNumber  == secondNumber -> false (se compara egalitatea)   va rezulta un bool adica true sau false
            // != diferit de                                 != secondNumber != secondNumber -> true
            // >, <, >=, <= exact ca in matematica
            // firstNumber < secondNumber -> true

            //==========================================
            // 3. Operatorii logici: &&(și), ||(sau), !(negatie, reprezinta opusul a ceva...)
            //firstNumber == secondNumber && secondNumber == thirdNumber ->


        }

    }
}
