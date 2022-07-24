namespace Log.Min.Data;

public class LogUpdate 
    : LogReset
{
    public string? Description { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }

    public override void Update(LogModel model)
    {
        base.Update(model);
        if (string.IsNullOrWhiteSpace(Description) == false
            && Description.Trim() != model.Description?.Trim())
                model.Description = Description;
        if (Start.HasValue
            && Start.Value != model.Start)
                model.Start = Start.Value;
        if (End.HasValue
            && End.Value != model.End)
                model.End = End.Value;
        ComputeTimeTicks(model);
    }

    private void ComputeTimeTicks(LogModel model)
    {
        if (model.Start.HasValue && model.End.HasValue)
		{
			model.TimeTicks = 
                (model.End - model.Start).Value.Ticks;
		}
    }
}