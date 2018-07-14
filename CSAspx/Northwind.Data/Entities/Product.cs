using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema; //added this for the [Table()]
using System.ComponentModel.DataAnnotations;

#endregion


namespace Northwind.Data.Entities
{
    //the Table annotation points to the table in the SQL DB that this class defines
    [Table("Products")]
    public class Product
    {
        //create a property for each attribute on the SQL table
        //use C# datatypes for the SQL attributes
        //Rules:
        // a) If you use the attribute name as your property name, the order of properties is not important
        // b) If you do NOT use the attribute name as your property name, the order of properties must match the order of attributes
        // c) Foreign Keys do NOT need an annotation if the property name is the same as the attribute name
        // d) Primary Keys are by default treated as IDENTITY. If your PK is not an IDENTITY then you must add 
        //    .DataGenerated(DataGeneratedOption.xxxx) annotation parameter
        // e) Primary key properties are best defaulted to end in ID (Id)
        // f) Compound PK are described using the Column(Order=n) annotation parameter; where n is 1, 2, 3, etc. (physical order of SQL attributes)

        [Key] // or [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; } // foreign key, ? does mean nullable (null)
        public int? CategoryID { get; set; } // foreign key
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        // sometimes you will want another property in your class that will return a not attribute value to the user
        // example: Name, which could be created by the first and last name properties
        // to create these non mapped (non existing SQL attributes) properties, use the annotation [NotMapped]

        [NotMapped]
        public string ProductIDName
        {
            get
            {
                return ProductName + " (" + ProductID.ToString() + ")";
            }
        }
    }
}
