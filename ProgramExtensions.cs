using System.Text;

namespace CS8_Alg_TextManipulation;

internal static class ProgramExtensions
{
    /// <summary>
    /// Encrypt or Decrypt a string of text using a password using a variant Vigenere Cipher.
    /// </summary>
    /// <param name="str">Text to be affected</param>
    /// <param name="password">Password used to Encrypt/Decrypt</param>
    /// <returns>Encrypted or Decrypted String</returns>
    internal static string ApplyCipher(this string str, string password)
    {
        var data = Encoding.UTF8.GetBytes(str);
        var key = Encoding.UTF8.GetBytes(password);
        var result = data.ApplyCipher(key);
        return Encoding.UTF8.GetString(result);
    }

    /// <summary>
    /// Encrypt or Decrypt raw data using a raw data key using a variant Vigenere Cipher
    /// </summary>
    /// <param name="data">Data to be affected</param>
    /// <param name="key">Key used in the Cipher</param>
    /// <returns>Encrypted or Decrypted data</returns>
    internal static byte[] ApplyCipher(this byte[] data, byte[] key)
    {
        for (var i = 0; i < data.Length; i++)
        {
            var j = i % key.Length;
            data[i] ^= key[j]; // XOR the bytes and store back in data array.
        }
        return data;
    }
}