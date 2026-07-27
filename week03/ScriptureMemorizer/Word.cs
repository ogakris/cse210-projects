namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public bool IsHidden()
        {
            return _isHidden;
        }

        public string GetDisplayText()
        {
            if (_isHidden)
            {
                
                char[] hiddenChars = new char[_text.Length];
                for (int i = 0; i < _text.Length; i++)
                {
                    hiddenChars[i] = char.IsLetterOrDigit(_text[i]) ? '_' : _text[i];
                }
                return new string(hiddenChars);
            }

            return _text;
        }
    }
}
