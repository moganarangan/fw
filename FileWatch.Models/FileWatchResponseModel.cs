using System.Collections.Generic;

namespace FileWatch.Models
{
    public class FileWatchResponseModel
    {
        public List<FileModel> FileList { get; set; }

        public int FilesCount { get; set; }
    }
}
