using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_manager
{
    public class Otchet
    {
        private string tekst;
        public DateTime date;
        private string ispolnitel;

        public string Tekst
        {
            get { return tekst; }
        }
        public string Ispolnitel
        {
            get { return ispolnitel; }
        }

        public Otchet(string tekst, DateTime date, string ispolnitel)
        {
            this.tekst = tekst;
            this.date = date;
            this.ispolnitel = ispolnitel;

        }
    }



    public class Task
    {
        public enum StatusOfTask
        {
            Get = 1,
            in_prsses,
            On_check,
            Done


        }





        private string nazvanieZadachi;
        private string opisanie;
        private string iniciator;
        private string ispolnitel;
        public StatusOfTask statusTask;
        private string kommentar;

        public string NazvanieZadachi
        {
            get { return nazvanieZadachi; }
        }
        public string Opisanie
        {
            get { return opisanie; }
        }
        public string Iniciator
        {
            get { return iniciator; }
        }
        public string Ispolnitel
        {
            get { return ispolnitel; }
        }

        public string Kommentar
        {
            get { return kommentar; }
        }



        static public List<Otchet> Otchets = new List<Otchet>();



        public List<Otchet> Otchet1
        {
            get { return Otchets; }
            set { }
        }







        public Task(string nazvanieZadachi, string opisanie, string iniciator, string ispolnitel, StatusOfTask statusTask, string kommentar, List<Otchet> Otchets)
        {
            this.nazvanieZadachi = nazvanieZadachi;
            this.iniciator = iniciator;
            this.ispolnitel = ispolnitel;
            this.opisanie = opisanie;
            this.statusTask = statusTask;
            this.kommentar = kommentar;
            this.Otchet1 = Otchets;
        }





    }







    class Worker
    {

        private string name;
        private string havingtask;

        public string Name
        {
            get { return name; }
        }
        public string Havingtask
        {
            get { return havingtask; }
            set { }
        }
        public Worker(string name, string havingtask)
        {

            this.name = name;
            this.havingtask = havingtask;
        }


    }

}
