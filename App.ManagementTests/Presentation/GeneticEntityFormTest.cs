using GApp.Entities;
using GApp.Win.Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.InstitutionManagement.WinApp.Regions;

namespace ProjectManagerTests.Presentation
{
    [TestClass()]
    public class GeneticEntityFormTest
    {
        [TestMethod()]
        public void ProjectFormTest()
        {
            // Dumy Code for Load App.Management Assembly
       
            // Find All EntityForm in Solution
            var b = AppDomain.CurrentDomain.GetAssemblies();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(asembly => asembly.FullName.StartsWith("App.")).ToList(); ;
            List<Type> ListOfEntityFormControl = new List<Type>();
            var Assemblies = GetListOfEntryAssemblyWithReferences();

            foreach (var asembly in Assemblies)
            {
                ListOfEntityFormControl
                    .AddRange(
                        asembly.GetTypes()
                        .Where(type => type.GetInterfaces().Contains(typeof(IFormControl)))
                    );
            }

            // Test Each EntityFormControl
            foreach (Type typeEntityFormControl in ListOfEntityFormControl)
            {
                // Create EntityFormControl Instance
                IFormControl EntityFormContol = Activator.CreateInstance(typeEntityFormControl) as IFormControl;

                // Create test object value
                BaseEntity entityValye = Activator.CreateInstance(EntityFormContol.TypeOfEntity) as BaseEntity;

                //project.Title = "Category 1";
                //project.Id = 1;
                //project.Ordre = 1;
                //project.DateCreation = DateTime.Now;
                //project.DateModification = DateTime.Now;
                //project.Description = "Description 1";

                //// Write value
                //projectForm.Value = project;
                //PrivateObject privateObject = new PrivateObject(projectForm);
                //TextBox TitleTextBox = privateObject.GetFieldOrProperty("titleTextBox") as TextBox;
                //Assert.AreEqual(TitleTextBox.Text, project.Title);

                //// Read value
                //Project readedProject = projectForm.Value as Project;

                //Assert.AreEqual(project.Title, readedProject.Title);
                //Assert.AreEqual(project.Id, readedProject.Id);
                //Assert.AreEqual(project.DateCreation, readedProject.DateCreation);
                //Assert.AreEqual(project.DateModification, readedProject.DateModification);
                //Assert.AreEqual(project.Description, readedProject.Description);
            }





            // Affichage du rapprot de Test
            string msg = string.Format("Test de {0} Form", ListOfEntityFormControl.Count);
            MessageBox.Show(msg);
        }


        private List<Assembly> GetListOfEntryAssemblyWithReferences()
        {
            List<Assembly> listOfAssemblies = new List<Assembly>();
            var mainAsm = this.GetType().Assembly;
            listOfAssemblies.Add(mainAsm);
            
        
       

            foreach (var refAsmName in mainAsm.GetReferencedAssemblies())
            {
                listOfAssemblies.Add(Assembly.Load(refAsmName));
            }
            return listOfAssemblies;
        }
    }
}
