using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class PhotoCollection:IIteratorCollection
    {
        public List<Photo> photos;
        public PhotoCollection()
        {
            photos = new List<Photo>();
        }
        public Iterator CreateIterator()
        {
            return new PhotoIterator(this);
        }
        public Photo GetPhoto(int index)
        {
            return photos[index];
        }
        public int Count()
        {
            return photos.Count();
        }
    }
}
