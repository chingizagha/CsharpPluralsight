using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
        Pie Add(Pie newPie);
        Pie Update(Pie updatedPie);
        Pie Remove(int id);
    }
}
