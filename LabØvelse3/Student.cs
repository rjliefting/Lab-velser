using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabØvelse3
{
    public class Student
    {
        private string id; 
        private string navn;
        private decimal norsk;
        private decimal engelsk;
        private decimal matte;

        public Student(string studentId, string studentNavn, decimal norskPoeng, decimal engelskPoeng, decimal mattePoeng)
        {
            id = studentId;
            navn = studentNavn;
            norsk = norskPoeng;
            engelsk = engelskPoeng;
            matte = mattePoeng;
        }
        public string GetStudentId()
        { 
            return id; 
        }
        public void SetStudentId(string studentId)
        { 
            id = studentId; 
        }

        public string GetStudentNavn()
        {
            return navn;
        }
        public void SetStudentNavn(string studentNavn)
        {
            id = studentNavn;
        }
        public decimal GetNorskPoeng()
        {
            return norsk;
        }
        public void SetNorskPoeng(decimal norskPoeng)
        {
            norsk = norskPoeng;
        }
        public decimal GetEngelskPoeng()
        {
            return engelsk;
        }
        public void SetEngelskPoeng(decimal engelskPoeng)
        {
            engelsk = engelskPoeng;
        }
        public decimal GetMattePoeng()
        {
            return matte;
        }
        public void SetMattePoeng(decimal mattePoeng)
        {
            matte = mattePoeng;
        }

        public decimal GetAggregate()
        {
            return norsk + engelsk + matte;
        }

        public decimal GetPercentage()
        {
            return (GetAggregate() / 60) * 100;
        }
    }
}
