// File:    Salle.cs
// Author:  ESSARRAJ
// Created: dimanche 28 décembre 2014 16:36:10
// Purpose: Definition of Class Salle

using GApp.Entities;
using System;

namespace App.InstitutionManagement.Entities
{
   public class Classoom : BaseEntity
   {
        public String Name { set; get; }
        public String Code { set; get; }
        public  ClassoomCategory CategogiesClassroom { set; get; }
        public String Description { set; get; }
    }
}