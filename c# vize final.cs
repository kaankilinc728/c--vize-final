using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanıcıdan_notlarını_istiyoruz
{
    class Program
    {
        static void Main(string[] args)
        {
            int VizeNot;
            Console.WriteLine("Vize notunuzu girin: ");
            VizeNot = Convert.ToInt32(Console.ReadLine());

            int FinalNot;
            Console.WriteLine("Fİnal notunuzu girin: ");
            FinalNot = Convert.ToInt32(Console.ReadLine());

            double Ortalama;
            Ortalama = (VizeNot * 0.4) + (FinalNot * 0.6);
            Console.WriteLine("Orrtalamanız:" + Ortalama);
            Console.ReadLine();


        }
    }
}