using System;
using System.Collections.Generic;

namespace CrudMVC.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Typedocument { get; set; } = null!;

    public string DocumentNumber { get; set; } = null!;
}
