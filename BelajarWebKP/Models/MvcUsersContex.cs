using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BelajarWebKP.Models
{
    public class MvcUsersContex : DbContext
    {
        public MvcUsersContex (DbContextOptions<MvcUsersContex> options)
            : base(options)
        {
        }

        public DbSet<BelajarWebKP.Models.UsersModel> UsersModel { get; set; }
    }
}