using MongoDbCurso.Repositories.Models;

using System.Collections.Generic;

namespace MongoDbCurso.Interfaces
{
    public interface IUsersRepository: IDatabaseObject<User>
    {
    }
}
