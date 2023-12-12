﻿using System;
using System.IO;

namespace RainbowForge.RenderPipeline
{
	public class TextureMap
	{
		public uint Var1 { get; }
		public uint Var2 { get; }
		public uint Var3 { get; }
		public uint Var4 { get; }
		public byte[] Data { get; }
		public ulong[] TexUidMipSet1 { get; }
		public ulong[] TexUidMipSet2 { get; }
		public byte[] Data2 { get; }

		private TextureMap(uint var1, uint var2, uint var3, uint var4, byte[] data, ulong[] texUidMipSet1, ulong[] texUidMipSet2, byte[] data2)
		{
			Var1 = var1;
			Var2 = var2;
			Var3 = var3;
			Var4 = var4;
			Data = data;
			TexUidMipSet1 = texUidMipSet1;
			TexUidMipSet2 = texUidMipSet2;
			Data2 = data2;
		}

		public static TextureMap Read(BinaryReader r, uint version, bool hasHeader)
		{
			if (hasHeader)
				FileMetaData.Read(r, version);
			var magic = r.ReadUInt32();
			MagicHelper.AssertEquals(Magic.TextureMap, magic);

			switch (version)
			{
				case >= 30:
					{
						var var1 = r.ReadUInt32();
						var var2 = r.ReadUInt32();
						var var3 = r.ReadUInt32();
						var var4 = r.ReadUInt32();

						var data = r.ReadBytes(52);

						var texUidMipSet1 = new ulong[5];
						for (var i = 0; i < 5; i++)
							texUidMipSet1[i] = r.ReadUInt64();

						var texUidMipSet2 = new ulong[5];
						for (var i = 0; i < 5; i++)
							texUidMipSet2[i] = r.ReadUInt64();

						var data2 = r.ReadBytes(32);

						return new TextureMap(var1, var2, var3, var4, data, texUidMipSet1, texUidMipSet2, data2);
					}
				// case <= 29:
				//     {

				//     }
				default:
					throw new NotImplementedException($"Unsupported version {version}");
			}
		}
	}
}