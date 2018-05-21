using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ImageSortLibrary.Model
{
    public class Picture : PropertyChangeHandler
    {

        public int PictureId { get; set; }

        private string pictureTitle;


        public string PictureTitle
        {
            get { return pictureTitle; }
            set
            {
                if(SetField(ref pictureTitle, value))
                {
                    OnPropertyChanged(nameof(pictureTitle));
                    OnPropertyChanged(nameof(IsValid));
                }
            }
        }

        private string localFilePath;

        public string LocalFilePath
        {
            get { return localFilePath; }
            set
            {
                if (SetField(ref localFilePath, value))
                {
                    OnPropertyChanged(nameof(localFilePath));
                    OnPropertyChanged(nameof(IsValid));
                }
            }
        }

        private DateTime uploadDate;
        public DateTime UploadDate
        {
            get { return uploadDate; }
            set
            {
                if (SetField(ref uploadDate, value))
                    OnPropertyChanged(nameof(uploadDate));
            }
        }

        public bool IsValid { get => !string.IsNullOrEmpty(pictureTitle) && !string.IsNullOrEmpty(localFilePath); }


    }
}
