using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDatabase
{
    public partial class Checks
    {
        public class DeleteChecks
        {
            public bool id = false;
            public bool manufactureId = false;
            public bool modelYear = false;
            public bool horsePower = false;
            public bool torque = false;
            public bool length = false;
            public bool width = false;
        }
        public DeleteChecks deleteChecks = new DeleteChecks();
    }
}
