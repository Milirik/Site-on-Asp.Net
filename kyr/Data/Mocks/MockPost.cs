using kyr.Interfaces;
using kyr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyr.Mocks
{
    public class MockPost : IPosts
    {
        private readonly ITags _tags = new MockTag();

        public IEnumerable<Post> allPosts
        {
            get
            {
                return new List<Post> {
                    new Post {
                        id = 1,
                        img = "/img/chess.jpg",
                        title = "1 место",
                        text = "Наши шахматисты заняли первое место на турнире Слон!",
                        Tag = _tags.allTags.ElementAt(1) },
                    new Post {
                        id = 2,
                        img = "/img/csharp.png",
                        title = "С# - так ли хорош?",
                        text = "Одназначно могу сказать, что C# является одним из лучших языков программирования!",
                        Tag = _tags.allTags.ElementAt(3) },
                    new Post {
                        id = 3,
                        img = "/img/football.jpg",
                        title = "3 место",
                        text = "Наши футболисты заняли 3 место. Достойные соперники, достойная игра. Поздравляем наших ребят! Ждем побед в следующем году!",
                        Tag = _tags.allTags.ElementAt(1)},
                    new Post {
                        id = 4,
                        img = "/img/mai.jpg",
                        title = "Новый указ",
                        text = "С нового года вступает новый указ о дополнительной стипендии всех студентов бюджетной формы обучения в размере 10 тысяч рублей!",
                        Tag = _tags.allTags.ElementAt(2) },
                    new Post {
                        id = 5,
                        img = "/img/nature.jpg",
                        title = "Сохраните природы",
                        text = "В наше время главное беречь природу!",
                        Tag = _tags.allTags.ElementAt(0) },
                };
            }
        }
    }
}
