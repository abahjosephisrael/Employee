using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Employee.Models;
namespace Employee.Models
{
    public enum Dept
    {
        None,
        HR,
        IT,
        Payroll
    }
}