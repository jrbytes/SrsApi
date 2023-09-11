using Microsoft.EntityFrameworkCore;
using SrsApi.Models;

namespace SrsApi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
    }
}