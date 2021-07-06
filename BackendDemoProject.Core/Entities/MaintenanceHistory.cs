using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDemoProject.Core.Entities
{
    public class MaintenanceHistory : BaseEntity
    {
        public int MaintenanceID { get; set; }
        public int ActionTypeID { get; set; }
        public string text { get; set; }


        public virtual Maintenance Maintenance { get; set; }
        public virtual ActionType ActionType { get; set; }
    }
}
