using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TourPlanner.Models.Enums;

namespace TourPlanner.Models.Entities;

public class Tour
{
    [Key]
    [Column("tour_id")]
    public int TourId { get; set; }

    [Required]
    [Column("name")]
    public string Name { get; set; }

    [Required]
    [Column("description")]
    public string Description { get; set; }

    [Required]
    [Column("from")]
    public string From { get; set; }

    [Required]
    [Column("to")]
    public string To { get; set; }

    [Required]
    [Column("fk_transport_type_id")]
    public TransportTypeId TransportTypeId { get; set; }

    public ICollection<Log> Logs { get; set; }

    public TransportType TransportType { get; set; }
}