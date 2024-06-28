
using MsgPack = global::MessagePack;

namespace X {

partial class MyCompositeResolver : MsgPack::IFormatterResolver
{
	public static readonly MyCompositeResolver Instance = new MyCompositeResolver();

	private static readonly MsgPack::IFormatterResolver[] ResolverList = new MsgPack::IFormatterResolver[]
	{
		new global::TestProject2.X.MyResolver(),
		global::MessagePack.Resolvers.StandardResolver.Instance,
	};

	private MyCompositeResolver() { }

	public MsgPack::Formatters.IMessagePackFormatter<T> GetFormatter<T>()
	{
		return FormatterCache<T>.Formatter;
	}

	static class FormatterCache<T>
	{
		internal static readonly MsgPack::Formatters.IMessagePackFormatter<T> Formatter;

		static FormatterCache()
		{
			foreach (var resolver in ResolverList)
			{
				var f = resolver.GetFormatter<T>();
				if (f != null)
				{
					Formatter = f;
					return;
				}
			}
		}
	}
}

}
