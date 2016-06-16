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
            //权限表
            var roles = new List<Roles>
            {
                new Roles {Role="Admin",Status=Enum.EnumStatus.InUse },
                new Roles {Role="User",Status=Enum.EnumStatus.InUse },
                new Roles {Role="Guest",Status=Enum.EnumStatus.Disable }
            };

            //初始用户表
            var user = new List<User>
            {
                new User {UserName="AdminCold",Email="735255078@qq.com",Password="admincold",UserGId=Guid.NewGuid() }
            };

            //给用户添加权限
            var user2Roles = new List<User2Roles>
            {
                new User2Roles {User= user.Single(g=>g.UserName=="AdminCold"),Roles=roles.Single(r=>r.Role=="Admin" ) }
            };
        }
    }
}
