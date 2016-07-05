using System;

namespace Entities
{
    public class Employment
    {
        public Person Employee { get; set; }

        public DateTime EmploymentStartDate { get; set; }

        public DateTime EmploymentEndDate { get; set; }

        /// <summary>
        ///     Return the number of Years that a employee has been Employed
        /// </summary>
        /// <returns></returns>
        public double NumberOfYearsEmployed
        {
            get {
                if(EmploymentEndDate < DateTime.Today)
                {
                    return (EmploymentEndDate - EmploymentStartDate).TotalDays / 365;
                }
                else
                {
                    return (DateTime.Today - EmploymentStartDate).TotalDays / 365;
                }
            }
                
        }
    }
}
