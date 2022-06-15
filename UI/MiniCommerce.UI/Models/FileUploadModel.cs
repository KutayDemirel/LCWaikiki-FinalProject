

using System.ComponentModel.DataAnnotations;
using System.IO;

namespace MiniCommerce.UI.Models
{
    public class FileUploadModel
    {
        //[DataType(DataType.Upload)]
        //[Display(Name = "Upload File")]
        //[Required(ErrorMessage = "Please choose file to upload.")]
        //public string file { get; set; }
        public FileInfo[] FileImage { get; set; }
    }
}

