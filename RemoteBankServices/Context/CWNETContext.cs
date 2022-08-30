using Microsoft.EntityFrameworkCore;

namespace RemoteBankServices.Context
{
    public class CWNETContext : DbContext
    {
        public CWNETContext(DbContextOptions<CWNETContext> options) : base(options)
        {
        }
    }
}
