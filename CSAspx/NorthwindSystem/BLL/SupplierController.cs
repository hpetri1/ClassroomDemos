using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
using Northwind.Data.Entities;
using NorthwindSystem.DAL;
#endregion

namespace NorthwindSystem.BLL
{
    public class SupplierController
    {
        //this method will return all records from the SQL table Products
        //This method will first create a transaction (=using) code block which uses the DAL Context class
        //the Context class has a DbSet<Product> property for referencing the SQL table
        //The property works with EntityFramework to retrieve the data

        public List<Supplier> Suppliers_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.ToList();
            }
        }

        //this method will return a specific record from the SQL Products table besed on the Primary Key
        public Supplier Suppliers_GetSupplier(int supplierid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.Find(supplierid);
            }
        }

    }
}

