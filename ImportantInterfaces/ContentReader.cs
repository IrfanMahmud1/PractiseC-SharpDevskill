
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class ContentReader : IDisposable
    {
        public Stream _stream;
        public ContentReader(string path)
        {
            _stream = File.Open(path, FileMode.Open);
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }

        public string GetContent(int size)
        {
            byte[] buffer = new byte[size];
            _stream.Read(buffer, 0, size);

            return Encoding.UTF8.GetString(buffer);
        }
    }
}
