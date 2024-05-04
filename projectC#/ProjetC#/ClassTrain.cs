using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION
{
    class ClassTrain
    {
        public string numTrain { get; set; }
        public string capacityTrain { get; set; }
        public string statusTrain { get; set; }
        public ClassTrain(string ID, string cap, string stat)
        {
            numTrain = ID;
            capacityTrain = cap;
            statusTrain = stat;
        }

    }
}
