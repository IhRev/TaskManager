namespace TaskManager.Api.Core.DTO
{
    public class ItemDTO
    {
        public Guid Guid { get; set; }
        public Guid ParentId { get; set; }
        public string Type { get; set; } = null!;
        public string State { get; set; } = null!;
        public DateTime EstimatedDateStart { get; set; }
        public DateTime EstimatedDateEnd { get; set; }
        public int Number { get; set; }
        public Guid Executor { get; set; }
        public int BoardId { get; set; }
    }
}