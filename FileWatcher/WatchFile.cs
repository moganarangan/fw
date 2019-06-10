using System;
using System.Collections.Generic;
using FileWatch.Models;
using FileWatcher.Interface;

namespace FileWatcher
{
    public class WatchFile : IWatchFile
    {
        public FileWatchResponseModel GetAllFiles()
        {
            var response = new FileWatchResponseModel { FileList = new List<FileModel> { }, FilesCount = 0 };

            var file = new FileModel
            {
                FileName = "Some File 1",
                Extension = "txt",
                FileSize = (decimal)2.05,
                DateCreated = DateTime.Now,
                DateLastUpdated = DateTime.Now
            };
            response.FileList.Add(file);

            file = new FileModel
            {
                FileName = "Some File 2",
                Extension = "txt",
                FileSize = (decimal)1.05,
                DateCreated = DateTime.Now,
                DateLastUpdated = DateTime.Now
            };
            response.FileList.Add(file);

            file = new FileModel
            {
                FileName = "Some File 3",
                Extension = "txt",
                FileSize = (decimal)2.75,
                DateCreated = DateTime.Now,
                DateLastUpdated = DateTime.Now
            };
            response.FileList.Add(file);

            file = new FileModel
            {
                FileName = "Some File 4",
                Extension = "txt",
                FileSize = (decimal)3.25,
                DateCreated = DateTime.Now,
                DateLastUpdated = DateTime.Now
            };
            response.FileList.Add(file);

            file = new FileModel
            {
                FileName = "Some File 5",
                Extension = "txt",
                FileSize = (decimal)1.23,
                DateCreated = DateTime.Now,
                DateLastUpdated = DateTime.Now
            };
            response.FileList.Add(file);

            file = new FileModel
            {
                FileName = "Some File 6",
                Extension = "txt",
                FileSize = (decimal)4.05,
                DateCreated = DateTime.Now,
                DateLastUpdated = DateTime.Now
            };
            response.FileList.Add(file);

            response.FilesCount = response.FileList.Count;
            return response;
        }
    }
}
