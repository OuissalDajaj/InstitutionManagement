using App.InstitutionManagement.Entities;
using GApp.BLL;
using App.InstitutionManagement.DAL;
using App.DAL;
using System.Data.Entity;
namespace  App.InstitutionManagement.BLL
{
	public partial class ClassoomBLO : BaseBLO<Classoom>{
	    
		public ClassoomBLO(DbContext context) : base()
        {
            this.entityDAO = new ClassoomDAO(context);
        }
		 
		public ClassoomBLO() : base()
        {
           this.entityDAO = new ClassoomDAO(new ModelContext());
        }
 
	}
}
