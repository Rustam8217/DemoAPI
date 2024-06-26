namespace DemoAPI.Data.Entities;

public class Application : BaseEntity
{
    public string? SampleNumber { get; set; }
    public DateTime? ReceivedAt { get; set; }
    public int CassettesCount { get; set; }
    public int FragmentCount { get; set; }
    
    public long? UserId { get; set; }
    public ApplicationUser? User { get; set; }
}