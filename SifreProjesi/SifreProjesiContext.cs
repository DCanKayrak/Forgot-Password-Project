using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreProjesi
{
    public class SifreProjesiContext:DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}
