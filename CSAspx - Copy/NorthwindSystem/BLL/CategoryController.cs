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
    public class CategoryController
    {
        //this method will return all records from the SQL table Category
        //This method will first create a transaction (=using) code block which uses the DAL Context class
        //the Context class has a DbSet<Category> property for referencing the SQL table
        //The property works with EntityFramework to retrieve the data

        public List<Category> Categories_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.ToList();
            }
        }

        //this method will return a specific record from the SQL Category table besed on the Primary Key
        public Category Categories_GetCategory(int categoryid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.Find(categoryid);
            }
        }

    }
}
