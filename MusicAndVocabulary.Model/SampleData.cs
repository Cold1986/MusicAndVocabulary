using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Model
{
    public class SampleData : CreateDatabaseIfNotExists<MusicAndVocabularyEntities>
    {
        protected override void Seed(MusicAndVocabularyEntities context)
        {
            var roles = new List<Roles>
            {
                new Roles {Role="Admin",RoleId=1,Status=Enum.EnumStatus.InUse },
                new Roles {Role="User",RoleId=2,Status=Enum.EnumStatus.InUse },
                new Roles {Role="Guest",RoleId=3,Status=Enum.EnumStatus.Disable }
            };
        }
    }
}
