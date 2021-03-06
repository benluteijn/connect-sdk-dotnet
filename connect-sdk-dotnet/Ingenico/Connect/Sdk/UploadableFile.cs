using System;
using System.IO;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// A file that can be uploaded.
    /// </summary>
    public class UploadableFile
    {
        public UploadableFile(string fileName, Stream content, string contentType, long contentLength = -1)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("File Name is required");
            }
            if (content == null)
            {
                throw new ArgumentException("Content is required");
            }
            if (string.IsNullOrWhiteSpace(contentType))
            {
                throw new ArgumentException("Content Type is required");
            }
            FileName = fileName;
            Content = content;
            ContentType = contentType;
            ContentLength = Math.Max(contentLength, -1);
        }

        /// <summary>
        /// The name of the file.
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// A stream with the file's content.
        /// </summary>
        public Stream Content { get; private set; }

        /// <summary>
        /// The file's content type.
        /// </summary>
        public string ContentType { get; private set; }

        /// <summary>
        /// The file's content length, or -1 if not known.
        /// </summary>
        public long ContentLength { get; private set; }
    }
}
