using System;
using System.Collections.Generic;
using System.Text;

namespace FileExtension
{
    internal class GetExtensionFile
    {
        public static string GetExtension(string fileName)
        {
            int index = fileName.LastIndexOf('.');
            return (index != -1) ? fileName.Substring(index + 1) : "";
        }

    }
}
