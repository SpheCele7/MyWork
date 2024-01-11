using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace let_him_COOK______________
{
    class one_class
    {
        protected int show;
        protected int rides;
        protected int combo;

        public int propshow
        { get; set; }
        public int proprides
        { get; set; }
        public int propcombo
        { get; set; }

        public one_class()
        { }

        public one_class(int s, int r, int c)
        {
            show = s;
            rides = r;
            combo = c;
        }

        public int method()
        {
            int s1 =show * 30;
            int r1 = rides * 45;
            int c1 = combo * 60;

            return (s1 + r1 + c1);





        }
    }
}
