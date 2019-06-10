using System;

namespace FileWatch.Models
{
    public class FileModel
    {
        public string FileName { get; set; }

        public string Extension { get; set; }

        public decimal FileSize { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateLastUpdated { get; set; }
    }
}
