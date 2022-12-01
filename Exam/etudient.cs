using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exam
{
    public class etudient
    {
        public String Nom { get; set; }
        public String CNE { get; set; }

        public etudient(String Nom, String CNE)
        {
            this.Nom = Nom;
            this.CNE = CNE;
        }
    }
}