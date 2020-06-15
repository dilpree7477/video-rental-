using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_rental_master_tj;

namespace Video_rental_master_tjTests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer_Value obj = new Customer_Value();
            DataTable tbl = new DataTable();
            tbl = obj.Customer_Record();
            if (tbl.Rows.Count > 0) {
                Assert.IsTrue(true);
            } else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void VideoTestMethod1()
        {
            Movie_Field obj = new Movie_Field();
            DataTable tbl = new DataTable();
            tbl = obj.Movie_Record();
            if (tbl.Rows.Count > 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CustomerTestMethod1()
        {
            Customer_Value obj = new Customer_Value();
           
           
            if (obj.Customer_Insert("A","a@gmail.com","12","nz")==1)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }


    }
}
