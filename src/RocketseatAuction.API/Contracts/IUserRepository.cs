using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IUserRepository
{
    bool ExistsUserWithEmail(string email);
    User GetUserByEmail(string email);
}
