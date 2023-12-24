using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GaleevTS.Sprint7.Lib
{
    public class DataService
    {
        public string GetCost(string LenghtOfFilm)
        {
            string cleanedString = new string(LenghtOfFilm.Where(char.IsDigit).ToArray());

            if (double.TryParse(cleanedString, out double Length))
            {
                double Cost = Math.Round(Length * 3.3);
                return Cost.ToString() + " руб.";
            }
            else
            {
                return "Неверный формат";
            }
        }
        public string GetAllSum(string[] SumOfCost)
        {
            int sum = 0;

            foreach (string str in SumOfCost)
            {
                int number;
                if (int.TryParse(new string(str.Where(char.IsDigit).ToArray()), out number))
                {
                    sum += number;
                }
            }
            string sumInString = Convert.ToString(sum);

            return sumInString + " руб.";
        }
        public string GetAllLength(string[] SumOfLength)
        {
            int sum = 0;

            foreach (string str in SumOfLength)
            {
                int number;
                if (int.TryParse(new string(str.Where(char.IsDigit).ToArray()), out number))
                {
                    sum += number;
                }
            }
            string lengthInString = Convert.ToString(sum);
            return lengthInString + " мин.";
        }
    }
}
