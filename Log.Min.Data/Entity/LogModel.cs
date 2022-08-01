using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Log.Min.Data;

public class LogModel
    : ModelHelper.Model
{
    public int Id { get; set; }

    [MaxLength(DescriptionMax)]
	public string? Description { get; set; }

	[Column(TypeName = Datetime2Name)]
	public DateTime? Start { get; set; }

	[Column(TypeName = Datetime2Name)]
	public DateTime? End { get; set; }

	public long? TimeTicks { get; set; }
    
	[NotMapped]
	public TimeSpan Time
	{
		get { return TimeSpan.FromTicks(TimeTicks ?? default); }
		set { TimeTicks = value.Ticks; }
	}

    [ForeignKey(nameof(Task))]
	public int? TaskId { get; set; }

    [ForeignKey(nameof(Place))]
	public int? PlaceId { get; set; }

    public Task? Task { get; set; }

    public Place? Place { get; set; }
}