using System;
using System.IO;


namespace SqlCreater.Utils
{
    public static class FileUtils
    {
        public static FileInfo createFileInfo(this string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo;
        }

        public static StreamReader streamReader(this string filePath)
        {
            return new StreamReader(filePath.createFileInfo().OpenRead());
        }
    }
}
