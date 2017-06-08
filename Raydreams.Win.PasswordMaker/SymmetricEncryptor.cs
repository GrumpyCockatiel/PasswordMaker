using System;
using System.IO;
using System.Security.Cryptography;

namespace Raydreams.Win.PasswordMaker
{
	/// <summary></summary>
	public enum SymmetricAlgoType: byte
	{
		/// <summary>AES (aka Rijndael) encryption.</summary>
		AES,
		/// <summary>DES encryption - very weak - use TripleDES at least.</summary>
		DES,
		/// <summary>Triple DES encryption - does DES three times.</summary>
		TripleDES,
		/// <summary>RC2 encryption.</summary>
		RC2
	}

	/// <summary>Class to contain the message, key and init vector of a symmetric encryption.</summary>
	/// <remarks>Use Convert.FromBase64String and Convert.ToBase64String to save the bytes as string data or hard code the bytes.</remarks>
	public class CipherMessage
	{
		public byte[] CipherBytes;
		public byte[] Key;
		public byte[] IV;
	}

	/// <summary></summary>
	public class SymmetricEncryptor
	{
		private SymmetricAlgorithm _algo = null;

		/// <summary>Constructor.</summary>
		public SymmetricEncryptor( SymmetricAlgoType algo )
		{
			this.CreateEncryptor( algo );
		}

		/// <summary>Selectes the correct algorithm to instantiate</summary>
		private void CreateEncryptor(SymmetricAlgoType type)
		{
			if ( type == SymmetricAlgoType.AES )
				this._algo = new RijndaelManaged();
			else if ( type == SymmetricAlgoType.TripleDES )
				this._algo = new TripleDESCryptoServiceProvider();
			else if ( type == SymmetricAlgoType.RC2 )
				this._algo = new RC2CryptoServiceProvider();
			else
				this._algo = new DESCryptoServiceProvider();
		}

		/// <summary>Get the legal key sizes of the instantiated algorithm.</summary>
		public KeySizes KeySizes
		{
			get { return this._algo.LegalKeySizes[0]; }
		}

		/// <summary>Encrypt a string using a symmetric key algorithm.</summary>
		public CipherMessage EncryptStringToBytes( string plainText, int keySize )
		{
			if ( plainText == null || plainText.Length <= 0 )
				throw new ArgumentNullException( "plainText" );

			// validate and set the key size
			try
			{
				this._algo.KeySize = keySize;
			}
			catch ( CryptographicException )
			{ this._algo.KeySize = this._algo.LegalKeySizes[0].MinSize; }

			this._algo.GenerateIV();
			this._algo.GenerateKey();

			CipherMessage msg = new CipherMessage();
			msg.IV = this._algo.IV;
			msg.Key = this._algo.Key;

			msg.CipherBytes = EncryptStringToBytes( plainText, this._algo.Key, this._algo.IV );

			return msg;
		}

		/// <summary>Encrypt a string using a symmetric key algorithm.</summary>
		/// <param name="plainText">text to be encrypted</param>
		/// <param name="Key">Private symmetric key used for encryption.</param>
		/// <param name="IV">Init vector used offsetting blocks.</param>
		/// <returns></returns>
		public byte[] EncryptStringToBytes( string plainText, byte[] Key, byte[] IV )
		{
			// Check arguments.
			if ( plainText == null || plainText.Length <= 0 )
				throw new ArgumentNullException( "plainText" );
			if ( Key == null || Key.Length <= 0 )
				throw new ArgumentNullException( "Key" );
			if ( IV == null || IV.Length <= 0 )
				throw new ArgumentNullException( "Key" );

			// Declare the streams used to encrypt to an in memory array of bytes.
			MemoryStream msEncrypt = null;
			CryptoStream csEncrypt = null;
			StreamWriter swEncrypt = null;

			try
			{
				this._algo.Key = Key;
				this._algo.IV = IV;

				// Create a decrytor to perform the stream transform.
				ICryptoTransform encryptor = this._algo.CreateEncryptor( this._algo.Key, this._algo.IV );

				// Create the streams used for encryption.
				msEncrypt = new MemoryStream();
				csEncrypt = new CryptoStream( msEncrypt, encryptor, CryptoStreamMode.Write );
				swEncrypt = new StreamWriter( csEncrypt );

				// Write all data to the stream.
				swEncrypt.Write( plainText );

			}
			finally
			{
				// Close the streams.
				if ( swEncrypt != null )
					swEncrypt.Close();
				if ( csEncrypt != null )
					csEncrypt.Close();
				if ( msEncrypt != null )
					msEncrypt.Close();
			}

			// Return the encrypted bytes from the memory stream.
			return msEncrypt.ToArray();
		}

		/// <summary>Decrypt cipter text using a symmetric key algorithm.</summary>
		public string DecryptStringFromBytes( CipherMessage msg )
		{
			return this.DecryptStringFromBytes( msg.CipherBytes, msg.Key, msg.IV );
		}

		/// <summary>Decrypt cipter text using a symmetric key algorithm.</summary>
		/// <param name="cipherText">The encrypted message as a byte array.</param>
		/// <param name="Key">The key used in the original encryption.</param>
		/// <param name="IV">The init vector used in the original encryption.</param>
		/// <returns></returns>
		public string DecryptStringFromBytes( byte[] cipherText, byte[] Key, byte[] IV )
		{
			// Check arguments.
			if ( cipherText == null || cipherText.Length <= 0 )
				throw new ArgumentNullException( "cipherText" );
			if ( Key == null || Key.Length <= 0 )
				throw new ArgumentNullException( "Key" );
			if ( IV == null || IV.Length <= 0 )
				throw new ArgumentNullException( "Key" );

			// Declare the streams used to decrypt to an in memory array of bytes.
			MemoryStream msDecrypt = null;
			CryptoStream csDecrypt = null;
			StreamReader srDecrypt = null;

			// Declare the string used to hold the decrypted text.
			string plaintext = null;

			try
			{
				this._algo.Key = Key;
				this._algo.IV = IV;

				// Create a decrytor to perform the stream transform.
				ICryptoTransform decryptor = this._algo.CreateDecryptor( this._algo.Key, this._algo.IV );

				// Create the streams used for decryption.
				msDecrypt = new MemoryStream( cipherText );
				csDecrypt = new CryptoStream( msDecrypt, decryptor, CryptoStreamMode.Read );
				srDecrypt = new StreamReader( csDecrypt );

				// Read the decrypted bytes from the decrypting stream and place them in a string.
				plaintext = srDecrypt.ReadToEnd();
			}
			finally
			{
				// Close the streams.
				if ( srDecrypt != null )
					srDecrypt.Close();
				if ( csDecrypt != null )
					csDecrypt.Close();
				if ( msDecrypt != null )
					msDecrypt.Close();
			}

			return plaintext;
		}

		/// <summary>Zeros out memory.</summary>
		public void Clear()
		{
			// Clear the RijndaelManaged object.
			if ( this._algo != null )
				this._algo.Clear();
		}
	}
}
