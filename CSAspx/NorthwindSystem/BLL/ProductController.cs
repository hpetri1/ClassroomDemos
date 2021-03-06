﻿using System;
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
    //this is the public interface class that will handle
    // web page service requests for data to the Product sql table
    //Methods in this class can interact with the internal DAL Context class
    public class ProductController
    {
        //this method will return all records from the SQL table Products
        //This method will first create a transaction (=using) code block which uses the DAL Context class
        //the Context class has a DbSet<Product> property for referencing the SQL table
        //The property works with EntityFramework to retrieve the data

        public List<Product> Products_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

        //this method will return a specific record from the SQL Products table besed on the Primary Key
        public Product Products_GetProduct(int productid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.Find(productid);
            }
        }

        //July 23, 2018
        //this method will add a new product to the SQL product table
        //this method will do the Add via EntityFramework
        //optionally, one can pass back the new IDENTITY value from the successful add
        public int Products_Add(Product newproduct)
        {
            //start the Insert transaction
            using (var context = new NorthwindContext())
            {
                //staging:
                //stage the new record to the DbSet<T> for the object instance
                //at this time, the record IS NOT physically on the database
                context.Products.Add(newproduct);

                //commit the record to the Database
                //any entity validation is done at this time
                //if this statement is NOT executed, the insert is NOT completed (Rollback)
                //if this statement is executed BUT FAILS for some reson, the insert is NOT completed (Rollback)
                //if this statement is executed AND is successful, then the insert has been physically placed
                //  the record on the database. At this time you can retrieve the new IDENTITY value
                context.SaveChanges();

                //after the success of the SaveChanges() you can access your instance for the new IDENTITY value
                return newproduct.ProductID; // this line is optional, don't have to return it if I don't want to => public int Products_Add(Product newproduct)
                                             // would be: public void Products_Add(Product newproduct)
            }
        }

        //this method updates the database
        //this method returns the number of records affected on the database
        public int Products_Update(Product item)
        {
            //start transaction
            using (var context = new NorthwindContext())
            {
                //stage
                context.Entry(item).State = System.Data.Entity.EntityState.Modified;

                //commit
                return context.SaveChanges();
            }
        }

        //this method deletes a record from the database
        //   or 
        //this method logically flags a record to be deemed deleted from the database
        //this method returns the number of records affected on the database
        public int Products_Delete(int productid)
        {
            //start transaction
            using (var context = new NorthwindContext())
            {
                ////PHYSICAL DELETE
                //var existing = context.Products.Find(productid);
                ////stage
                //context.Products.Remove(existing);
                ////commit
                //return context.SaveChanges();

                //LOGICAL DELETE (is really an Update)
                var existing = context.Products.Find(productid);
                //alter the data value on the record that will logically deem the record deleted
                //You should NOT rely on the user to do this alternation on the web form
                existing.Discontinued = true;
                //stage
                context.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                //commmit
                return context.SaveChanges();
            }
        }

    }
}
