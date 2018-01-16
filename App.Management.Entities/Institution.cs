using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.InstitutionManagement.Entities
{

    public  class Institution:BaseEntity
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String Address { set; get; }
        public virtual Region Region { set; get; }
    }
}
