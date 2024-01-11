using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answer_for_tut7
{

    class DisabledApplicant : mBuxApplicant
    {
        private string equipment;
        private double equipValue;

        public string propEquipment
        {
            set { equipment = value; }
            get { return equipment; }
        }

        public double propEquipValue
        {
            set { equipValue = value; }
            get { return equipValue; }
        }

        public DisabledApplicant(string Equip, double eV, String N, String C, String RT, int Y) : base(N, C, RT, Y)  	  // this line calls the base constructor so we dont have to write 						  //statements to initialise variables from the base class
        {
            propEquipment = Equip;
            propEquipValue = eV;

        }

        public override double totalBuxSemester()
        {
            double disabledStudentTuition, additional_amount = 0;
            if (propYearsOfStudy == 1 || propYearsOfStudy == 2)
                additional_amount = propEquipValue;
            else
                additional_amount = propEquipValue * 0.5;

            disabledStudentTuition = base.totalBuxSemester() + additional_amount;
            return disabledStudentTuition;
        }

    }

}
