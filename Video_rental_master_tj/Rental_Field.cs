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
  public  class Rental_Field
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
        public int Rental_Insert(int Cust_Id,int Movie_Id,String IssueDate)
        {
            if (Cust_Id.ToString().Equals("") && Movie_Id.ToString().Equals("") && IssueDate.Equals(""))
            {
                MessageBox.Show("fill the required Column ");
                return 0;
            }
            else
            {
                String cmd = "Insert into Rental_Field(Cust_Id,Movie_Id,Issue_Date,Return_Date) values (" + Cust_Id+ "," + Movie_Id + ",'" + IssueDate + "','Issue')";
                Query(cmd);
                MessageBox.Show("Record is saved ");
                return 1;
            }
        }

        // pass the field to insert the record in the form 
        public int Rental_Delete(int Rental_Id)
        {
            if (Rental_Id == 0)
            {
                MessageBox.Show("first select the Rental Movie to Delete ");
                return 0;
            }
            else
            {
                String cmd = "Delete from  Rental_Field where Rental_Id=" + Rental_Id + "";
                Query(cmd);
                MessageBox.Show("Record is Removed ");
                return 1;
            }
        }


        // pass the field to insert the record in the form 
        public int Rental_Updte(int Rental_Id, int Cust_Id, int Movie_Id, String IssueDate,String ReturnDate)
        {
            if (Rental_Id == 0 && Cust_Id.ToString().Equals("") && Movie_Id.ToString().Equals("") && IssueDate.Equals(""))
            {
                MessageBox.Show("fill the required Column ");
                return 0;
            }
            else
            {
                DataTable tbl = new DataTable();
                tbl=Record("select * from Movie_Field where Movie_Id="+Movie_Id+"");
                int Old_Cost = Convert.ToInt32(tbl.Rows[0]["Cost"].ToString());

                DateTime new_date = DateTime.Now;



                //convert the old date from string to Date fromat
                DateTime prev_date = Convert.ToDateTime(IssueDate);


                //get the difference in the days fromat
                String Daysdiff = (new_date - prev_date).TotalDays.ToString();


                // calculate the round off value 
                Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));

                int Charges = Convert.ToInt32(DaysInterval) * Old_Cost;


                String cmd = "Update Rental_Field set Cust_Id=" + Cust_Id + ",Movie_Id=" + Movie_Id + ",Issue_Date='" + IssueDate + "', Return_Date='"+ReturnDate+ "' where Rental_Id=" + Rental_Id + "";
                Query(cmd);

                MessageBox.Show("Movie is Returned ");

                return Charges;
            }
        }

        //get the list of the record from the database table 
        public DataTable Rental_Record()
        {
            DataTable tbl = new DataTable();
            tbl = Record("select * from Rental_Field");
            return tbl;
        }

        //before issue an movie on rent first of all the verify the customer details 
        public int Customer_Record(int Cust_Id)
        {
            DataTable tbl = new DataTable();
            tbl = Record("select * from Rental_Field where Cust_Id="+Cust_Id+" and Return_Date='Issue'");
            int count = tbl.Rows.Count;
            return count;
        }

        //before issue an movie on rent first of all the verify the customer details 
        public int Movie_Record(int Movie_Id)
        {
            DataTable tbl = new DataTable();
            tbl = Record("select * from Rental_Field where Movie_Id=" + Movie_Id + " and Return_Date='Issue'");
            int count = tbl.Rows.Count;
            return count;
        }



    }
}
