using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisindeki verilere erişim
            Console.Write(liste[1]);
            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("****Add Range****");
            string[] renkler = {"Kırmızı","Sarı","Yeşil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("*** Sort ***");
            liste.Sort(); //runtime'da error verir içinde birçok farklı tipte şey olduğu için

            //Binary Search
            Console.WriteLine("*** Sort ***");
            //Önce sıralayıp sonra binary search'te istediğimiz şeyin indexine ulaşabiliyormuşuz
            //Yukarıda int dışında her şeyi yoruma aldığımızda binary search düzgünce çalışacak:
            liste.BinarySearch(9);

            //Reverse
            Console.WriteLine("***Reverse***");
            liste.Reverse();

            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("***Clear***");
            liste.Clear();
            
            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}