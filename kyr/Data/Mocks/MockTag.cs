using kyr.Interfaces;
using kyr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyr.Mocks
{
    public class MockTag : ITags
    {
        public IEnumerable<Tag> allTags {
            get {
                return new List<Tag> {
                    new Tag { Name = "Природа"},
                    new Tag { Name = "Спорт"},
                    new Tag { Name = "Высшее образование"},
                    new Tag { Name = "Programming"},
                };
            }
        }
    }
}