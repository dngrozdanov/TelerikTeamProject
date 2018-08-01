﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LifeSim.Core.IO.Contracts;

namespace LifeSim.Core.WorkFunctions
{
    public class FileReader : IReadable
    {
        /// <summary>
        /// Read file from file system
        /// </summary>
        /// <param name="path">Path to current file to read</param>
        /// <returns></returns>
        public IList<string> ReadFile(string path)
        {
            var strLines = new List<string>();

            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    strLines.Add(line);

                    line = reader.ReadLine();
                }
            }

            return strLines;
        }
    }
}