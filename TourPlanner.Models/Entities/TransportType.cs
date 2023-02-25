using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TourPlanner.Models.Enums;

namespace TourPlanner.Models.Entities;

public class TransportType
{
    [Key]
    [Column("transport_type_id")]
    public TransportTypeId TransportTypeId { get; set; }

    [Required]
    [Column("name")]
    public string Name { get; set; }
}