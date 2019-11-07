using System;
using System.Collections.Generic;
using System.Text;

namespace chunked_fs.Data
{
	public class VfsDirectory : IVfsNode
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public List<IVfsNode> Children { get; } = new List<IVfsNode>();
	}
}
