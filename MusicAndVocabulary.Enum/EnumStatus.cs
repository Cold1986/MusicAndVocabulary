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
        /// <summary>
        /// 禁用
        /// </summary>
        [Description("禁用")]
        Disable = 0,

        /// <summary>
        /// 可用
        /// </summary>
        [Description("可以使用")]
        InUse = 1

    }
}
