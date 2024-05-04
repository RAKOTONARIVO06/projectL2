using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION
{
    class ClassReservation
    {
       // public int idres { get; set; }
        public string idcli { get; set; }
        public string codev { get; set; }
        public string typeofpaid { get; set; }
        public int prix { get; set; }
        
        public ClassReservation( string idCli, string codeV, string typeOfpaid, int price)
        {
            //idres = idRes;
            idcli = idCli;
            codev = codeV;
            typeofpaid = typeOfpaid;
            prix = price;
            
        }
    }
}
