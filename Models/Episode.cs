using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace FinalProjectASP.NetcoreMVC.Models
{
    public class Episode
    {
        public int EpisodeId { get; set; }
        [StringLength(200, ErrorMessage = "Title may not exceed 200 characters.")]
        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }
        
      
        public int Season { get; set; }
        [StringLength(500, ErrorMessage = "Title may not exceed 500 characters.")]
        [Required(ErrorMessage = "Please enter a Description.")]
        public string Description { get; set; }
       


    } 
}
