using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Presentation.ProjectCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.Presentation.ProjectCategories.Tests
{
    [TestClass()]
    public class ProjectCategorieFormTests
    {
        [TestMethod()]
        public void ProjectCategorie_Read_Write_Value_FormTest()
        {
            ProjectCategorieForm projectCategorieForm = new ProjectCategorieForm();

            ProjectCategory projectCategory = new ProjectCategory();
            projectCategory.Title = "Category 1";
            projectCategory.Id = 1;
            projectCategory.Ordre = 1;
            projectCategory.DateCreation = DateTime.Now;
            projectCategory.DateModification = DateTime.Now;
            projectCategory.Description = "Description 1";

            // Write value
            projectCategorieForm.Value = projectCategory;

            // Read value
            ProjectCategory readedProjectCategory = projectCategorieForm.Value as ProjectCategory;

            Assert.AreEqual(projectCategory.Title, readedProjectCategory.Title);
            Assert.AreEqual(projectCategory.Id, readedProjectCategory.Id);
            Assert.AreEqual(projectCategory.DateCreation, readedProjectCategory.DateCreation);
            Assert.AreEqual(projectCategory.DateModification, readedProjectCategory.DateModification);
            Assert.AreEqual(projectCategory.Description, readedProjectCategory.Description);
        }




    }
}