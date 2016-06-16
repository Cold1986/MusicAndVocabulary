using MusicAndVocabulary.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MusicAndVocabulary.Model
{
    [Bind(Exclude = "RoleId")]
    public class Roles
    {
        [ScaffoldColumn(true)]
        public int RoleId { get; set; }

        [DisplayName("权限")]
        public string Role { get; set; }

        [DisplayName("状态")]
        public EnumStatus Status { get; set; }
    }
}
