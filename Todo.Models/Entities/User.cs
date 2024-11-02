using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Models.Entities;

public class User
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }

    public List<Todo> Todos { get; set; }  // Kullanıcıya ait yapılacak işler listesi
}