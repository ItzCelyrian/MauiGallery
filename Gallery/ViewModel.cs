using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    class MainViewModel
    {
        // Declare an ObservableCollection of images
        public ObservableCollection<String> Images { get; set; }

        public MainViewModel()
        {
            // Get the list of files in the imgDir directory
            // EXAMPLE: string[] files = Directory.GetFiles("C:\\User\\Smith\\Pictures");
            string[] files = Directory.GetFiles("");

            // Filter the list of files to only include those with a specific set of file extensions
            var imgFiles = files.Where(file =>
                Path.GetExtension(file).ToLower() == ".jpg" ||
                Path.GetExtension(file).ToLower() == ".png" ||
                Path.GetExtension(file).ToLower() == ".gif"
            ).ToArray();

            // Populate the Images collection with the images from the array
            Images = new ObservableCollection<String>();
            foreach (var file in imgFiles)
            {
                // Load the image from the file system and create an Image object for it
                Debug.WriteLine(file);
                Images.Add(file);
            }
        }
    }
}
