using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class PhotoIterator:IIterator
    {
        PhotoCollection photoCollection;
        int current;
        public PhotoIterator(PhotoCollection photoCollection)
        {
            this.photoCollection = photoCollection;
            current = 0;
        }
        public Photo GetNext()
        {
            Photo photo = photoCollection.GetPhoto(current);
            current++;
            return photo;
        }
        public bool HasNext()
        {
            return current <= photoCollection.Count();
        }
    }
}
