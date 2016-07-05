using System.Collections.Generic;

namespace Entities
{
    public abstract class Company
    {
        string InternationBusinessNumber { get; set; }
        string Name { get; set; }
        List<Employment> Employments { get; set; }

        string Ppsn { get; set; }
        string EmployerRegisteredNumber { get; set; }
    }
}