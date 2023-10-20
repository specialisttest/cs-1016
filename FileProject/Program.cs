using System.IO;


namespace FileProject
{
    internal class Program
    {
        const string filename = @"..\..\..\test.txt";

        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(filename);
            if (!fi.Exists)
                fi.Create();

            Console.WriteLine($"{fi.FullName} {fi.CreationTime}");

            foreach(FileInfo fInfo in new DirectoryInfo(Path.Combine("..", "..", "..")).GetFiles())
                Console.WriteLine(fInfo.Name);

            //foreach(string line in File.ReadAllLines(fi.FullName))
            //    Console.WriteLine(line);

            /*FileStream fs = File.OpenRead(filename);
                //new FileStream(filename, FileMode.Open, FileAccess.Read);
            try
            {
                int ch;
                while ((ch = fs.ReadByte()) != -1)
                    Console.Write(char.ConvertFromUtf32(ch));
            }
            finally { fs?.Dispose(); }*/

            using (FileStream fs = File.OpenRead(filename))
            {
                int ch;
                while ((ch = fs.ReadByte()) != -1)
                    Console.Write(char.ConvertFromUtf32(ch));
            } // fs.Dispose()
            Console.WriteLine();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (StreamReader reader = new StreamReader(filename, Encoding.GetEncoding(1251))) 
            { 
                string line;
                while ( (line = reader.ReadLine()) != null) 
                {
                    Console.WriteLine(line);
                }
            }
            /*
             *  JSON
             *  { "color" : "red", "x" : "10"} 
             *  [
             *      { "color" : "red", "x" : "10"} ,
             *      { "color" : "red", "x" : "10"} 
             *  ]
             * 
             * 
             **/






        }
    }
}
