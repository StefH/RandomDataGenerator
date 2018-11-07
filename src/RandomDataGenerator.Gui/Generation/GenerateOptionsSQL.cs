
namespace RandomDataGenerator.Gui.Generation
{
    public class GenerateOptionsSQL : BaseGenerateOptions
    {
        public GenerateOptionsSQL()
        {
            //TotalRecords = 1000;
            RecordsPerInsert = 10;
            //File = @"C:\Tmp\output.sql";
            Table = "My Table";
            IncludeFieldNames = true;
        }

        //public int TotalRecords { get; internal set; }

        public int RecordsPerInsert { get; set; }

        //public string File { get; internal set; }

        public string Table { get; set; }

        public bool IncludeFieldNames { get; set; }
    }
}