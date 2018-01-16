using GApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Management
{
    /// <summary>
    /// must to be out of this project
    /// it well make redundancy declaration in master proect
    /// because of it  namesapce
    /// </summary>
    public partial class MainForm : Form
    {

        List<Type> listTypesOfForms = new List<Type>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMainMenu();
        }

        private void LoadMainMenu()
        {
            // Fin all Forms in current project
            listTypesOfForms = Assembly
                .GetAssembly(this.GetType())
               .GetTypes().Where(t => t.BaseType.Name == typeof(Form).Name).ToList<Type>();

            listTypesOfForms.Remove(this.GetType());
            foreach (Type item in listTypesOfForms)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Text = item.Name;
                menuItem.Click += MenuItem_Click;
                mainMenu.Items.Add(menuItem);
            }


        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            Type FormType =  listTypesOfForms.Where(t => t.Name == menuItem.Text).FirstOrDefault();
            if(FormType != null)
            {
                // Create Instance
                Form form = Activator.CreateInstance(FormType) as Form;
                form.Show();
            }
        }
    }
}
