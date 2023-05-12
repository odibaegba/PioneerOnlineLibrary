using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using PioneerOnlineLibrary.Core.Interface;
using PioneerOnlineLibrary.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Core.Services
{
    public class ImageService 
    {
        //private readonly IImageService _imageService;
        private readonly Cloudinary _cloudinary;
        public ImageService(Cloudinary cloudinary)
        {
            //_imageService = imageService;
            _cloudinary = cloudinary;
        }

        public Book Upload(IFormFile file)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.FileName, file.OpenReadStream())
            };

            var uploadResult = _cloudinary.Upload(uploadParams);

            var book = new Book
            {
                ISBN = uploadResult.PublicId,
                ImageURL = uploadResult.SecureUrl.AbsoluteUri

            };

            return book;
        }

        public Book Get(string publicId)
        {
            var book = new Book
            {
                ISBN = publicId,
                ImageURL = _cloudinary.Api.UrlImgUp.BuildUrl(publicId),

            };
            
            return book;
        }
    }
}
