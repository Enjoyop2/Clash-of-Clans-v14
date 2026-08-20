using System;
using System.Text;

using ClashofClans.Utilities.Netty;

namespace ClashofClans.Utilities.Crypto
{
	public class Rc4Core
	{
		public Rc4Core(string key, string nonce)
		{
			InitializeCiphers(Encoding.UTF8.GetBytes(key + nonce));
		}

		public Rc4 Encryptor { get; set; }

		public Rc4 Decryptor { get; set; }

		public static byte[] GenerateNonce
		{
			get
			{
				Random random = new Random();
				byte[] buffer = new byte[random.Next(15, 25)];
				random.NextBytes(buffer);
				return buffer;
			}
		}

		public void Encrypt(ref ByteBuffer data)
		{
			for (int k = 0; k < data.ReadableBytes; k++)
			{
				int b = data.GetByte(k) ^ Encryptor.Prga();
				data.SetByte(k, b);
			}
		}

		public void Decrypt(ref ByteBuffer data)
		{
			for (int k = 0; k < data.ReadableBytes; k++)
			{
				int b = data.GetByte(k) ^ Decryptor.Prga();
				data.SetByte(k, b);
			}
		}

		public void Encrypt(ref byte[] data)
		{
			if (data == null)
				throw new ArgumentNullException(nameof(data));

			for (int k = 0; k < data.Length; k++)
				data[k] ^= Encryptor.Prga();
		}

		public void Decrypt(ref byte[] data)
		{
			if (data == null)
				throw new ArgumentNullException(nameof(data));

			for (int k = 0; k < data.Length; k++)
				data[k] ^= Decryptor.Prga();
		}

		public void InitializeCiphers(byte[] key)
		{
			Encryptor = new Rc4(key);
			Decryptor = new Rc4(key);

			for (int k = 0; k < key.Length; k++)
			{
				Encryptor.Prga();
				Decryptor.Prga();
			}
		}
	}
}