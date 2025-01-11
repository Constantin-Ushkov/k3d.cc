using k3d.CC.Model.Interface;
using System.Security.Cryptography;
using System.Text;

namespace k3d.CC.Model.Impl
{
    public class SHA256Hasher : IHashingProvider, IDisposable
    {
        public SHA256Hasher()
        {
            _algorithm = SHA256.Create();
        }

        public byte[] GetHash(string str)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

            return _algorithm.ComputeHash(Encoding.UTF8.GetBytes(str));
        }

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            _algorithm.Dispose();
            _disposed = true;
        }

        private bool _disposed = false;
        private readonly HashAlgorithm _algorithm;
    }
}
