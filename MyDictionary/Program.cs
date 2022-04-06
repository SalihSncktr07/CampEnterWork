using MyDictionaryDemo;
using System;
using System.Collections.Generic;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> days= new MyDictionary<string,int>();

            days.Add("Pazartesi",1);
            days.Add("Salı",2);
            days.Add("Çarşamba",3);
            days.Add("Perşembe",4);
            days.Add("Cuma",5);
            days.Add("Cumartesi",6);
            days.Add("Pazar",7);
            Console.WriteLine(days.GetValueOrDefault("Cumartesi"));
        }
    }
}
