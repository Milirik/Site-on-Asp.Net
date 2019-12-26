using kyr.Interfaces;
using kyr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyr.Mocks
{
    public class MockReview : IReviews
    {
        public IEnumerable<Review> allReviews
        {
            get
            {
                return new List<Review> {
                    new Review { id = 1, text = "Очень хороший сайт!" },
                    new Review { id = 2, text = "Добавьте пожалуйста комментарии к постам." },
                    new Review { id = 3, text = "Все шикарно! Хороший новостной блог!" },
                    new Review { id = 4, text = "Ну мог бы и лучше.." },
                };
            }
        }
    }
}
