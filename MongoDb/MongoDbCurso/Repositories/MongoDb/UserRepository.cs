using MongoDB.Bson;
using MongoDB.Driver;

using MongoDbCurso.Interfaces;
using MongoDbCurso.Repositories.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCurso.Repositories.MongoDb
{
    public class UserRepository : IUsersRepository
    {
        private static readonly string collectionString = "TestCollection";
        private readonly IMongoDatabase _mongoDatabase;
        private readonly IMongoCollection<User> _collection;

        public UserRepository(IMongoDatabase mongoDatabase)
        {
            _mongoDatabase = mongoDatabase;
            _collection = _mongoDatabase.GetCollection<User>(collectionString);
        }

        public User Create(User obj)
        {
            obj.Id = obj.Id ?? ObjectId.GenerateNewId().ToString();
            _collection.InsertOne(obj);
            return obj;
        }

        public bool Delete(string id)
        {
            return _collection.DeleteOne(x => x.Id == id).DeletedCount > 0;
        }

        public User Get(string id)          
        {
            return _collection.Find(x => x.Id == id).FirstOrDefault();
        }

        //public List<User> GetUsersPerRole(string role)
        //{
        //    return _collection.Find(x => x.Role == role).ToList();
        //}

        public bool Update(User obj)
        {
            return _collection.ReplaceOne(x => x.Id == obj.Id, obj).MatchedCount > 0;
        }
    }
}
