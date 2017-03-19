using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    [Serializable]
    class Test
    {
        public string tName;
        public List<Querstion> querstions;

        public Test()
        {
            querstions = new List<Querstion>();
        }

        public Test(string tName)
        {
            this.tName = tName;
            querstions = new List<Querstion>();
        }

        public void DisplayTests()
        {
            Console.WriteLine("{0}", tName);
            foreach  (Querstion q in querstions)
            {
                Console.WriteLine("{0}", q);
                foreach (Answer ans in q.answers)
                {
                    Console.WriteLine("{0}", ans);
                }
            }
        }

        public void AddQuerstion(Querstion q)
        {
            querstions.Add(q);
        }
    }
}
