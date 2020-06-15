using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_master_tj
{
   public class Customer_Value
    {
        // object of the coonection class that is used to create a coonection between sqlconnection 
        SqlConnection conn;

        // local variable to pass the connection string 
        String conStr = "Data Source=DESKTOP-7U8UBCP\\SQLEXPRESS;Initial Catalog=Movie_Rental_Store;Integrated Security=True";

        // object of the command class that is used to create a coonection between sqlcommand 
        SqlCommand cmd;

        // object of the reader class that is used to create a coonection between sqlDataReader 
        SqlDataReader DReader;


        //this method is used to execute the command by pasing the query as a argument 
        public void Query(String query)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable Record(String qry)
        {
            DataTable tbl = new DataTable();

            conn = new SqlConnection(conStr);

            conn.Open();

            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }


        // pass the field to insert the record in the form 
        public int Customer_Insert(String Name , String Email, String Contact,String City) {
            if (Name.Equals("") && Email.Equals("") && Contact.Equals("") && City.Equals(""))
            {
                MessageBox.Show("fill the required Column ");
                return 0;
            }
            else {
                String cmd = "Insert into Customer_Field(Name,Email,Contact,City) values ('"+Name+"','"+Email+"','"+Contact+"','"+City+"')";
                Query(cmd);
                MessageBox.Show("Record is saved ");
                return 1;
            }
        }

        // pass the field to insert the record in the form 
        public int Customer_Delete(int Cust_Id)
        {
            if (Cust_Id==0)
            {
                MessageBox.Show("first select the Customer to Delete ");
                return 0;
            }
            else
            {
                String cmd = "Delete from  Customer_Field where Cust_Id="+Cust_Id+"";
                Query(cmd);
                MessageBox.Show("Record is Removed ");
                return 1;
            }
        }


        // pass the field to insert the record in the form 
        public int Customer_Updte(int Cust_Id, String Name, String Email, String Contact, String City)
        {
            if (Cust_Id == 0 && Name.Equals("") && Email.Equals("") && Contact.Equals("") && City.Equals(""))
            {
                MessageBox.Show("fill the required Column ");
                return 0;
            }
            else
            {
                String cmd = "Update  Customer_Field set Name='" + Name + "',Email='" + Email + "',Contact='" + Contact + "',City='" + City + "' where Cust_Id="+Cust_Id+"";
                Query(cmd);
                MessageBox.Show("Record is Updated ");
                return 1;
            }
        }

        //get the list of the record from the database table 
        public DataTable Customer_Record() {
            DataTable tbl = new DataTable();
            tbl = Record("select * from Customer_Field");
            return tbl;
        }



        public String Best_Customer()
        {
            DataTable tblData = new DataTable();
            tblData = Record("select * from Customer_Field");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = Record("select * from Rental_Field where Cust_Id=" + Convert.ToInt32(tblData.Rows[x]["Cust_Id"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            return Title;


        }



    }
}


