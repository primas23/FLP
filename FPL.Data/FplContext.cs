using System.Data.Entity;
using FPL.Data.Models;
using FPL.Data.Models.FullStats;

namespace FPL.Data
{
    public class FplContext : DbContext
    {
        public IDbSet<PlayerInformation> PlayerInformations { get; set; }

        public IDbSet<HistoryPast> HistoryPasts { get; set; }
    }
}
