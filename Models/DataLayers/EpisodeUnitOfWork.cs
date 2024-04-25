using Episode.Models;
using FinalProjectASP.NetcoreMVC.Models.DataLayers;

namespace FinalProjectASP.NetcoreMVC.Models
{
    public class EpisodeUnitOfWork : IEpisodeUnitOfWork
    {
        private EpisodeContext context { get; set; }
        public EpisodeUnitOfWork(EpisodeContext ctx) => context = ctx;

        private IRepository<Episode> episodeData;
        public IRepository<Episode> Episodes {
            get {
                if (episodeData == null)
                    episodeData = new Repository<Episode>(context);
                return episodeData;
            }
        }

        public void Save() => context.SaveChanges();
    }
}
