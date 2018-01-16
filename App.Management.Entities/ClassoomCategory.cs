// File:    CategogiesSalleFormation.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:36:10
// Purpose: Definition of Class CategogiesSalleFormation

using GApp.Entities;
using System;
using System.Collections.Generic;

namespace App.InstitutionManagement.Entities
{

   public class ClassoomCategory : BaseEntity
   {

        public String Name { set; get; }
        public String Code { set; get; }
        public String Description { set; get; }
        public List<Classoom> Classrooms { get; set; }

    }
}