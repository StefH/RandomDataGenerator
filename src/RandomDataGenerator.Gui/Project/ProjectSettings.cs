using System;
using System.Collections.Generic;
using RandomDataGenerator.Gui.Entities;
using RandomDataGenerator.Gui.Generation;

namespace RandomDataGenerator.Gui.Project
{
    public class ProjectSettings
    {
        public DateTime Date { get; set; }

        public string Name { get; set; }

        public int TotalRecords { get; set; }

        public string OutputFile { get; set; }

        public BaseGenerateOptions GenerateOptions { get; set; }

        public List<DataField> DataFields { get; set; }
    }
}