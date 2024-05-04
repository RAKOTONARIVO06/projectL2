using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION
{
    class ClassTravel
    {
        public string codeV { set; get; }
        public DateTime dateV { set; get; }
        public string codeTrain { set; get; }
        public string sourceV { set; get; }
        public string destinationV { set; get; }
        public int coastV { set; get; }
        public ClassTravel(string cod, DateTime dt, string cd, string source, string dest, int coast)
        {
            codeV=cod;
            dateV = dt;
            codeTrain = cd;
            sourceV = source;
            destinationV = dest;
            coastV = coast;
        }


    }
}
