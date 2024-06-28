using MessagePack;

namespace TestProject4_v3
{
    [MessagePackObject]
    public partial class A
    {
        [Key(0)]
        public int[] Value1 { get; set; }

        [Key(1)]
        public int[,] Value2 { get; set; }

        [Key(2)]
        public int[,,] Value3 { get; set; }

        [Key(3)]
        public int[,,,] Value4 { get; set; }
    }
}
