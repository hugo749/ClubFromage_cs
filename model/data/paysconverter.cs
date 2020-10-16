using System;
using System.Collections.Generic;
using System.Text;
using model.data;
using System.IO;
using CsvHelper;
using System.Globalization;
using model.business;
using System.Linq;
using DEB;
using System.Data;

namespace model.data
{
    class paysconverter
    {
        public pays convertFromString()
        {
            using (var reader = new StreamReader("path\\to\\file.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        csv.Configuration.RegisterClassMap<fromageMap>();
        csv.GetRecords<fromage>().ToList().Dump();
    }

}
    public class fromage
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public pays pays { get; set; }
    }

public class pays
{
    public string fromage { get; set; }
}

public class paysConverter<T> : DefaultTypeConverter
{
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        return paysConvert.DeserializeObject<T>(text);
    }

    public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
    {
        return paysConvert.SerializeObject(value);
    }
}

public class fromageMap : ClassMap<fromage>
{
    public FromageMap()
    {
        Map(m => m.Id);
        Map(m => m.Name);
        Map(m => m.Json).TypeConverter<paysConverter<pays>>();
    }
}
    }
}
