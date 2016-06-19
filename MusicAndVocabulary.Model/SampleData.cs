using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Model
{
    //CreateDatabaseIfNotExists
    public class SampleData : DropCreateDatabaseIfModelChanges<MusicAndVocabularyEntities>
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
                new User {UserName="AdminCold",Email="735255078@qq.com",Password="admincold",UserGId=Guid.NewGuid().ToString("N"),Status=Enum.EnumStatus.InUse },
                new User {UserName="UserCold",Email="735255079@qq.com",Password="usercold",UserGId=Guid.NewGuid().ToString("N"),Status=Enum.EnumStatus.InUse },
                new User {UserName="GuestCold",Email="735255080@qq.com",Password="guestcold",UserGId=Guid.NewGuid().ToString("N"),Status=Enum.EnumStatus.InUse }
            };

            //给用户添加权限
            new List<User2Roles>
            {
                new User2Roles {User= user.Single(g=>g.UserName=="AdminCold"),Roles=roles.Single(r=>r.Role=="Admin" ) },
                new User2Roles {User= user.Single(g=>g.UserName=="UserCold"),Roles=roles.Single(r=>r.Role=="User" ) },
                new User2Roles {User= user.Single(g=>g.UserName=="GuestCold"),Roles=roles.Single(r=>r.Role=="Guest" ) },
            }.ForEach(a => context.User2Roles.Add(a));
        }
    }
}
