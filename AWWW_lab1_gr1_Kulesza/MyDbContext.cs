using Microsoft.EntityFrameworkCore;
using AWWW_lab1_gr1_Kulesza;

namespace AWWW_lab1_gr1_Kulesza
{
    public class MyDbContext: DbContext
    {
        public virtual DbSet<Article>? Articles { get; set; }
        public virtual DbSet<Author>? Authors { get; set; }
    }
}
