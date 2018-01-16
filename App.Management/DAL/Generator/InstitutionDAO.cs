using App.InstitutionManagement.Entities;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.InstitutionManagement.DAL
{
    public partial class InstitutionDAO : BaseDAO<Institution>{
        
		public InstitutionDAO(DbContext context) : base(context)
		{

        }

		public InstitutionDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
