using Microsoft.AspNetCore.Mvc;
using FileWatch.Models;
using FileWatcher.Interface;

namespace FileWatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        public IWatchFile _watchFile;

        public FilesController(IWatchFile watchFile)
        {
            _watchFile = watchFile;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<FileWatchResponseModel> Get()
        {
            return _watchFile.GetAllFiles();
        }
    }
}
