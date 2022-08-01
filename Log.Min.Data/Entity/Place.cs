using System.ComponentModel.DataAnnotations;
using ModelHelper;

namespace Log.Min.Data;

public class Place
    : Model
	    , IModelA
{
	public int Id { get; set; }

	[Required, MaxLength(NameMax)]
	public string? Name { get; set; }

	[Required, MaxLength(DescriptionMax)]
	public string? Description { get; set; }
}