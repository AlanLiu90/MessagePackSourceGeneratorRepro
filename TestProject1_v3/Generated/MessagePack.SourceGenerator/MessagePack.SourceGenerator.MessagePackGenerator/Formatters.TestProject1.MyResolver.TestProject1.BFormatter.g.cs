﻿// <auto-generated />

#pragma warning disable 618, 612, 414, 168, CS1591, SA1129, SA1309, SA1312, SA1403, SA1649

#pragma warning disable CS8669 // We may leak nullable annotations into generated code.

using MsgPack = global::MessagePack;

namespace TestProject1 {
partial class MyResolver {
internal partial class TestProject1 {

	internal sealed class BFormatter : MsgPack::Formatters.IMessagePackFormatter<global::TestProject1.B>
	{

		public void Serialize(ref MsgPack::MessagePackWriter writer, global::TestProject1.B value, MsgPack::MessagePackSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNil();
				return;
			}

			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			writer.WriteArrayHeader(2);
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::TestProject1.A>(formatterResolver).Serialize(ref writer, value.Value1, options);
			MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::TestProject1.A[]>(formatterResolver).Serialize(ref writer, value.Value2, options);
		}

		public global::TestProject1.B Deserialize(ref MsgPack::MessagePackReader reader, MsgPack::MessagePackSerializerOptions options)
		{
			if (reader.TryReadNil())
			{
				return null;
			}

			options.Security.DepthStep(ref reader);
			MsgPack::IFormatterResolver formatterResolver = options.Resolver;
			var length = reader.ReadArrayHeader();
			var ____result = new global::TestProject1.B();

			for (int i = 0; i < length; i++)
			{
				switch (i)
				{
					case 0:
						____result.Value1 = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::TestProject1.A>(formatterResolver).Deserialize(ref reader, options);
						break;
					case 1:
						____result.Value2 = MsgPack::FormatterResolverExtensions.GetFormatterWithVerify<global::TestProject1.A[]>(formatterResolver).Deserialize(ref reader, options);
						break;
					default:
						reader.Skip();
						break;
				}
			}

			reader.Depth--;
			return ____result;
		}
	}
}
}
}
