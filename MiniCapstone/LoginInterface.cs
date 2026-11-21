using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MiniCapstone
{
    public partial class LoginInterface : Form
    {
        private DatabaseConnections dbConnection = new DatabaseConnections();
        public LoginInterface()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            var filter = Builders<BsonDocument>.Filter.And(Builders<BsonDocument>.Filter.Eq("Username", username),Builders<BsonDocument>.Filter.Eq("Password", password));
            var staff = dbConnection.StaffCollection.Find(filter).FirstOrDefault();

            if (staff != null)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
