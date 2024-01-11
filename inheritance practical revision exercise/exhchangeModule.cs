using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_practical_revision_exercise
{
    class exhchangeModule : studentSubjectRecord

    {
        private double project;
        public double propproject
        { set; get; }

        public exhchangeModule()
        { project = 0.0; }

        public exhchangeModule(double p,double a1,double a2,double a3, double f): base(a1,a2,a3,f)
        { project = p; }

        public override double coursemark()
        {
            double course1 = 0, vax = 0.60 * exam;

            if (ment2 > ment3 && ment1 > ment3)
                course1 = ((ment1 + ment2) /2)*(0.40);

            else if (ment3 > ment1 && ment2 > ment1)
                course1 = ((ment3 + ment2) / 2)*(0.40);

            else if (ment1 > ment2 && ment3 > ment2)
                course1 = ((ment1 + ment3) / 2)*(0.40);

            return (course1+vax);
        }

        public double finalmark2()
        {

            return ((0.40 * coursemark()) + (exam * 0.60));



        }
    }
}
