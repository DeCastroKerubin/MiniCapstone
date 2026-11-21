using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCapstone
{
    internal class DatabaseConnections
    {
        private IMongoClient client;
        private IMongoDatabase database;

        public IMongoCollection<BsonDocument> StaffCollection { get; private set; }

        public DatabaseConnections()
        {
            string connectionString = "mongodb+srv://Staff:staffstaff@lostandfoun.dxpwfue.mongodb.net/";

            client = new MongoClient(connectionString);
            database = client.GetDatabase("LostAndFound");
            StaffCollection = database.GetCollection<BsonDocument>("StaffLogin");
        }
    }
}
