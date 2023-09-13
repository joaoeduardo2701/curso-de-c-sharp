using aula128.Entities.Enums;
using System.Collections.Generic;

namespace aula128.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departments Departments { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker ()
        {
                
        }

    }
}
