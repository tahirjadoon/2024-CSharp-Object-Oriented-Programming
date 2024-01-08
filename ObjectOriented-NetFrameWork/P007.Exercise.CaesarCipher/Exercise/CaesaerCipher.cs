using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P007.Exercise.CaesarCipher.Exercise
{
	/// <summary>
	/// CeaserCipher : by default the encrypt and decrypt will by shift 3 unless overwritten
	/// </summary>
    public static class CaesaerCipher
    {
		private static int _shift;

        static CaesaerCipher()
        {
			//default
			_shift = 3;
        }

		/// <summary>
		/// Shift characters by, default is 3
		/// </summary>
        public static int Shift
		{
			get { return _shift; }
			set { _shift = value; }
		}

		/// <summary>
		/// Encrypt method
		/// </summary>
		/// <param name="plainText"></param>
		/// <returns></returns>
		public static string Encrypt(string plainText)
		{
			if(string.IsNullOrWhiteSpace(plainText)) return string.Empty;

			char[] plainArray = plainText.ToLower().ToCharArray();
			char[] cipherArray = new char[plainArray.Length];

			for (int i = 0; i < plainArray.Length; i++)
			{
				char letter = plainArray[i];
                //do not shift space
                if (letter == ' ')
                {
                    cipherArray[i] = letter;
                    continue;
                }

                //shift
                letter = (char)(letter + _shift);

				//if the shift has moved to any letter other than a to z then move back to a 
				if(letter > 'z')
				{
					letter = (char)(letter - 26);
				}
				else if(letter < 'a')
				{
                    letter = (char)(letter + 26);
                }
				cipherArray[i] = letter;
			}

			return new string(cipherArray);
		}

        /// <summary>
        /// Decrypt method
        /// </summary>
        /// <param name="cipherText"></param>
        /// <returns></returns>
        public static string Decrypt(string cipherText)
        {
            if (string.IsNullOrWhiteSpace(cipherText)) return string.Empty;

            char[] cipherArray = cipherText.ToLower().ToCharArray();
            char[] plainArray = new char[cipherArray.Length];

            for (int i = 0; i < cipherArray.Length; i++)
            {
                char letter = cipherArray[i];
				//do not shift space
				if (letter == ' ')
				{
                    plainArray[i] = letter;
                    continue;
				}

                //shift
                letter = (char)(letter - _shift);

                //if the shift has moved to any letter other than a to z then move back to a 
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                plainArray[i] = letter;
            }

            return new string(plainArray);
        }

    }
}
