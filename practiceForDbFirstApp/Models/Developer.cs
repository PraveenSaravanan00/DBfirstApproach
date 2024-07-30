using System;
using System.Collections.Generic;

namespace practiceForDbFirstApp.Models;

public partial class Developer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }
}
