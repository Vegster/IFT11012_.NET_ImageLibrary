using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageSortLibrary.Model;

namespace ImageSortLibrary.DataAccess
{
    public class ImageLibraryContext : DbContext
    {

        public ImageLibraryContext()
        {
            Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(new ImageLibraryDBInitializer());
        }

        public virtual DbSet<Picture> Pictures { get; set; }

    }
}
