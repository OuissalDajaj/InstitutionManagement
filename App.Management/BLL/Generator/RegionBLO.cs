using App.InstitutionManagement.Entities;
using GApp.BLL;
using App.InstitutionManagement.DAL;
using App.DAL;
using System.Data.Entity;
namespace  App.InstitutionManagement.BLL
{
	public partial class RegionBLO : BaseBLO<Region>{
	    
		public RegionBLO(DbContext context) : base()
        {
            this.entityDAO = new RegionDAO(context);
        }
		 
		public RegionBLO() : base()
        {
           this.entityDAO = new RegionDAO(new ModelContext());
        }
 
	}
}
