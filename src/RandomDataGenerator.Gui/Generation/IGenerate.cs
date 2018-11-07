using System.Collections.Generic;
using RandomDataGenerator.Gui.Entities;

namespace RandomDataGenerator.Gui.Generation
{
    interface IGenerate
    {
        void Spawn(List<DataField> fields, int totalRecords, string fileName);
    }
}