using GApp.Entities;
using System;
using System.Collections.Generic;

namespace App.InstitutionManagement.Entities
{
    public class Region:BaseEntity
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public virtual List<Institution> Institutions { get; set; }
    }
}