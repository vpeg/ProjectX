using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ProjectX
{
    class DataManager
    {
        public List<Subject> subj;
        BinaryFormatter bf;

        public DataManager()
        {
            subj = new List<Subject>();
            bf = new BinaryFormatter();
        }


        public void SaveData()
        {
            FileStream fs1 = new FileStream("subject.bin", FileMode.Create, FileAccess.Write);
            bf.Serialize(fs1, subj);
            fs1.Close();
        }

        public void LoadData()
        {
            FileStream fs2 = new FileStream("subject.bin", FileMode.Open, FileAccess.Read);
            subj = (List<Subject>)bf.Deserialize(fs2);
            fs2.Close();
        }

        public void AddSubject(Subject s)
        {
            subj.Add(s);
            SaveData();
        }

        public void DeleteSubject(Subject s)
        {
            subj.Remove(s);
            SaveData();
        }

        public void AddTestInS(Test t, string name)
        {
            foreach (Subject s in subj)
            {
                if(s.subject == name)
                {
                    s.AddTest(t);
                }
            }
            SaveData();
        }

        public void AddQuerstionInTest(Querstion q, string Sname, string Tname)
        {
            foreach (Subject s in subj)
            {
                if(s.subject == Sname)
                {
                    foreach (Test t in s.tests)
                    {
                        if(t.tName == Tname)
                        {
                            t.AddQuerstion(q);
                        }
                    }
                }
            }
            SaveData();
        }

        public void AddAnswerInQuerstion(Answer ans, string Sname, string Tname, string Querstion)
        {
            foreach (Subject s in subj)
            {
                if(s.subject == Sname)
                {
                    foreach (Test t in s.tests)
                    {
                        if(t.tName == Tname)
                        {
                            foreach (Querstion q in t.querstions)
                            {
                                if (q.querstion == Querstion)
                                    q.AddAnswers(ans);
                            }
                        }
                    }
                }
            }
            SaveData();
        }
    }
}
