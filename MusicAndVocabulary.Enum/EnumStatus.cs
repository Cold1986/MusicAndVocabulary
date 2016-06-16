using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Enum
{
    public enum EnumStatus
    {
        [Description("禁用")]
        Disable = 0,

        [Description("可以使用")]
        InUse = 1

    }
}
