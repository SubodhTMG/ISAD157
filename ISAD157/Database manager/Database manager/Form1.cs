using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database_manager
{
    public partial class Form1 : Form
    {
        int IndexRow;
        public Form1()
        {
            InitializeComponent();
            
        }

        #region

        private void ComboBoxDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxDB.SelectedIndex == 0)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";



                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM isad157_ssyantantamang.users";


                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand(query, connection);


                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserDataTable = new DataTable();
                    sqlDA.Fill(UserDataTable);

                    dataGridUser.DataSource = UserDataTable;

                }
            }
            else if (ComboBoxDB.SelectedIndex == 1)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";



                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM isad157_ssyantantamang.friendship";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable FriendshipDataTable = new DataTable();
                    sqlDA.Fill(FriendshipDataTable);


                    dataGridFriendship.DataSource = FriendshipDataTable;
                }
            }
            else if (ComboBoxDB.SelectedIndex == 2)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";



                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM isad157_ssyantantamang.friendslist";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable FriendlistDataTable = new DataTable();
                    sqlDA.Fill(FriendlistDataTable);


                    dataGridFriendList.DataSource = FriendlistDataTable;
                }
            }
            else if (ComboBoxDB.SelectedIndex == 3)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";



                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM isad157_ssyantantamang.messages";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable MessagesDataTable = new DataTable();
                    sqlDA.Fill(MessagesDataTable);


                    dataGridMessages.DataSource = MessagesDataTable;
                }
            }
            else if (ComboBoxDB.SelectedIndex == 4)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";



                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM isad157_ssyantantamang.universities";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UniversitiesDataTable = new DataTable();
                    sqlDA.Fill(UniversitiesDataTable);


                    dataGridUniversities.DataSource = UniversitiesDataTable;
                }
            }
            else if (ComboBoxDB.SelectedIndex == 5)
            {


                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";



                using (MySqlConnection connection =
                    new MySqlConnection(connectionString))
                {

                    string query = "SELECT * FROM isad157_ssyantantamang.workplace";


                    connection.Open();


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable WorkplaceDataTable = new DataTable();
                    sqlDA.Fill(WorkplaceDataTable);


                    dataGridWorkplace.DataSource = WorkplaceDataTable;
                }
            } // End of else...
            

            
        }
#endregion


        private void CreateNewUser()
        {
            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";
            try
            {
                //This is going to create a new user into the database
                string CreateUserQuery = "insert isad157_SSyantanTamang.users set FirstName = '" + this.textFirstName.Text +
                    "',LastName='" + this.textLastName.Text + "',Gender='" + this.textGender.Text +
                    "',Hometown='" + this.textHometown.Text + "',City='" + this.textCity.Text +"';";

                //Creates a connection between our Windows form and our Database
                MySqlConnection MyDBConnection = new MySqlConnection(connectionString);
                MySqlCommand sqlcmd = new MySqlCommand(CreateUserQuery, MyDBConnection);
                MySqlDataReader QueryReader;

                //Opens the connection to our database
                MyDBConnection.Open();
                QueryReader = sqlcmd.ExecuteReader();

                //Displays a message informing the User that the details were successfully changed
                MessageBox.Show("A new User has now been added, please refresh!");
                while (QueryReader.Read())
                {
                }
                //Close Database Connection
                MyDBConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserUpdate()
        {
            string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";
            try
            {
                //This is an Update query which which will replace the text from the window form to the database
                string UserUpdateQuery = "update isad157_SSyantanTamang.users set UserID='" + this.textUserID.Text + "' ,FirstName = '" + this.textFirstName.Text +
                    "',LastName='" + this.textLastName.Text + "',Gender='" + this.textGender.Text +
                    "',Hometown='" + this.textHometown.Text + "',City='" + this.textCity.Text + "' where UserID='" + this.textUserID.Text + "';";

                //Creates a connection between our Windows form and our Database
                MySqlConnection MyConnection = new MySqlConnection(connectionString);
                MySqlCommand sqlcmd = new MySqlCommand(UserUpdateQuery, MyConnection);
                MySqlDataReader QueryReader;

                //Opens the connection to our database
                MyConnection.Open();
                QueryReader = sqlcmd.ExecuteReader();

                //Displays a message informing the User that the details were successfully changed
                MessageBox.Show("Details have now been updated, please refresh!");
                while (QueryReader.Read())
                {
                }
                //Close Database Connection
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateNewUser();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserUpdate();
        }

        private void dataGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexRow = e.RowIndex;

            //Selected row will be displayed on the textboxes 
            if (ComboBoxDB.SelectedIndex == 0)
            {
                if (IndexRow >= 0)
                {
                    //populate the textbox
                    DataGridViewRow row = this.dataGridUser.Rows[IndexRow];

                    
                    textUserID.Text = row.Cells["UserID"].Value.ToString();
                    textFirstName.Text = row.Cells["FirstName"].Value.ToString();
                    textLastName.Text = row.Cells["LastName"].Value.ToString();
                    textGender.Text = row.Cells["Gender"].Value.ToString();
                    textHometown.Text = row.Cells["Hometown"].Value.ToString();
                    textCity.Text = row.Cells["City"].Value.ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}

