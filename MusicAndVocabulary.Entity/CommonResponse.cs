using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAndVocabulary.Entity
{
    /// <summary>
    /// 通用结果返回
    /// </summary>
    public class CommonResponse<T>
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Succeeded { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public T Messages { get; set; }
    }
}
