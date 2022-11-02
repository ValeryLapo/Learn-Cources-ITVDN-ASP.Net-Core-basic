using System.Collections.Generic;

namespace _003.ViewModel.Models
{
    public class GamesViewModel
    {
        public IEnumerable<PCGame> PCGames { get; set; }
        public IEnumerable<XBoxGame> XBoxGames { get; set; }

    }
}
