using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RandomDataGenerator.Gui.Entities;
using RandomDataGenerator.Gui.Util;

namespace RandomDataGenerator.Gui.Generation
{
    public class GenerateSQL : Generate<GenerateOptionsSQL>, IGenerate
    {
        public GenerateSQL(GenerateOptionsSQL options)
            : base(options)
        {
        }

        public void Spawn(List<DataField> fields, int totalRecords, string fileName)
        {
            var sb = new StringBuilder();

            string insertString = $"INSERT INTO [{Options.Table}] ";
            string includeFieldNamesString = Options.IncludeFieldNames ? $"({string.Join(", ", fields.Select(f => $"[{f.Name}]"))})"
                : string.Empty;

            for (int r = 0; r < totalRecords / Options.RecordsPerInsert; r++)
            {
                WriteBatch(sb, insertString, includeFieldNamesString, fields, Options.RecordsPerInsert);
            }

            int additionalInserts = totalRecords % Options.RecordsPerInsert;
            if (additionalInserts > 0)
            {
                WriteBatch(sb, insertString, includeFieldNamesString, fields, additionalInserts);
            }

            File.WriteAllText(fileName, sb.ToString());
        }

        private void WriteBatch(StringBuilder sb, string insertString, string includeFieldNamesString, List<DataField> fields, int numBatch)
        {
            sb.Append(insertString);
            sb.Append(includeFieldNamesString);
            sb.Append(" VALUES ");

            for (int batch = 0; batch < numBatch; batch++)
            {
                var fieldData = new List<string>();
                foreach (var field in fields)
                {
                    object randomValue = field.GetData();
                    string value = field.FieldOptions.ValueAsString ? StringUtils.AddSQLQuotes(randomValue) : StringUtils.MakeSafeSQL(randomValue);

                    fieldData.Add(value);
                }

                sb.Append($"({string.Join(", ", fieldData)})");
                sb.Append(batch < numBatch - 1 ? ", " : ";");
            }

            sb.AppendLine();
        }
    }
}