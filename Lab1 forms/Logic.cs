using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_forms
{
    public class Logic
    {
        public static string getresult(int n)
        {
            int ruble, penny, a, b;
            string result = "";
            if (1 <= n && n <= 9999)
            {
                ruble = n / 100;
                penny = n % 100;
                //проверка на однозначные числа рубли
                if (ruble < 20)
                {
                    a = ruble;
                }
                else
                {
                    a = ruble % 20;
                }
                //проверка на однозначные числа копейки
                if (penny < 20)
                {
                    b = penny;
                }
                else
                {
                    b = penny % 20;
                }
                //вывод: рублей
                if (5 <= a && a <= 20 || a == 0)
                {
                    //вывод: копеек
                    if (5 <= b && b <= 20 || b == 0)
                    {
                        result = ruble + " рублей " + penny + " копеек";
                    }
                    //вывод: копейка
                    else if (b == 1)
                    {
                        result = ruble + " рублей " + penny + " копейка";
                    }
                    //вывод: копейки
                    else
                    {
                        result = ruble + " рублей " + penny + " копейки";
                    }
                }
                //вывод: рубль
                else if (a == 1)
                {
                    //вывод: копеек
                    if (5 <= b && b <= 20 || b == 0)
                    {
                        result = ruble + " рубль " + penny + " копеек";
                    }
                    //вывод: копейка
                    else if (b == 1)
                    {
                        result = ruble + " рубль " + penny + " копейка";
                    }
                    //вывод: копейки
                    else
                    {
                        result = ruble + " рубль " + penny + " копейки";
                    }
                }
                //вывод: рубля
                else
                {
                    //вывод: копеек
                    if (5 <= b && b <= 20 || b == 0)
                    {
                        result = ruble + " рубля " + penny + " копеек";
                    }
                    //вывод: копейка
                    else if (b == 1)
                    {
                        result = ruble + " рубля " + penny + " копейка";
                    }
                    //вывод: копейки
                    else
                    {
                        result = ruble + " рубля " + penny + " копейки";
                    }
                }
            }
            else
            {
                result = "Число должно входить в промежуток от 1 до 9999!";
            }
            return result;
        }
    }
}
