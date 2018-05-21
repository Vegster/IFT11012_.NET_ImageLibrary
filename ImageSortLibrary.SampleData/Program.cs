using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageSortLibrary.DataAccess;
using ImageSortLibrary.Model;

namespace ImageSortLibrary.SampleData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Program start!");

            using (var db = new ImageLibraryContext())
            {
                db.Pictures.Add(new Picture() { PictureTitle = "VegardsBilde" , UploadDate = DateTime.Now, LocalFilePath = "F://Vetle.jpg" });
                db.SaveChanges();
            }

            Console.Write("Program done...");
            Console.Read();

        }
    }
}
