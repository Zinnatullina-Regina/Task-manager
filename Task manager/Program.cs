using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_manager
{
    


    class Program
    {




        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();


            workers.Add(new Worker("Boris", null)); ;
            workers.Add(new Worker("Ilxam", null));
            workers.Add(new Worker("Orkadi", null));
            workers.Add(new Worker("Vladimir",null));
            workers.Add(new Worker("Ilhat", null));
            workers.Add(new Worker("Ivan", null));
            workers.Add(new Worker("Ilia", null));
            workers.Add(new Worker("Vitia", null));
            workers.Add(new Worker("Evgeni", null));



           










            bool estProekt = false;
            bool working = true;
            List<Project> Projekts = new List<Project>();
            while (working)
            {
                Console.WriteLine("Чего тебе надобно, старче?");
                Console.WriteLine("Введите свое имя");
                string user = Console.ReadLine();
                Console.WriteLine($"Чего тебе надобно, {user}");
                Console.WriteLine("Чтобы создать поект, нажмите 1");
                Console.WriteLine("Чтобы увидеть проект и его сушность, нажмите 2");
                Console.WriteLine("Чтобы закрыть программу нажмите 3");

                int vvod;
                while ((!int.TryParse(Console.ReadLine(), out vvod) || vvod > 3 || vvod < 0))
                {
                    Console.WriteLine("Ошибка ввода! Введите нужное число");
                }

                switch (vvod)
                {
                    case 1:

                        Console.WriteLine("Введите название проекта");
                        string nameOfProjectMain = Console.ReadLine();
                        Console.WriteLine("Введите описание проекта");
                        string opisanieMain = Console.ReadLine();
                        Console.WriteLine("Введите дедлайн");


                        Console.WriteLine("Введите год");
                        int year;
                        while ((!int.TryParse(Console.ReadLine(), out year) || year < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("Введите месяц");
                        int mounth;
                        while ((!int.TryParse(Console.ReadLine(), out mounth) || mounth > 12 || mounth < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("Введите день");
                        int day;
                        while ((!int.TryParse(Console.ReadLine(), out day) || day > 31 || day < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("Введите час");
                        int hour;
                        while ((!int.TryParse(Console.ReadLine(), out hour) || hour > 24 || hour < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }
                        Console.WriteLine("Введите минуты");
                        int minut;
                        while ((!int.TryParse(Console.ReadLine(), out minut) || minut > 60 || minut < 0))
                        {
                            Console.WriteLine("Ошибка ввода! Введите нужное число");
                        }

                        DateTime date1 = new DateTime(year, mounth, day, hour, minut, 00);

                        Console.WriteLine("Введите имя заказчика");
                        string zakazchicMain = Console.ReadLine();
                        Console.WriteLine("Введите имя руководителя");
                        string liderMain = Console.ReadLine();
                        Console.WriteLine("Какие у проекта задачи");
                        Console.WriteLine("Чтобы дабавить задачу нажмите 1");
                        Console.WriteLine("Чтобы удалить предыдущую задачу нажмите 2");
                        Console.WriteLine("Если вы закончили с задачами нажмите 3");
                        bool sos = true;
                        int count = 1;
                        while (sos && (Project.StatusOfProject)(count) == Project.StatusOfProject.Planning)
                        {
                            int vvo;

                            while ((!int.TryParse(Console.ReadLine(), out vvo) || vvo > 4 || vvo < 0))
                            {
                                Console.WriteLine("Ошибка ввода! Введите нужное число");
                            }

                            switch (vvo)
                            {
                                case 1:
                                    Console.WriteLine("Введите название задачи");
                                    string nameoftaskmain = Console.ReadLine();
                                    Console.WriteLine("Введите описание");
                                    string opisanieZadachiMain = Console.ReadLine();
                                    Console.WriteLine("Введите инициатора");
                                    string nameOfIniciatorMain = Console.ReadLine();
                                    Console.WriteLine("Введите исполнителя");
                                    string nameofIspolnitelMain = Console.ReadLine();
                                    Console.WriteLine("Введите комментарий ");
                                    string kommentariMain = Console.ReadLine();

                                    Project.Tasks.Add(new Task(nameoftaskmain, opisanieMain, nameOfIniciatorMain, nameofIspolnitelMain, (Task.StatusOfTask)(1), kommentariMain, null));
                                    break;
                                case 2:
                                    Console.WriteLine("Какой элемент хотите удалить?");
                                    int delete;
                                    while ((!int.TryParse(Console.ReadLine(), out delete) || delete > Project.Tasks.Count || delete < 0))
                                    {
                                        Console.WriteLine("Ошибка ввода! Введите нужное число");
                                    }
                                    Project.Tasks.RemoveAt(delete - 1);
                                    break;
                                case 3:
                                    sos = false;
                                    break;

                            }


                            Projekts.Add(new Project(nameOfProjectMain, opisanieMain, date1, zakazchicMain, liderMain, Project.Tasks));



                        }

                        break;

                    case 2:

                        if (estProekt)
                        {
                            Console.WriteLine("Какой проект хотите увидеть?");
                            int temp = 0;
                            while (temp <= Projekts.Count)
                            {
                                Console.WriteLine(Projekts[temp]);
                                temp++;

                            }

                            int cho;
                            while ((!int.TryParse(Console.ReadLine(), out cho) || cho > Project.Tasks.Count || cho < 0))
                            {
                                Console.WriteLine("Ошибка ввода! Введите нужное число");
                            }


                            for (int i = 0; i < Projekts[cho].Tasking1.Count(); i++) {

                                if (user.Equals(Projekts[cho].Tasking1[i].Ispolnitel))
                                {
                                    int p = 0;

                                    while (!(workers[p].Name).Equals(user))
                                    {
                                        p++;
                                    }

                                    workers[p].Havingtask = Projekts[cho].Tasking1[i].NazvanieZadachi;
                                    Console.WriteLine("Вы выполнили задание?");
                                    Console.WriteLine("Нажмите 1, если нет");
                                    Console.WriteLine("Нажмите 2, если в процессе");
                                    Console.WriteLine("Нажмите 3, если да");
                                    int hight ;
                                    while ((!int.TryParse(Console.ReadLine(), out hight) || hight > 4 || hight < 0))
                                    {
                                        Console.WriteLine("Ошибка ввода! Введите нужное число");
                                    }
                                    switch (hight)
                                    {
                                        case 1:
                                            Project.Tasks[i].statusTask = Task.StatusOfTask.Get;


                                            break;
                                        case 2:
                                            count = 2;
                                            Project.Tasks[i].statusTask = Task.StatusOfTask.in_prsses;


                                            break;

                                        case 3:
                                            Project.Tasks[i].statusTask = Task.StatusOfTask.On_check;
                                            Console.WriteLine("Напишите отчет и введите его номер\n Номер:");
                                            int num;
                                            while ((!int.TryParse(Console.ReadLine(), out num) ||  num < 0))
                                            {
                                                Console.WriteLine("Ошибка ввода! Введите нужное число");
                                            }
                                            string textotchet = Console.ReadLine();
                                            Console.WriteLine("Введите дедлайн");


                                            Console.WriteLine("Введите год");
                                            int year2;
                                            while ((!int.TryParse(Console.ReadLine(), out year2) || year2 < 0))
                                            {
                                                Console.WriteLine("Ошибка ввода! Введите нужное число");
                                            }
                                            Console.WriteLine("Введите месяц");
                                            int mounth2;
                                            while ((!int.TryParse(Console.ReadLine(), out mounth2) || mounth2 > 12 || mounth2 < 0))
                                            {
                                                Console.WriteLine("Ошибка ввода! Введите нужное число");
                                            }
                                            Console.WriteLine("Введите день");
                                            int day2;
                                            while ((!int.TryParse(Console.ReadLine(), out day2) || day2 > 31 || day2 < 0))
                                            {
                                                Console.WriteLine("Ошибка ввода! Введите нужное число");
                                            }
                                            Console.WriteLine("Введите час");
                                            int hour2;
                                            while ((!int.TryParse(Console.ReadLine(), out hour2) || hour2 > 24 || hour2 < 0))
                                            {
                                                Console.WriteLine("Ошибка ввода! Введите нужное число");
                                            }
                                            Console.WriteLine("Введите минуты");
                                            int minut2;
                                            while ((!int.TryParse(Console.ReadLine(), out minut2) || minut2 > 60 || minut2 < 0))
                                            {
                                                Console.WriteLine("Ошибка ввода! Введите нужное число");
                                            }

                                            DateTime date2 = new DateTime(year2, mounth2, day2, hour2, minut2, 00);
                                            Projekts[cho].Tasking1[i].Otchet1.Add(new Otchet(textotchet, date2, Projekts[cho].Tasking1[i].Ispolnitel));

                                            break;
                                    }





                                }



                            }






                        }
                        else
                        {
                            Console.WriteLine("На данный момент у вас нет проектов.");
                        }



                        break;
                    case 3:
                        working = false;
                        break;








                }










            }



        }





    }
}
