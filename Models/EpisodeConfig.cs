using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FinalProjectASP.NetcoreMVC.Models
{
    public class EpisodeConfig : IEntityTypeConfiguration<Episode>
    {
            public void Configure(EntityTypeBuilder<Episode> entity)
            {
                entity.HasData(
                   new Episode { EpisodeId = 1, Title = "Help Wanted", Season = 1, Description = "SpongeBob finally applies for a job at his favourite fast food restaurant, the Krusty Krab, but he must pass a test to work there." },
                   new Episode { EpisodeId = 2, Title = "Wormy; Patty Hype", Season = 2, Description = "Spongebob and Patrick are convinced a butterfly ate Sandy's pet caterpillar. Spongebob's coloured patty sales idea becomes a huge success and Mr Krabs wants a piece of the pie." },
                   new Episode { EpisodeId = 3, Title = "Procrastination", Season = 2, Description = "SpongeBob must write an 800-word essay for boating school but gets distracted easily. When Patrick's parents come over for Starfish Day, Patrick gets upset that they still think he isn't very smart." },
                   new Episode { EpisodeId = 4, Title = "The Original Fry Cook/Night Light", Season = 5, Description = "Mr Krab's old fry cook pays a special visit to the Krusty Krab. SpongeBob is in awe of this world-renowned chef. Tales of the boogeyman send SpongeBob into a panic. " },
                   new Episode { EpisodeId = 5, Title = "The Play's the Thing; Rodeo Daze", Season = 7, Description = "Mr. Krabs opens a dinner theater at the Krusty Krab; SpongeBob takes his friends to Texas to see Sandy in a squirrel rodeo." },
                   new Episode { EpisodeId = 6, Title = "Sanctuary!; What's Eating Patrick?", Season = 9, Description = "When stray snails begin appearing around Bikini Bottom, SpongeBob decides to care for them himself; Patrick enters a krabby patty eating competition in order to defend Bikini Bottom's honor." },
                   new Episode { EpisodeId = 7, Title = "Krusty Koncessionaires; Dream Hoppers", Season = 12, Description = "The Krusty Krab crew goes to a big concert to sell krabby patties in the stands; SpongeBob explores the melodious dreamscapes of his sleeping neighbours." }
                );
            }
    }
}
