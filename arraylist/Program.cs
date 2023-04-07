using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arraylist liste = new Arraylist();
            liste.Add("ayse");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //erisim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);

            //AddRange
            Console.WriteLine("**** AddRange ****");
            //string[] renkler = { "kirmizi", "sari", "yesil" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //sort
            Console.WriteLine("**** sort ****");
            liste.Sort();

            //binary search
            Console.WriteLine("**** binary search ****");
            Console.WriteLine(liste.BinarySearch(9));

            //reverse
            Console.WriteLine("**** reverse ****");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //clear
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);
            

        }
    }
}
