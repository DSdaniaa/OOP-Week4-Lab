using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.BL
{
    class students
    {
        public students(string n, float g, int r, int m, int f, int e, string h, bool i, bool ij)
        {
            Name = n;
            Cgpa = g;
            RollNumber = r;
            MatricMarks = m;
            FscMarks = f;
            EcatMarks = e;
            HomeTown = h;
            IsHostelite = i;
            IsTakingScholarship = ij;
        }
        public string Name;
        public float Cgpa;
        public int RollNumber;
        public int MatricMarks;
        public int FscMarks;
        public int EcatMarks;
        public string HomeTown;
        public bool IsHostelite;
        public bool IsTakingScholarship;

        public float calculateMerit()
        {
            float fsc, ecat, total;
            fsc = FscMarks * (60 / 100);
            ecat = EcatMarks * (40 / 100);
            total = fsc + ecat;
            return total;


        }
        public bool isEligibleforScholarship(float meritPercentage)
        {
            bool flag=false;
            if (IsHostelite == true)
            {
                if (meritPercentage > 80)
                {
                    flag= true;
                }
            }
            return flag;

        }
    }
}
