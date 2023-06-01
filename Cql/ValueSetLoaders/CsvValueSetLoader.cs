using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Poco.Fhir.R4;
using Sylvan;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Hl7.Cql.Poco.Fhir.R4.Model;

namespace Hl7.Cql.ValueSetLoaders
{
    public class CsvValueSetLoader: IValueSetLoader
    {
        private Stream Csv { get; }
        private Stream OidMap { get; }
        private string ValueSetFormatString { get; }

        public CsvValueSetLoader(Stream csv,
            Stream oidMap,
            string valueSetFormatString)
        {
            Csv = csv ?? throw new ArgumentNullException(nameof(csv));
            OidMap = oidMap ?? throw new ArgumentNullException(nameof(oidMap));
            ValueSetFormatString = valueSetFormatString;
        }

        public IValueSetDictionary Load()
        {
            var vsd = new HashValueSetDictionary();
            LoadHedisCsv(vsd, Csv, OidMap, ValueSetFormatString);
            return vsd;
        }


        public void Load(IValueSetDictionary dictionary) =>
            LoadHedisCsv(dictionary, Csv, OidMap, ValueSetFormatString);


        public static void LoadHedisCsv(IValueSetDictionary vsd, Stream csv,
            Stream oidMap,
            string valueSetFormatString)
        {
            var systemMap = FhirJson.Deserialize<Dictionary<string, CodeSystem>>(oidMap);
            LoadCsv(vsd,
                csv,
                oid => systemMap[$"urn:oid:{oid}"].url.value,
                oid => string.Format(valueSetFormatString, oid));
        }

        private static void LoadCsv(IValueSetDictionary valueSetDictionary, 
            Stream csv,
            Func<string, string> codeSystemOidToUri,
            Func<string, string> valueSetOidToUri)
        {
            if (!csv.CanRead)
                throw new ArgumentException("Stream cannot be read", nameof(csv));
            using var streamReader = new StreamReader(csv);
            var pool = new StringPool();
            var reader = Sylvan.Data.Csv.CsvDataReader.Create(streamReader, new Sylvan.Data.Csv.CsvDataReaderOptions
            {
                Delimiter = ',',
                StringFactory = pool.GetString
            });
            //Value Set Name,       0
            //Value Set OID,        1
            //Value Set Version,    2
            //Code,                 3
            //Definition,           4
            //Code System,          5
            //Code System OID,      6
            //Code System Version   7
            while (reader.Read())
            {
                var vsOid = reader.GetString(1);
                var code = reader.GetString(3);
                var display = reader.GetString(4);
                var systemOid = reader.GetString(6);

                var vsUri = valueSetOidToUri(vsOid);
                var systemUri = codeSystemOidToUri(systemOid);
                var cqlCode = new CqlCode(code, systemUri, null, null);

                valueSetDictionary.Set(vsUri, cqlCode);
            }
        }

    }
}
