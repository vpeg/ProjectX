using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX
{
    [Serializable]
    class Answer
    {
        public string answer;
        public bool trF;
        public int nummOfQw;

        public Answer(string answer, int nummOfQw, bool trF)
        {
            this.answer = answer;
            this.nummOfQw = nummOfQw;
            this.trF = trF;
        }

        public override string ToString()
        {
            return String.Format("{0, 3}{1, 20}", nummOfQw, answer);
        }
    }
}
