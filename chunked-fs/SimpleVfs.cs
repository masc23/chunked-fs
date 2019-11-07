using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace chunked_fs
{
	public class SimpleVfs : IVfs
	{
		public bool AddFile(string fullpath, Stream inputStream)
		{
			throw new NotImplementedException();
		}

		public bool DeleteFile(string fullpath)
		{
			throw new NotImplementedException();
		}

		public bool MoveFile(string currentFullpath, string newFullpath)
		{
			throw new NotImplementedException();
		}

		public Stream ReadFile(string fullpath)
		{
			throw new NotImplementedException();
		}
	}
}
