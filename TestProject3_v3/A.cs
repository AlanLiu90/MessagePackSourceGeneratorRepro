using MessagePack;
using System.Collections.Generic;

namespace TestProject3_v3
{
    [MessagePackObject]
    public partial class A
    {
        [Key(0)]
        public List<bool> Value0 { get; set; }

        [Key(1)]
        public List<int> Value1 { get; set; }
    }
}
