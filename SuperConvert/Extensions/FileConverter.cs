﻿using System;
using System.IO;

namespace SuperConvert.Extensions
{
    public static class FileConverter
    {
        [Obsolete("This Class is Deprecated, it will be removed on future versions, Please use 'SuperConvert.Files'")]
        public static string ToBase64String(string fullPath) => Convert.ToBase64String(File.ReadAllBytes(fullPath));
        [Obsolete("This Method is Deprecated, it will be removed on future versions, Please use 'SuperConvert.Files'")]
        public static void ToFile(string base64String, string fileName, string filePath = "")
        {
            File.WriteAllBytes(fileName, Convert.FromBase64String(base64String));
        }
    }
}