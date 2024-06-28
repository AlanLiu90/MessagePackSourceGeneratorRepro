using MessagePack;

namespace TestProject1
{
    [MessagePackObject]
    public partial struct A
    {
        [Key(0)]
        public int Id { get; set; }
    }

    [MessagePackObject]
    public partial class B
    {
        [Key(0)]
        public A Value1 { get; set; }

        [Key(1)]
        public A[] Value2 { get; set; }
    }
}
