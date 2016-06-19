using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Model
{
    public class MusicAndVocabularyEntities: DbContext
    {
        public DbSet<Roles> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<User2Roles> User2Roles { get; set; }
    }
}
