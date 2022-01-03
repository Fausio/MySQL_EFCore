using Microsoft.EntityFrameworkCore;

namespace MVC_MySQL_EFCore
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options) 
        {

        }
    }
}
