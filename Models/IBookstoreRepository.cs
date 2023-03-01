using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    // an interface is not a class... but rather a template for a class that will ensure things are used correctly
    public interface IBookstoreRepository
    {
        // IQueryable takes the place of the lists that we've used
        // it's a class set up specifically for querying data
        IQueryable<Books> Books { get; }
    }
}
