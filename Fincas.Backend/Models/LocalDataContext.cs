namespace Fincas.Backend.Models
{
    using Fincas.Domain.Models;
    using Microsoft.EntityFrameworkCore;

    public class LocalDataContext : DataContext
    {
        public LocalDataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
