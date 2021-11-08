using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
namespace babki
{
   
    
       

        public class Hospital
        {
            public static bool isWillHeal(Grandmother grandmother, Hospital hospital)
            {

                for (int i = 0; i < grandmother.GetDiseases(grandmother).Count; i++)
                {
                    for (int j = 0; j < hospital._diseasesHeal.Count; j++)
                    {
                        if (grandmother.GetDiseases(grandmother)[i] == hospital._diseasesHeal[j])
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            public Hospital(int capasity, List<string> diseasesHeal)
            {
                _capasity = capasity;
                _diseasesHeal = diseasesHeal;
            }

            private int _capasity;
            private List<string> _diseasesHeal = new List<string>();
        }
        public class Grandmother
        {
            public List<string> GetDiseases(Grandmother grandmother)
            {
                return grandmother._diseases;
            }
            public Grandmother(List<string> diseases, string name, byte age)
            {
                _age = age;
                _name = name;
                _diseases = diseases;
            }
            private List<string> _diseases = new List<string>();
            private string _name;
            private byte _age;
        }
    
}
