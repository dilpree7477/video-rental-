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
   public class Movie_Field
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
        public int Movie_Insert(String Name,String Points,String Year,String Cost, String Copies,String Plot,String Genre)
        {
            if (Name.Equals("") && Points.Equals("") && Plot.Equals("") && Genre.Equals("") && Year.Equals("") && Cost.Equals("") && Copies.Equals(""))
            {
                MessageBox.Show("fill the required Column ");
                return 0;
            }
            else
            {
                String cmd = "Insert into Movie_Field(Name,Points,Year,Cost,Copies,Plot,Genre) values ('" + Name + "','" + Points + "','" + Year + "','" + Cost+ "','"+Copies+"','"+Plot+"','"+Genre+"')";
                Query(cmd);
                MessageBox.Show("Record is saved ");
                return 1;
            }
        }

        // pass the field to insert the record in the form 
        public int Movie_Delete(int Movie_Id)
        {
            if (Movie_Id == 0)
            {
                MessageBox.Show("first select the Movie to Delete ");
                return 0;
            }
            else
            {
                String cmd = "Delete from  Movie_Field where Movie_Id=" + Movie_Id + "";
                Query(cmd);
                MessageBox.Show("Record is Removed ");
                return 1;
            }
        }


        // pass the field to insert the record in the form 
        public int Movie_Updte(int Movie_Id, String Name, String Points, String Year, String Cost, String Copies, String Plot, String Genre)
        {
            if (Movie_Id == 0 && Name.Equals("") && Points.Equals("") && Plot.Equals("") && Genre.Equals("") && Year.Equals("") && Cost.Equals("") && Copies.Equals(""))
            {
                MessageBox.Show("fill the required Column ");
                return 0;
            }
            else
            {
                String cmd = "Update Movie_Field set Name='" + Name + "',Points='" + Points + "',Year='" + Year + "',Cost='" + Cost + "',Copies='" + Copies + "',Plot='" + Plot + "',Genre='" + Genre + "' where Movie_Id="+Movie_Id+"";
                Query(cmd);
                MessageBox.Show("Record is Updated ");
                return 1;
            }
        }

        //get the list of the record from the database table 
        public DataTable Movie_Record()
        {
            DataTable tbl = new DataTable();
            tbl = Record("select * from Movie_Field");
            return tbl;
        }



        public String Best_Movie() {
            DataTable tblData = new DataTable();
            tblData =Record("select * from Movie_Field");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 =Record("select * from Rental_Field where Movie_Id=" + Convert.ToInt32(tblData.Rows[x]["Movie_Id"].ToString()) + "");

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
