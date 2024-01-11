using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answer_for_tut7
{
    class mBuxApplicant
    {
        protected String name;
        protected int yearsOfStudy;
        protected String course;
        protected String resType;

        public String propName
        {
            set { name = value; }
            get { return name; }
        }
        public String propCourse
        {
            set { course = value; }
            get { return course; }
        }
        public String propResType
        {
            set { resType = value; }
            get { return resType; }
        }

        public int propYearsOfStudy
        {
            set { yearsOfStudy = value; }
            get { return yearsOfStudy; }
        }

        public mBuxApplicant()
        {
            name = "";    //propName="";
            resType = "";
            course = "";
            yearsOfStudy = 0;
        }
        public mBuxApplicant(String paramName, String paramCourse, String paramResType, int paramYears)
        {
            propYearsOfStudy = paramYears;
            propCourse = paramCourse;
            propName = paramName;
            propResType = paramResType;
        }


        public double calcTuition()
        {
            double tuitionCost = 0;
            if (course == "Masters IT") tuitionCost = 7000;
            else if (course == "Diploma in IT") tuitionCost = 13400;
            else if (course == "Dip in Textile") tuitionCost = 4300;

            if (yearsOfStudy > 4)
                tuitionCost = tuitionCost * 0.40;

            return tuitionCost;

        }

        public virtual double totalBuxSemester()
        {
            return ((monthlyBux() * 5) + calcTuition());

        }

        public double monthlyBux()
        {
            double allowance = 0;

            if (propResType == "Private Res")
                allowance = 2000 + 1500 + 700;
            else if (propResType == "DUT Residence")
                allowance = 500;

            if (yearsOfStudy > 5)
                allowance = allowance * 0.80;

            return allowance;
        }

    }

}
