using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human
{
    public class Teacher:Human
    {
        public void Marking(Student stud, int Number)
        {
            stud.Marks = Number;
        }

    }
}
