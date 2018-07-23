using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using Northwind.Data.Entities;

#endregion
namespace NorthwindSystem.DAL
{
    // do add a little Security to the database access, we will set the access privilege of this class to internal
    // this access restricts calls to this class from within this project only
    // this class will be created by any BLL controller class method

        //this class will interact with the entity framework software to access the database
        //to setup this interaction, this class will inherit from EntityFramework its DbContext class

    internal class NorthwindContext:DbContext //if DbContext has red squiggles, install the Entity Framework
    {
        // we need to pass the database connection to the EntityFramework DbContext class via the :base("xxxx") parameter,
        // this is done via the NorthwindContext constructor
        public NorthwindContext() : base("NWDB")
        {

        }

        //indicate the property in this context class that will connect the SQL table to the data definition class
        //this is done by using the EntityFramework datatype DbSet<T>, where <T> is the data definition class
        public DbSet<Product> Products { get; set; } //<Product> is data definition, Products is a property; a Set is plural => so we use ProductS
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
