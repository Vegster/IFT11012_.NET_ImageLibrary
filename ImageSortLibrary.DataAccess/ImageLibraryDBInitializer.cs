using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ImageSortLibrary.Model;

namespace ImageSortLibrary.DataAccess
{
    //TODO: Remove drop table 
    class ImageLibraryDBInitializer : DropCreateDatabaseIfModelChanges<ImageLibraryContext>
    {
        protected override void Seed(ImageLibraryContext context)
        {

            context.Pictures.Add(new Picture() { PictureTitle = "TestImage1", UploadDate = DateTime.Now, LocalFilePath = "F://Image.jpg" });
            context.Pictures.Add(new Picture() { PictureTitle = "TestImage2", UploadDate = DateTime.Now, LocalFilePath = "F://Image.jpg" });

            base.Seed(context);
        }
    }
}
