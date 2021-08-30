using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG
{
    interface GameInterface
    {
        List<Genre> GetRandomGenres(List<Genre> InitialListOfGenres, int AmountToReturn = 4);

        // TODO:
        // Add method to get random mount of artists!!!
    }
}
