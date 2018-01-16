using App.InstitutionManagement.Entities;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.InstitutionManagement.DAL
{
    public partial class RegionDAO : BaseDAO<Region>{
        
		public RegionDAO(DbContext context) : base(context)
		{

        }

		public RegionDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
