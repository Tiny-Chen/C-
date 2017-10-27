using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12序列化
{
    /// <summary>
    /// 标记该类可以序列化
    /// </summary>
    [Serializable]
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
