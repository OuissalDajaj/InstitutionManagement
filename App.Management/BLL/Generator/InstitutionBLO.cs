using App.InstitutionManagement.Entities;
using GApp.BLL;
using App.InstitutionManagement.DAL;
using App.DAL;
using System.Data.Entity;
namespace  App.InstitutionManagement.BLL
{
	public partial class InstitutionBLO : BaseBLO<Institution>{
	    
		public InstitutionBLO(DbContext context) : base()
        {
            this.entityDAO = new InstitutionDAO(context);
        }
		 
		public InstitutionBLO() : base()
        {
           this.entityDAO = new InstitutionDAO(new ModelContext());
        }
 
	}
}
