using MongoDB.Driver;

using MongoDbCurso.Interfaces;
using MongoDbCurso.Repositories.Models;
using MongoDbCurso.Repositories.MongoDb;

using System;

namespace MongoDbCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            var mongoURL = new MongoUrl("mongodb+srv://LegalCheckUser:Pa%24%24w0rd@legalcheckdbcluster.yle6r.azure.mongodb.net/TestDatabase");
            IMongoDatabase mongoDatabase = new MongoClient(mongoURL).GetDatabase(mongoURL.DatabaseName);

            IUsersRepository usersRepository = new UserRepository(mongoDatabase);


            var user = usersRepository.Get("615f714857149c32b822ff50");
        }
    }
}
