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
            welcomeHeader.InnerText = "Welcome, Administrator!";
        }
        protected void SUBMIT_Click_RemOff(object sender, EventArgs e)
        {
            string connString = "Server=medicaldatabase3380.mysql.database.azure.com;Database=medicalclinicdb;Uid=dbadmin;Pwd=Medical123!;";
            MySqlConnection connection = new MySqlConnection(connString);

            connection.Open();

            try {
                //  remove a office
                string sql = "DELETE FROM office WHERE officeAddress = @address";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@address", address.Text);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
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
