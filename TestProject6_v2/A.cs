using MessagePack;

namespace TestProject6_v2
{
    [MessagePackObject]
    public partial class A<T>
    {
        [Key(0)]
        public T[] Value { get; set; }
    }
}
