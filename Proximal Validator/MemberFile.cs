﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LumenWorks.Framework.IO;
using System.Data;
using LumenWorks.Framework.IO.Csv;

namespace Proximal_Validator
{
    public static class MemberFile
    {
        public static string FileName { get; set; }

        public static DataTable MemFile = new DataTable();

        private static void ReadFullMemFile()
        {
            char delimiter = '|';
            using (CsvReader reader =
                new CsvReader(new StreamReader(FileName), true, delimiter))

            {
                MemFile.Load(reader, LoadOption.OverwriteChanges);
            }
        }

        public static void setup()
        {
            ReadFullMemFile();
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
