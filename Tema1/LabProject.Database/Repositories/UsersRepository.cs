
using Tema1.Database.Entities;
using Tema1.Database.Context;

namespace Tema1.Database.Repositories
{
    public class UsersRepository:BaseRepository
    {
        public UsersRepository(Tema1DBContext labProjectDbContext) : base(labProjectDbContext) {}

        public void Add(User user)
        {
            labProjectDbContext.Users.Add(user);
            labProjectDbContext.SaveChanges();
        }

        public User GetByEmail(string email)
        {
            var result = labProjectDbContext.Users

                .Where(e => e.Email == email)
                .Where(e => e.DateDeleted == null)

                .FirstOrDefault();

            return result;
        }
    }
}
