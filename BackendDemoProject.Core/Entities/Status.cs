using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendDemoProject.Core.Entities
{
    public class Status : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
