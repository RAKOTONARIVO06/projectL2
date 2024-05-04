using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION
{
    class ClassClient
    {
        public string idCli { get; set; }
        public string nameCli { get; set; }
        public string contactCli { get; set; }
        public ClassClient(string ID, string NAME, string CONTACT)
        {
            idCli = ID;
            nameCli = NAME;
            contactCli = CONTACT;
        }
    }
}
