namespace ClashofClans.Utilities.Crypto
{
	public class Rc4
	{
		public Rc4(byte[] key)
		{
			Key = Ksa(key);
		}

		public byte[] Key { get; set; }
		public byte I { get; set; }
		public byte J { get; set; }

		public byte Prga()
		{
			I = (byte)((I + 1) % 256);
			J = (byte)((J + Key[I]) % 256);

			byte temp = Key[I];
			Key[I] = Key[J];
			Key[J] = temp;

			return Key[(Key[I] + Key[J]) % 256];
		}

		public static byte[] Ksa(byte[] key)
		{
			byte[] s = new byte[256];

			for (int i = 0; i != 256; i++)
				s[i] = (byte)i;

			byte j = 0;

			for (int i = 0; i != 256; i++)
			{
				j = (byte)((j + s[i] + key[i % key.Length]) % 256);

				byte temp = s[i];
				s[i] = s[j];
				s[j] = temp;
			}

			return s;
		}
	}
}