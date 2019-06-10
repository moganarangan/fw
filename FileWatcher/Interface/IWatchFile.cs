using FileWatch.Models;

namespace FileWatcher.Interface
{
    public interface IWatchFile
    {
        FileWatchResponseModel GetAllFiles();
    }
}
