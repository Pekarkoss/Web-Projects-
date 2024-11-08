using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyWebApi.Models
{
    public class PointValue
    {
        [Key]
        
        public long Id { get; set; }
        
        public string Name { get; set; }
        public string Wkt { get; set; } 
    }
}

