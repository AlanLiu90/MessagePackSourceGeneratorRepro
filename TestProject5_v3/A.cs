using MessagePack;
using System.Collections.Generic;

namespace TestProject5_v3
{
    [MessagePackObject]
    public partial class A
    {
        [Key(0)]
        public List<int>[] Value { get; set; }
    }
}
