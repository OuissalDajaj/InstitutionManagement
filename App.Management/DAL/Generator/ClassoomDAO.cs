using App.InstitutionManagement.Entities;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.InstitutionManagement.DAL
{
    public partial class ClassoomDAO : BaseDAO<Classoom>{
        
		public ClassoomDAO(DbContext context) : base(context)
		{

        }

		public ClassoomDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
