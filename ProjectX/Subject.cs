using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    [Serializable]
    class Subject
    {
        public string subject;
        public List<Test> tests;

        public Subject()
        {
            tests = new List<Test>();
        }

        public Subject(string subject)
        {
            this.subject = subject;
            tests = new List<Test>();
        }

        public void DisplaySubjects()
        {
            Console.WriteLine("{0}", subject);
            foreach (Test t in tests)
            {
                Console.WriteLine(t);
                foreach (Querstion q in t.querstions)
                {
                    Console.WriteLine(q);
                    foreach (Answer ans in q.answers)
                    {
                        Console.WriteLine(ans);
                    }
                }
            }
        }

        public void AddTest(Test t)
        {
            tests.Add(t);
        }
    }
}
