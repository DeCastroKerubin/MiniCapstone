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
        private IMongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<BsonDocument> staffCollection;

        private void ConnectToDatabase()
        {
            string connectionString = "mongodb+srv://Staff:staffstaff@lostandfoun.dxpwfue.mongodb.net/";

            client = new MongoClient(connectionString);
            database = client.GetDatabase("LostAndFound");
            staffCollection = database.GetCollection<BsonDocument>("StaffLogin");
        }
        public LoginInterface()
        {
            InitializeComponent();
            ConnectToDatabase();
            database.RunCommand<BsonDocument>(new BsonDocument("ping", 1)
);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            var filter = Builders<BsonDocument>.Filter.And(Builders<BsonDocument>.Filter.Eq("Username", username),Builders<BsonDocument>.Filter.Eq("Password", password));
            var staff = staffCollection.Find(filter).FirstOrDefault();

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
    }
}
