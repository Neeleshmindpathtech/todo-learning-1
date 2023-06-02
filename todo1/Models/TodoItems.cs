using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace todo1.Models

{
    public class TodoItems
    {
        public long Id { get ; set;}
        public string? Name { get; set;}

        public bool isComplete { get; set;}
        public string? Secret { get; set;}

    }
}
