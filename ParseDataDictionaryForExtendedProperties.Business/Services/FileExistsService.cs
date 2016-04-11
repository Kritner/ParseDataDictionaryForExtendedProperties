﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParseDataDictionaryForExtendedProperties.Business.Interfaces;

namespace ParseDataDictionaryForExtendedProperties.Business.Services
{

    /// <summary>
    /// Check if a file exists
    /// </summary>
    public class FileExistsService : IFileExists
    {

        /// <summary>
        /// Check if a file exists
        /// </summary>
        /// <param name="fullFileNameAndPath">The path to check</param>
        /// <returns></returns>
        public bool CheckFileExists(string fullFileNameAndPath)
        {
            if (string.IsNullOrEmpty(fullFileNameAndPath))
                throw new ArgumentException(nameof(fullFileNameAndPath));

            return File.Exists(fullFileNameAndPath);
        }
    }
}
