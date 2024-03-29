﻿using System;
using System.Collections.Generic;

namespace EMSApi.Models;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DeptName { get; set; } = null!;

    public string? Location { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
