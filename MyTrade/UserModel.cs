using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyTrade
{
    internal class UserModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string Prename { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
    }
}
