using MessagePack;

namespace TestProject2
{
    [MessagePackObject]
    public partial class A
    {
        [Key(0)]
        public int Value { get; set; }
    }
}
