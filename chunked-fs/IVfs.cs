using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace chunked_fs
{
	public interface IVfs
	{
		bool AddFile(string fullpath, Stream inputStream);

		bool DeleteFile(string fullpath);

		bool MoveFile(string currentFullpath, string newFullpath);

		Stream ReadFile(string fullpath);
	}
}
