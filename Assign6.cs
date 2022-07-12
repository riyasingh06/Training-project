using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharrpApplication
{
    public class Students
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public int GrPoint { get; set; }

        public static void num6()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });
            var result= (from st in stulist
                        orderby st.GrPoint descending
                        select st).Take(3);


        }
    }
    
        

    internal class Assign6
    {
    }
}
