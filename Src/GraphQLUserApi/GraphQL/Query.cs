using GraphQLUserApi.Data;
using GraphQLUserApi.Models;

namespace GraphQLUserApi.GraphQL;

public class Query
{
    public IQueryable<User> GetUsers([Service] AppDbContext context) => context.Users;

    public User? GetUser(int id, [Service] AppDbContext context) =>
        context.Users.FirstOrDefault(u => u.Id == id);
}
