namespace App.DAL
{
    using App.InstitutionManagement.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {

        static Dictionary<String, ModelContext> UniqueContextByEntity = new Dictionary<string, ModelContext>();


        public ModelContext()
            : base(@"data source=(LocalDb)\MSSQLLocalDB;initial catalog=App.DAL.InstitutionManagement;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Classoom> Classooms { get; set; }
        public virtual DbSet<ClassoomCategory> ClassoomCategorys { get; set; }

        #region Get Unique Conrext
        /// <summary>
        /// Get the unique context by Entity Type
        /// </summary>
        /// <param name="EntityName">Entity Name</param>
        /// <returns>Modelc context instance</returns>
        public static ModelContext getContext(Type EntityType)
        {
            return getContext(EntityType.Name);

        }
        /// <summary>
        /// Get the unique context by Entity Name
        /// </summary>
        /// <param name="EntityName">Entity Name</param>
        /// <returns>Modelc context instance</returns>
        public static ModelContext getContext(string EntityName)
        {
            if (UniqueContextByEntity.ContainsKey(EntityName))
                return UniqueContextByEntity[EntityName];
            else
            {
                UniqueContextByEntity[EntityName] = new ModelContext();
                return UniqueContextByEntity[EntityName];
            }

        }
        #endregion
    }


}