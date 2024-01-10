namespace CaesarCipherApp
{
	public static class CaesarCipher
	{
		public static unsafe string BasicEncryption(string _input, short _shiftCount)
		{
			if(_input is null)
			{
				return string.Empty;
			}
			else if(_input.Length <= 0)
			{
				return string.Empty;
			}

			Span<char> _encryptedString = stackalloc char[_input.Length];
			for(int i = 0; i < _input.Length; i++)
			{
				_encryptedString[i] =
					_input[i] == ' '
					? ' '
					: (char)(_input[i] + _shiftCount);
			}
			return _encryptedString.ToString();
		}
	}
}
