namespace YouTubeVideos
{
    public class Comment
    {
        private string _commentername;
        private string _text;

        public Comment(string name, string text)
        {
            _commentername = name;
            _text = text;
        }

        public string GetCommenterName()
        {
            return _name;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
