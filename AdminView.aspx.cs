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
        protected void Page_Load(object sender, EventArgs e)
        {
            dob.Attributes.Add("placeholder", "yyyy-mm-dd");
            dob.Attributes.Add("type", "date");
            dob.Attributes.Add("onkeydown", "return false");
            welcomeHeader.InnerText = "Welcome, Administrator!";
        }

        protected void SUBMIT_Click_addPer(object sender, EventArgs e)
        {
            string connString = "Server=medicaldatabase3380.mysql.database.azure.com;Database=medicalclinicdb2;Uid=dbadmin;Pwd=Medical123!;";
            MySqlConnection connection = new MySqlConnection(connString);

            connection.Open();

            try {
                if (DropDownList1.SelectedValue == "Doctor") {
                    string sql = "INSERT INTO login (username, password, ID) VALUES (@username, @passwrd, @doctorID)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", username.Text);
                    command.Parameters.AddWithValue("@passwrd", password.Text);
                    command.Parameters.AddWithValue("@doctorID", id.Text);

                    command.ExecuteNonQuery();
                }
                if (DropDownList1.SelectedValue == "Nurse") {
                    string sql = "INSERT INTO login (username, password, ID) VALUES (@username, @passwrd, @nurseID)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", username.Text);
                    command.Parameters.AddWithValue("@passwrd", password.Text);
                    command.Parameters.AddWithValue("@nurseID", id.Text);
                    command.ExecuteNonQuery();
                }
                if (DropDownList1.SelectedValue == "Admin") {
                    string sql = "INSERT INTO login (username, password, ID) VALUES (@username, @passwrd, @adminId)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", username.Text);
                    command.Parameters.AddWithValue("@passwrd", password.Text);
                    command.Parameters.AddWithValue("@adminID", id.Text);
                    command.ExecuteNonQuery();
                }
                if (DropDownList1.SelectedValue == "Patient") {
                    string sql = "INSERT INTO login (username, password, ID) VALUES (@username, @passwrd, @patientId)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@username", username.Text);
                    command.Parameters.AddWithValue("@passwrd", password.Text);
                    command.Parameters.AddWithValue("@patientId", id.Text);
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
            username.Text.Clear();
            password.Text.Clear();
            id.Text.Clear();
        }
        protected void ButtonExit_Click(object sender, EventArgs e){
            Response.Redirect("AdminView.aspx?AdminID=");//doesn't have + adminId in url
        }
    }
}
