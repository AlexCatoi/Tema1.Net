using Tema1.Database.Context;

namespace Tema1.Database.Repositories
{
    public class BaseRepository
    {
        protected Tema1DBContext labProjectDbContext { get; set; }

        public BaseRepository(Tema1DBContext labProjectDbContext)
        {
            this.labProjectDbContext = labProjectDbContext;
        }

        public void SaveChanges()
        {
            labProjectDbContext.SaveChanges();
        }
    }
}
