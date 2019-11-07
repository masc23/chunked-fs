using System;
using System.Collections.Generic;
using System.Text;

namespace chunked_fs.Data
{
	public interface IVfsNode
	{
		Guid Id { get; set; }

		string Name { get; set; }
	}
}
