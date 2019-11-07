using System;
using System.Collections.Generic;
using System.Text;

namespace chunked_fs.Data
{
	public class VfsFile : IVfsNode
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public List<Guid> Chunks { get; } = new List<Guid>();
	}
}
