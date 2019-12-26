using kyr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyr.Interfaces
{
    public interface IReviews
    { IEnumerable<Review> allReviews { get; } }
}
