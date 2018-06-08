namespace Patterns.Ex00
{
    //Адаптер
    public class ftpReader : ILogReader
    {
        private ExternalLibs.FtpClient ftpClient;
        private string login;
        private string pass;


        public ftpReader(string login, string pass)
        {
            this.login = login;
            this.pass = pass;
            ftpClient = new ExternalLibs.FtpClient();
        }

        public string ReadLogFile(string source)
        {
            return ftpClient.ReadFile(login, pass, source);
        }

        
    }


    public class LogImporterClient
    {
        /// <summary>
        /// TODO: Изменения нужно вносить в этом методе
        /// </summary>
        

        public void DoMethod()
        {
            LogImporter importer = new LogImporter(new ftpReader("log", "pass"));
            importer.ImportLogs("ftp://log.txt");


        }

    }
}