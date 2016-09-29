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

        public static DataTable IndFile = new DataTable();

        private static void ReadFullIndFile()
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

        internal static void ValidFieldLength()
        {

        }

        internal static void CharacterType()
        {

        }

        internal static void RequiredFields()
        {

        }
    }
}