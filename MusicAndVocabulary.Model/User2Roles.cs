using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Model
{
    public class User2Roles
    {
        [Key]
        public int User2RolesId { get; set; }

        public Roles Roles { get; set; }
        public User User { get; set; }

    }
}
