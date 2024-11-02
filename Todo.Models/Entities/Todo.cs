using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Models.Entities;

public class Todo
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public Priority Priority { get; set; }
    public int CategoryId { get; set; }
    public bool Completed { get; set; }
    public string UserId { get; set; }

    public Category Category { get; set; }  // Category ile ilişki
    public User User { get; set; }          // User ile ilişki
}