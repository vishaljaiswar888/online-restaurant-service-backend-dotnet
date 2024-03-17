using AdsRemedy.Models;
using Microsoft.EntityFrameworkCore;

namespace AdsRemedy.DataLayer
{
    public class DBCreateOrder : DbContext
    {
        public DBCreateOrder(DbContextOptions<DBCreateOrder> options) : base(options)
        { 

        }
        public DbSet<CreateOrder> CreateOrders { get; set; }
    }
}
