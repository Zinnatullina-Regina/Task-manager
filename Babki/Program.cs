using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace babki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько бабушек?");
            int countGrand;
            while (!int.TryParse(Console.ReadLine(), out countGrand) || countGrand < 0)
            {
                Console.WriteLine("Неверный ввод");
            }

            var grandmothers = new List<Grandmother>();
            for (int i = 0; i < countGrand; i++)
            {
                Console.WriteLine("Какое имя у бабушки?");
                string name = Console.ReadLine();
                byte age;
                Console.WriteLine("Введите возраст бабушки");
                while (!byte.TryParse(Console.ReadLine(), out age) || age < 0)
                {
                    Console.WriteLine("Неверно введен возраст");
                }
                Console.WriteLine("Сколько болезней у бабушки?");
                int countDis;
                while (!int.TryParse(Console.ReadLine(), out countDis) || countDis < 0)
                {
                    Console.WriteLine("Неверный ввод!");
                }
                var diseases = new List<string>(countDis);
                for (int j = 0; j < countDis; j++)
                {
                    Console.WriteLine("Введите название болезни");
                    diseases.Add(Console.ReadLine().ToLower());
                }
                grandmothers.Add(new Grandmother(diseases, name, age));

            }
            int capasityInHospital1 = 5;
            var diseasesHealInHospital1 = new List<string> { "орви", "чума" };
            Hospital hospital1 = new Hospital(capasityInHospital1, diseasesHealInHospital1);

            int capasityInHospital2 = 7;
            var diseasesHealInHospital2 = new List<string> { "рак", "простуда", "альцгеймер", "отравление" };
            Hospital hospital2 = new Hospital(capasityInHospital2, diseasesHealInHospital2);
            List<Hospital> hospitals = new List<Hospital>();
            var queueGrand = new Queue<Grandmother>();
            for (int i = 0; i < grandmothers.Count; i++)
            {
                for (int j = 0; j < hospitals.Count; j++)
                {
                    if (Hospital.isWillHeal(grandmothers[i], hospitals[j]))
                    {
                        queueGrand.Enqueue(grandmothers[i]);
                    }
                }
            }


















        }
    }
}
