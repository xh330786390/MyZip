using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyZip.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //单文件解压缩
            string sourceFile = @"F:\Study\ELK\资料\data\logs.jsonl";

            //string gzipFile = @"F:\Study\ELK\资料\data\zip\logs_gzip.jsonl";
            //string bzipFile = @"F:\Study\ELK\资料\data\zip\logs_bzip.jsonl";

            //string ungzipFile = @"F:\Study\ELK\资料\data\unzip\logs_gzip.jsonl";
            //string unbzipFile = @"F:\Study\ELK\资料\data\unzip\logs_bzip.jsonl";

            //SharpZipLibHelper.ZipFile(sourceFile, gzipFile, ZipEnum.GZIP);
            //SharpZipLibHelper.ZipFile(sourceFile, bzipFile, ZipEnum.BZIP2);

            //SharpZipLibHelper.UnZipFile(gzipFile, ungzipFile, ZipEnum.GZIP);
            //SharpZipLibHelper.UnZipFile(bzipFile, unbzipFile, ZipEnum.BZIP2);

            //多文件解压缩
            //string sourceDir = @"F:\Study\ELK\资料\data";
            //string zipFiles = @"F:\Study\ELK\资料\data\zip\files.zip";
            //string zipDir = @"F:\Study\ELK\资料\data\zip\data\";

            //SharpZipLibHelper.ZipFiles(sourceDir, zipFiles, "*.json", 1, "1234", "this is zip");
            //SharpZipLibHelper.UnZipFiles(zipFiles, zipDir, "1234");

            //Ionic
            string desFile = @"F:\Study\ELK\资料\data\zip\ionic\logs.zip";
            //IonicHelper.ZipOne(sourceFile, desFile, "1234");

            IonicHelper.UnZipUnZipFiles(desFile, @"F:\Study\ELK\资料\data\", "1234");

            Console.Read();
        }
    }
}
