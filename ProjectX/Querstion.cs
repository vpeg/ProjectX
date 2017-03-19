using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    [Serializable]
    class Querstion
    {
        public string querstion;
        public List<Answer> answers;

        public Querstion()
        {
            answers = new List<Answer>();
        }
        public Querstion(string querstion)
        {
            this.querstion = querstion;
            answers = new List<Answer>();
        }

        public void DisplayQuerstrstion()
        {
            Console.WriteLine("{0}", querstion);
            foreach (Answer ans in answers)
            {
                Console.WriteLine(ans);
            }
        }

        public void AddAnswers(Answer a)
        {
            answers.Add(a);
        }
    }
}
