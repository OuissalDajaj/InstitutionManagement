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

namespace App.InstitutionManagement.WinApp.Regions
{
    public partial class RegionGrid : UserControl, IDataGridControl
    {
        public RegionGrid()
        {
            InitializeComponent();
        }

        public string Title { set; get; }
        public DataGridView EntityDataGridView { set; get; }
        public BindingSource BindingSource { set; get; }
        public List<object> DataSource { set; get; }
        public event EventHandler DataChanged;
    }
}
