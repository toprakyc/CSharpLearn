using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class CourseManager
    {
        public void Add()
        {
            Course course = new Course();       //erişebiliyorum çünkü bu erişim için aunı assembly de olması ve Course
                                                //klasının erişim belirtecinin internal olması yeterli.

        }
    }
}
