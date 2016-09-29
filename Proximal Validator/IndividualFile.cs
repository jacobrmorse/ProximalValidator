using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using LumenWorks.Framework.IO.Csv;
using System.Data;

namespace Proximal_Validator
{
    public static class IndividualFile
    {
        public static string FileName { get; set; }

        public static DataTable IndFile { get; set; }

        private static void ReadFullMemFile()
        {
            char delimiter = '|';
            using (CsvReader reader =
                new CsvReader(new StreamReader(FileName), true, delimiter))

            {
                IndFile.Load(reader, LoadOption.OverwriteChanges);
            }
        }

        public static void setup()
        {
            ReadFullIndFile();
        }

        private static void ReadFullIndFile()
        {
            IndFile = new DataTable();
            char delimiter = '|';
            using (CsvReader reader =
                new CsvReader(new StreamReader(FileName), true, delimiter))
            {
                IndFile.Load(reader,LoadOption.OverwriteChanges);
            }
        }

        internal static void ValidFieldLength()
        {
            throw new NotImplementedException();
        }

        internal static void CharacterType()
        {
            throw new NotImplementedException();
        }

        internal static void RequiredFields()
        {
            throw new NotImplementedException();
        }
    }
}