namespace Web_API.Models
{
    public class File
    {
        public int Id { get; private set; }
        public string FileName { get; private set; }
        public string Title { get; private set; }
        public byte[] Data { get; private set; }
    }
}
