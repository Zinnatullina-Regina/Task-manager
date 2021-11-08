using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_manager
{
    public class Project
    {

      public enum StatusOfProject
        {
            Planning = 1,
            Processing,
            Done



        }



        private string nazvanie;
        private string opisanieOfProject;
        public DateTime deadline;
        private string zakazchic;
        private string teamlid;
        public string Nazvanie
        {
            get { return nazvanie; }
        }

        public string OpisanieOfProject
        {
            get { return opisanieOfProject; }
        }
        public string Zakazchic
        {
            get { return zakazchic; }
        }
        public string Teamlid
        {
            get { return teamlid; }
        }

        static public  List<Task> Tasks = new List<Task>();
       
        public List<Task> Tasking1
        {
            get { return Tasks; }
            set { }
        }

        public Project(string nazvanie, string opisanieOfProject, DateTime deadline, string zakazchic, string teamlid, List<Task> Tasks)
        {

            this.nazvanie = nazvanie;
            this.opisanieOfProject = opisanieOfProject;
            this.deadline = deadline;
            this.zakazchic = zakazchic;
            this.teamlid = teamlid;
           
        }
    }

}
