using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Laba4
{
    public class LogicClass
    {
        public int NumbersDelta(int n1, int n2)
        {
            return Math.Abs(n1 - n2);
        }

        public int ListLength(List<string> list)
        {
            return list.Count();
        }

        public bool YearOfWar(int year)
        {
            return year == 1939;
        }

        public string Seasons(int monthNumber) 
        {
            int[] winter = { 12, 1, 2 };
            int[] spring = { 3, 4, 5 };
            int[] summer = { 6, 7, 8 };
            int[] autumn = { 9, 10, 11 };
            if (winter.Contains(monthNumber)) return "Зима";
            if (spring.Contains(monthNumber)) return "Весна";
            if (summer.Contains(monthNumber)) return "Лето";
            if (autumn.Contains(monthNumber)) return "Осень";
            else return "Не существующее время года";
        }

        public int CountMinutes(int hour)
        {
            return hour * 60;
        }

        public string EditTopic(string topic)
        {
            return $"Текущая тема: {topic.ToUpper()}";
        }

        public int ArrayTrippledSumm(List<int> numbers)
        {
            int summ = 0;
            foreach (int number in numbers)
            {
                summ += number * 3;
            }
            return summ;
        }
    }
}
