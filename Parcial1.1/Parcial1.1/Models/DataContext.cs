using System.Data.Entity;

namespace Parcial1._1.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Parcial1._1.Models.Product> Products { get; set; }
    }
}