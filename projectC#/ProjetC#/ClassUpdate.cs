using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION
{
    class ClassUpdate
    {
        public string idRes { get; set; }
        public string idcli { get; set; }
        public string codev { get; set; }
        public string typeofpaid { get; set; }
        public int prix { get; set; }

        public ClassUpdate(string res, string idCli, string codeV, string typeOfpaid, int price)
        {
            idRes = res;
            idcli = idCli;
            codev = codeV;
            typeofpaid = typeOfpaid;
            prix = price;

        }
    }
}

