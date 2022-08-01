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
}