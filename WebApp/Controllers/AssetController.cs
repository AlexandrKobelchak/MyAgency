using Context;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace WebApplication8.Controllers
{
    public class AssetController : Controller
    {
        private AppDbContext _context;

        public AssetController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Add(IFormCollection formCollection)
        {
            if (formCollection.Files.Count > 0)
            {
                foreach (IFormFile formFile in formCollection.Files)
                {
                    Guid id = Guid.NewGuid();
                    string ext = Path.GetExtension(formFile.FileName);
                    Asset asset = new Asset
                    {
                        Id = id,
                        FileName = id.ToString() + ext,
                        OriginalFileName = formFile.FileName,
                        FileExtention = ext,
                        MimeType = formFile.ContentType
                    };
                    using (Stream stream = new FileStream("./Assets/" + asset.FileName,
                        FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                    {
                        formFile.CopyToAsync(stream);
                    }
                    _context.Set<Asset>().Add(asset);
                }
                _context.SaveChanges();
            }

            return Redirect("/Home/Index");
        }

        public IActionResult Get(Guid? id)
        {
            if (!id.HasValue) 
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            Asset asset = _context.Set<Asset>().FirstOrDefault(x => x.Id == id.Value);

            if(asset==null) 
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            Stream s = new FileStream("./Assets/"+asset.FileName,
                FileMode.Open, FileAccess.Read, FileShare.Write);

            return new FileStreamResult(s, asset.MimeType);

        }
        public IActionResult Delete(Guid? id)
        {

            return Redirect("/Home/Index");
        }
        public IActionResult Update(IFormCollection formCollection)
        {

            return Redirect("/Home/Index");
        }
    }
}
