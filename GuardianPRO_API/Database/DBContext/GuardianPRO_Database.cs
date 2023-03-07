using Microsoft.EntityFrameworkCore;

namespace GuardianPRO_API.Database.DBContext
{
    public class GuardianPRO_Database : DbContext
    {
        public GuardianPRO_Database(DbContextOptions options)
            :base(options)
        {
        }
    }
}
