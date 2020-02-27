using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFantasticUmbrellaFactory
{
    public static class Utils
    {
        public static string GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            return semente;
        }

        public static string GeraCNPJ()
        {
            string initial = "";
            int number;
            int stDig, ndDigit;
            string num;
            int restDivision; // gets rest of division
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                number = (int)(random.Next(0, 9));
                if (number > 9) // number must be between 0 and 9
                    number = 9;
                initial += Convert.ToString(number);
            }
            initial += "0001";
            // saves in num the value from initial
            num = initial;
            // 5 4 3 2 9 8 7 6 5 4 3 2
            // calculation of the st digit
            int sum = 0;
            sum += 5 * Convert.ToInt32((num.Substring(0, 1)));
            sum += 4 * Convert.ToInt32((num.Substring(1, 1)));
            sum += 3 * Convert.ToInt32((num.Substring(2, 1)));
            sum += 2 * Convert.ToInt32((num.Substring(3, 1)));
            sum += 9 * Convert.ToInt32((num.Substring(4, 1)));
            sum += 8 * Convert.ToInt32((num.Substring(5, 1)));
            sum += 7 * Convert.ToInt32((num.Substring(6, 1)));
            sum += 6 * Convert.ToInt32((num.Substring(7, 1)));
            sum += 5 * Convert.ToInt32((num.Substring(8, 1)));
            sum += 4 * Convert.ToInt32((num.Substring(9, 1)));
            sum += 3 * Convert.ToInt32((num.Substring(10, 1)));
            sum += 2 * Convert.ToInt32((num.Substring(11, 1)));
            restDivision = (int)sum % 11;
            // if the rest is lower than 2, the first digit becomes 0,
            // otherwise, subtracts the value from 11
            if (restDivision < 2)
                stDig = 0;
            else
                stDig = 11 - restDivision;
            // calculating nd digit
            sum = 0;
            sum += 6 * Convert.ToInt32((num.Substring(0, 1)));
            sum += 5 * Convert.ToInt32((num.Substring(1, 1)));
            sum += 4 * Convert.ToInt32((num.Substring(2, 1)));
            sum += 3 * Convert.ToInt32((num.Substring(3, 1)));
            sum += 2 * Convert.ToInt32((num.Substring(4, 1)));
            sum += 9 * Convert.ToInt32((num.Substring(5, 1)));
            sum += 8 * Convert.ToInt32((num.Substring(6, 1)));
            sum += 7 * Convert.ToInt32((num.Substring(7, 1)));
            sum += 6 * Convert.ToInt32((num.Substring(8, 1)));
            sum += 5 * Convert.ToInt32((num.Substring(9, 1)));
            sum += 4 * Convert.ToInt32((num.Substring(10, 1)));
            sum += 3 * Convert.ToInt32((num.Substring(11, 1)));
            sum += 2 * stDig;
            restDivision = (int)sum % 11;
            if (restDivision < 2)
                ndDigit = 0;
            else
                ndDigit = 11 - restDivision;

            //returns cpnj
            return initial + stDig + ndDigit;
        }
    }
}
