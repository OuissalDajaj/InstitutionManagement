using App.InstitutionManagement.Entities;
using GApp.BLL;
using App.InstitutionManagement.DAL;
using App.DAL;
using System.Data.Entity;
namespace  App.InstitutionManagement.BLL
{
	public partial class ClassoomCategoryBLO : BaseBLO<ClassoomCategory>{
	    
		public ClassoomCategoryBLO(DbContext context) : base()
        {
            this.entityDAO = new ClassoomCategoryDAO(context);
        }
		 
		public ClassoomCategoryBLO() : base()
        {
           this.entityDAO = new ClassoomCategoryDAO(new ModelContext());
        }
 
	}
}
