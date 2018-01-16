using App.InstitutionManagement.Entities;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.InstitutionManagement.DAL
{
    public partial class ClassoomCategoryDAO : BaseDAO<ClassoomCategory>{
        
		public ClassoomCategoryDAO(DbContext context) : base(context)
		{

        }

		public ClassoomCategoryDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
