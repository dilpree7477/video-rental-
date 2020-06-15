using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_master_tj
{
    public partial class Form1 : Form
    {
        int optn = 0;

        String Rental_Id = "";
        public Form1()
        {
            InitializeComponent();

        }

        private void csInfo_Add_Click(object sender, EventArgs e)
        {
            //creating the local instance of the customer class to pass the value to store and verify 
            Customer_Value instance = new Customer_Value();
            if (instance.Customer_Insert(csInfo_Name.Text, csInfo_email.Text, csInfo_Contact.Text, csInfo_City.Text) == 1)
            {
                csInfo_City.Text = "";
                csInfo_Contact.Text = "";
                csInfo_email.Text = "";
                csInfo_Name.Text = "";

                DataTable tbl = new DataTable();
                tbl = instance.Customer_Record();
                tjGridview.DataSource = tbl;

            }
            else
            {
                csInfo_City.Text = "";
                csInfo_Contact.Text = "";
                csInfo_email.Text = "";
                csInfo_Name.Text = "";
            }

        }

        private void csInfo_delete_Click(object sender, EventArgs e)
        {
            //to delete the customer we must have to check weather he has issued a movie or not 
            Customer_Value instance = new Customer_Value();

            DataTable tbl = new DataTable();
            tbl = instance.Record("select * from Rental_Field where Cust_Id=" + Convert.ToInt32(rentalInfo_csID.Text.ToString()) + " &&  Return_Date='Issue'");
            if (tbl.Rows.Count == 0)
            {
                if (instance.Customer_Delete(Convert.ToInt32(rentalInfo_csID.Text.ToString())) == 1)
                {
                    csInfo_City.Text = "";
                    csInfo_Contact.Text = "";
                    csInfo_email.Text = "";
                    csInfo_Name.Text = "";
                    rentalInfo_csID.Text = "";
                }
            }
            else
            {
                MessageBox.Show("First Return the Movie then you can ");
            }
        }

        private void csInfo_update_Click(object sender, EventArgs e)
        {
            //to update the info of the cutomer like Name or contact weather you want 
            Customer_Value instance = new Customer_Value();
            if (instance.Customer_Updte(Convert.ToInt32(rentalInfo_csID.Text.ToString()), csInfo_Name.Text, csInfo_email.Text, csInfo_Contact.Text, csInfo_City.Text) == 1)
            {
                csInfo_City.Text = "";
                csInfo_Contact.Text = "";
                csInfo_email.Text = "";
                csInfo_Name.Text = "";
                rentalInfo_csID.Text = "";
            }
        }

        private void viInfo_add_Click(object sender, EventArgs e)
        {
            //creating the local object of the movie class to pass the value by calling the refernece of the variable 
            Movie_Field instance = new Movie_Field();
            if (instance.Movie_Insert(viInfo_Name.Text, viInfo_points.Text, viInfo_year.Text, viInfo_cost.Text, viInfo_copies.Text, viInfo_Plot.Text, viInfo_Genre.Text) == 1)
            {

                viInfo_Genre.Text = "";
                viInfo_Plot.Text = "";
                viInfo_copies.Text = "";
                viInfo_cost.Text = "";
                viInfo_year.Text = "";
                viInfo_points.Text = "";
                viInfo_Name.Text = "";

                DataTable tbl = new DataTable();
                tbl = instance.Movie_Record();
                tjGridview.DataSource = tbl;

            }
        }

        private void viInfo_delete_Click(object sender, EventArgs e)
        {
            //creating the local object of the movie class to pass the value by calling the refernece of the variable 
            Movie_Field instance = new Movie_Field();
            DataTable tbl = new DataTable();
            tbl = instance.Record("select * from Rental_Field where Movie_Id=" + Convert.ToInt32(videorental_ID.Text) + " && Return_Date='Issue'");
            if (tbl.Rows.Count == 0)
            {
                if (instance.Movie_Delete(Convert.ToInt32(videorental_ID.Text)) == 1)
                {

                    viInfo_Genre.Text = "";
                    viInfo_Plot.Text = "";
                    viInfo_copies.Text = "";
                    viInfo_cost.Text = "";
                    viInfo_year.Text = "";
                    viInfo_points.Text = "";
                    viInfo_Name.Text = "";
                    videorental_ID.Text = "";

                }
            }
            else
            {
                MessageBox.Show("this Movie is already issued on rent ");
            }
        }

        private void viInfo_update_Click(object sender, EventArgs e)
        {
            //creating the local object of the movie class to pass the value by calling the refernece of the variable 
            Movie_Field instance = new Movie_Field();
            if (instance.Movie_Updte(Convert.ToInt32(videorental_ID.Text), viInfo_Name.Text, viInfo_points.Text, viInfo_year.Text, viInfo_cost.Text, viInfo_copies.Text, viInfo_Plot.Text, viInfo_Genre.Text) == 1)
            {
                viInfo_Genre.Text = "";
                viInfo_Plot.Text = "";
                viInfo_copies.Text = "";
                viInfo_cost.Text = "";
                viInfo_year.Text = "";
                viInfo_points.Text = "";
                viInfo_Name.Text = "";
                videorental_ID.Text = "";
            }
        }

        private void issue_movie_info_Click(object sender, EventArgs e)
        {
            Rental_Field instance = new Rental_Field();
            if (instance.Customer_Record(Convert.ToInt32(rentalInfo_csID.Text.ToString())) < 2)
            {
                DataTable tbl = new DataTable();
                tbl = instance.Record("select * from Movie_Field where Movie_Id=" + Convert.ToInt32(videorental_ID.Text.ToString()) + "");
                int copies = Convert.ToInt32(tbl.Rows[0]["Copies"].ToString());

                if (instance.Movie_Record(Convert.ToInt32(videorental_ID.Text.ToString())) < copies)
                {
                    instance.Rental_Insert(Convert.ToInt32(rentalInfo_csID.Text.ToString()), Convert.ToInt32(videorental_ID.Text.ToString()), IssueDtp.Text);

                    DataTable tbl1 = new DataTable();
                    tbl1 = instance.Rental_Record();
                    tjGridview.DataSource = tbl1;

                    viInfo_Genre.Text = "";
                    viInfo_Plot.Text = "";
                    viInfo_copies.Text = "";
                    viInfo_cost.Text = "";
                    viInfo_year.Text = "";
                    viInfo_points.Text = "";
                    viInfo_Name.Text = "";
                    videorental_ID.Text = "";

                    csInfo_City.Text = "";
                    csInfo_Contact.Text = "";
                    csInfo_email.Text = "";
                    csInfo_Name.Text = "";
                    rentalInfo_csID.Text = "";


                }
                else
                {
                    MessageBox.Show("All the Movies Copies all already Issued ");
                }

            }
            else
            {
                MessageBox.Show("you already issued two movie so can't issue more ");
            }

        }

        private void delete_movie_info_Click(object sender, EventArgs e)
        {
            Rental_Field instance = new Rental_Field();
            if (Rental_Id.Equals(""))
            {
                MessageBox.Show("Select Rental Movie To delete");
            }
            else
            {
                if (instance.Rental_Delete(Convert.ToInt32(Rental_Id)) == 1)
                {
                    videorental_ID.Text = "";
                    rentalInfo_csID.Text = "";

                }
            }
        }

        private void return_movie_info_Click(object sender, EventArgs e)
        {
            Rental_Field instance = new Rental_Field();
            if (Rental_Id.Equals(""))
            {
                MessageBox.Show("Select Rental Movie To Return ");
            }
            else
            {
                int Charges = instance.Rental_Updte(Convert.ToInt32(Rental_Id), Convert.ToInt32(rentalInfo_csID.Text.ToString()), Convert.ToInt32(videorental_ID.Text.ToString()), IssueDtp.Text, ReturnDtp.Text);
                if (Charges>0)
                {
                    MessageBox.Show("Your Total Bill is: " +Charges);
                }

            }
        }

        private void viInfo_year_TextChanged(object sender, EventArgs e)
        {

            try {

                //we have use the concept of the Textchanged event to generate the charges of the cost 
                //dislay the cost of the price of the video after adding the year of the video
                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(viInfo_year.Text.ToString());
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;

                }
                viInfo_cost.Text = "" + cost;
            }
           
            catch (Exception ex) {

            }
            
        }

        private void csRecord_Click(object sender, EventArgs e)
        {
            optn = 1;

            Customer_Value instance = new Customer_Value();
            DataTable tbl = new DataTable();
            tbl = instance.Customer_Record();
            tjGridview.DataSource = tbl;
        }

        private void vsRecord_Click(object sender, EventArgs e)
        {
            optn = 2;
            Movie_Field instance = new Movie_Field();
            DataTable tbl = new DataTable();
            tbl = instance.Movie_Record();
            tjGridview.DataSource = tbl;

        }

        private void renRecord_Click(object sender, EventArgs e)
        {
            optn = 3;

            Rental_Field instance = new Rental_Field();
            DataTable tbl = new DataTable();
            tbl = instance.Rental_Record();
            tjGridview.DataSource = tbl;

        }

        private void tjGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (optn==1) {
                rentalInfo_csID.Text= tjGridview.CurrentRow.Cells[0].Value.ToString();
                csInfo_Name.Text = tjGridview.CurrentRow.Cells[1].Value.ToString();
                csInfo_email.Text = tjGridview.CurrentRow.Cells[2].Value.ToString();
                csInfo_Contact.Text = tjGridview.CurrentRow.Cells[3].Value.ToString();
                csInfo_City.Text = tjGridview.CurrentRow.Cells[4].Value.ToString();

            }

            if (optn==2) {
                videorental_ID.Text=tjGridview.CurrentRow.Cells[0].Value.ToString();
                viInfo_Name.Text=tjGridview.CurrentRow.Cells[1].Value.ToString();
                viInfo_points.Text= tjGridview.CurrentRow.Cells[2].Value.ToString();
                viInfo_year.Text=tjGridview.CurrentRow.Cells[3].Value.ToString();
                viInfo_cost.Text= tjGridview.CurrentRow.Cells[4].Value.ToString();
                viInfo_copies.Text= tjGridview.CurrentRow.Cells[5].Value.ToString();
                viInfo_Plot.Text= tjGridview.CurrentRow.Cells[6].Value.ToString();
                viInfo_Genre.Text= tjGridview.CurrentRow.Cells[7].Value.ToString();
            }

            if (optn==3) {
                Rental_Id = tjGridview.CurrentRow.Cells[0].Value.ToString();
                rentalInfo_csID.Text = tjGridview.CurrentRow.Cells[1].Value.ToString();
                videorental_ID.Text = tjGridview.CurrentRow.Cells[2].Value.ToString();
                IssueDtp.Text = tjGridview.CurrentRow.Cells[3].Value.ToString();
            }

            optn = 0;
        }

        private void tjGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tjGridview_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void csBest_Click(object sender, EventArgs e)
        {
            Customer_Value instance = new Customer_Value();
            MessageBox.Show("Best Customer of the Store :" + instance.Best_Customer());

        }

        private void viBest_Click(object sender, EventArgs e)
        {
            Movie_Field instance = new Movie_Field();
            MessageBox.Show("Best Movie of the Store :" + instance.Best_Movie());
        }
    }
}