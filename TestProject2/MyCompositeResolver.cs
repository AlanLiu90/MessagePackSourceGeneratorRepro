using MessagePack;
using MessagePack.Resolvers;

namespace TestProject2.X
{
    [CompositeResolver(typeof(MyResolver), typeof(StandardResolver))]
    public partial class MyCompositeResolver
    {
    }
}
