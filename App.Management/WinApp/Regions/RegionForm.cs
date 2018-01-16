using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GApp.Win.Manager;
using GApp.Entities;

namespace App.InstitutionManagement.WinApp.Regions
{
    public partial class RegionForm : UserControl, IFormControl
    {
        public RegionForm()
        {
            InitializeComponent();
        }

        public string Title { set; get; }

        public Type TypeOfEntity
        {
            get
            {
                return typeof(App.InstitutionManagement.Entities.Region);
            }
        }

        public BaseEntity Value { set; get; }
    }
}
