using System;
using System.Collections.Generic;
using System.IO;
using FileWatch.Models;
using FileWatcher.Interface;

namespace FileWatcher
{
    public class WatchFile : IWatchFile
    {
        public FileWatchResponseModel GetAllFiles()
        {
            // return GetLocalFiles();

            return GetSharedFiles();
        }

        private FileWatchResponseModel GetLocalFiles()
        {
            var response = new FileWatchResponseModel { FileList = new List<FileModel> { } };

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

            return response;
        }

        private FileWatchResponseModel GetSharedFiles()
        {
            var response = new FileWatchResponseModel { FileList = new List<FileModel> { } };
            var dir = Directory.GetFiles(@"\\26.163.2.155\dbs\EMEA\FileWatcher");

            foreach (var filepath in dir)
            {
                var fi = new FileInfo(filepath);

                var file = new FileModel
                {
                    FileName = fi.Name,
                    Extension = fi.Extension,
                    FileSize = fi.Length,
                    DateCreated = fi.CreationTime,
                    DateLastUpdated = fi.LastWriteTime
                };
                response.FileList.Add(file);
            }

            return response;
        }
    }
}
