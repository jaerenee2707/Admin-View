using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1 {
    public partial class AdminView : System.Web.UI.Page
    {
        protected void SUBMIT_Click_addPer(object sender, EventArgs e)
        {
            string connString = "Server=medicaldatabase3380.mysql.database.azure.com;Database=medicalclinicdb2;Uid=dbadmin;Pwd=Medical123!;";
            MySqlConnection connection = new MySqlConnection(connString);

            connection.Open();

            try {
                if (DropDownList1.SelectedValue == "Doctor") {
                    string sql = "INSERT INTO doctor (Fname, Mname, Lname, Specialty, DOB, Work_email, Phone_num) VALUES (@fname, @Minitial, @lname, @specialty,  @dob, @email, @phone_num)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@fname", fname.Text);
                    command.Parameters.AddWithValue("@Minitial", mi.Text);
                    command.Parameters.AddWithValue("@lname", lname.Text);
                    command.Parameters.AddWithValue("@dob", dob.Text);
                    command.Parameters.AddWithValue("@specialty", specialty.Text);
                    command.Parameters.AddWithValue("@phone_num", phone_num.Text);
                    command.Parameters.AddWithValue("@email", email.Text);

                    command.ExecuteNonQuery();
                }
                if (DropDownList1.SelectedValue == "Nurse") {
                    string sql = "INSERT INTO nurse (Fname, Mname, Lname, Work_email, officeID, Phone_num, DOB) VALUES (@fname, @Minitial, @lname, @email, @office, @phone_num, @dob)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@fname", fname.Text);
                    command.Parameters.AddWithValue("@Minitial", mi.Text);
                    command.Parameters.AddWithValue("@lname", lname.Text);
                    command.Parameters.AddWithValue("@dob", dob.Text);
                    command.Parameters.AddWithValue("@specialty", specialty.Text);
                    command.Parameters.AddWithValue("@phone_num", phone_num.Text);
                    command.Parameters.AddWithValue("@email", email.Text);
                    command.Parameters.AddWithValue("@office", office.Text);

                    command.ExecuteNonQuery();
                }
                if (DropDownList1.SelectedValue == "Staff") {
                    string sql = "INSERT INTO staff (Fname, Lname, SRole, Work_email, officeID, Phone_num, DOB) VALUES (@fname, @lname, @role, @email, @office, @phone_num, @dob)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@fname", fname.Text);
                    command.Parameters.AddWithValue("@role", role.Text);
                    command.Parameters.AddWithValue("@lname", lname.Text);
                    command.Parameters.AddWithValue("@dob", dob.Text);
                    command.Parameters.AddWithValue("@phone_num", phone_num.Text);
                    command.Parameters.AddWithValue("@email", email.Text);
                    command.Parameters.AddWithValue("@office", office.Text);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //Response.Redirect("unsuccessful.aspx");
                Response.Write("Error: " + ex.Message + '\n');
            }

            connection.Close();
        }
        
        protected void ButtonClear_Click(object sender, EventArgs e){
            Address.Text.Clear();
        }
        protected void ButtonExit_Click(object sender, EventArgs e){
            Response.Redirect("AdminView.aspx?AdminID=");//doesn't have + adminId in url
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
