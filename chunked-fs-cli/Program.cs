using System;
using System.IO;
using chunked_fs;

namespace chunked_fs_cli
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			const string storageDir = @"C:\WOW\ChunkedFS\test-storage";
			const string inputFile = @"C:\WOW\ChunkedFS\chunked-fs\README.md";
			const string virtualFile = "/testfile.txt";

			IVfs vfs = new SimpleVfs(storageDir);
			Console.WriteLine(vfs.AddFile(virtualFile, File.OpenRead(inputFile)) ? "success" : "error");
		}
	}
}
