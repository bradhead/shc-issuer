namespace ShcIssuer.Models.Multipart
{
    using System.IO;

    public partial class MultipartEntry
    {
        public string ContentType { get; set; } = "text/plain";

        public string FileName { get; set; } = "File.txt";

        public Stream Stream { get; set; }
    }
}