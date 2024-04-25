using Episode.Models;

namespace FinalProjectASP.NetcoreMVC.Models
{
    public interface IEpisodeUnitOfWork
    {
        public IRepository<Episode> Episodes { get; }

        public void Save();
    }
}
