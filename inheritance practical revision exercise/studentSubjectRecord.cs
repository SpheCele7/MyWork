using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_practical_revision_exercise
{
    class studentSubjectRecord
    {
        protected  double ment1;
        protected double ment2;
        protected double ment3;

        public double propment1
        { set; get; }

        public double propment2
        { set; get; }

        public double propment3
        { set; get; }


        protected double exam;
        public double propexam
        { set; get; }


        public studentSubjectRecord()
        {  ment1 = 0;
            ment2 = 0;
            ment3 = 0;
            exam = 0;
        }

        public studentSubjectRecord(double a1,double a2, double a3,double f)
        { ment1 = a1;
            ment2 = a2;
            ment3 = a3;
            exam = f;
        }

        public virtual double coursemark()
        { double course1 = 0;

            if (ment2 > ment3 && ment1 > ment3)
                course1 =( ment1 + ment2) / 2;

            else if (ment3 > ment1 && ment2 > ment1)
                course1 = (ment3 + ment2 )/ 2;

           else if (ment1 > ment2 && ment3 > ment2)
                course1 =( ment1 + ment3) / 2;

            return (course1);
                }

        public double finalmark()
        {

            return ((0.40 * coursemark()) + (exam * 0.60));



        }

    }
}
