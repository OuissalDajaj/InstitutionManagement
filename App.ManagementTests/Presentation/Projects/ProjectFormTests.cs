using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Presentation.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;
using System.Windows.Forms;

namespace App.Presentation.Projects.Tests
{
    [TestClass()]
    public class ProjectFormTests
    {
        [TestMethod()]
        public void ProjectFormTest()
        {
            ProjectForm projectForm = new ProjectForm();

            Project project = new Project();
            project.Title = "Category 1";
            project.Id = 1;
            project.Ordre = 1;
            project.DateCreation = DateTime.Now;
            project.DateModification = DateTime.Now;
            project.Description = "Description 1";

            // Write value
            projectForm.Value = project;
            PrivateObject privateObject = new PrivateObject(projectForm);
            TextBox TitleTextBox = privateObject.GetFieldOrProperty("titleTextBox") as TextBox  ;
            Assert.AreEqual(TitleTextBox.Text, project.Title);

            // Read value
            Project readedProject = projectForm.Value as Project;

            Assert.AreEqual(project.Title, readedProject.Title);
            Assert.AreEqual(project.Id, readedProject.Id);
            Assert.AreEqual(project.DateCreation, readedProject.DateCreation);
            Assert.AreEqual(project.DateModification, readedProject.DateModification);
            Assert.AreEqual(project.Description, readedProject.Description);
        }
    }
}