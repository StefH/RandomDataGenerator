using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Enums;
using RandomDataGenerator.Gui.Entities;

namespace RandomDataGenerator.Gui.Data
{
    public class DataManager
    {
        private readonly IList<Field> _fields = new List<Field>();

        public DataManager()
        {
            _fields.Add(new Field
            {
                FieldType = FieldType.Numbers,
                SubFields = new[]
                {
                    // new SubField { SubFieldType = SubFieldType.Boolean },
                    // new SubField { SubFieldType = SubFieldType.Short },
                    new SubField { SubFieldType = SubFieldType.Integer },
                    // new SubField { SubFieldType = SubFieldType.Long },
                    // new SubField { SubFieldType = SubFieldType.Float },
                    // new SubField { SubFieldType = SubFieldType.Double }
                }
            });

            _fields.Add(new Field
            {
                FieldType = FieldType.IT,
                SubFields = new[]
                {
                    new SubField { SubFieldType = SubFieldType.IPv4Address },
                    new SubField { SubFieldType = SubFieldType.IPv6Address },
                    new SubField { SubFieldType = SubFieldType.MACAddress },
                    new SubField { SubFieldType = SubFieldType.Guid }
                }
            });

            _fields.Add(new Field
            {
                FieldType = FieldType.Human,
                SubFields = new[] {
                    new SubField { SubFieldType = SubFieldType.FirstName },
                    new SubField { SubFieldType = SubFieldType.LastName },
                    new SubField { SubFieldType = SubFieldType.FullName },
                    new SubField { SubFieldType = SubFieldType.EmailAddress }
                }
            });

            _fields.Add(new Field
            {
                FieldType = FieldType.Location,
                SubFields = new[] {
                    new SubField { SubFieldType = SubFieldType.Country },
                    new SubField { SubFieldType = SubFieldType.City }
                }
            });

            _fields.Add(new Field
            {
                FieldType = FieldType.Text,
                SubFields = new[] {
                    new SubField { SubFieldType = SubFieldType.Text },
                    new SubField { SubFieldType = SubFieldType.TextPattern },
                    new SubField { SubFieldType = SubFieldType.TextWords },
                    // new SubField { SubFieldType = SubFieldType.TextLipsum }
                }
            });

            _fields.Add(new Field
            {
                FieldType = FieldType.Time,
                SubFields = new[] {
                    new SubField { SubFieldType = SubFieldType.DateTime }
                }
            });

            _fields.Add(new Field
            {
                FieldType = FieldType.Set,
                SubFields = new[] {
                    new SubField { SubFieldType = SubFieldType.StringList }
                }
            });
        }

        public List<Field> GetFields()
        {
            return _fields.ToList();
        }

        public List<SubField> GetSubFields()
        {
            return _fields.SelectMany(f => f.SubFields).ToList();
        }

        public List<SubField> GetSubFields(FieldType fieldType)
        {
            return _fields.Single(f => f.FieldType == fieldType).SubFields.ToList();
        }
    }
}