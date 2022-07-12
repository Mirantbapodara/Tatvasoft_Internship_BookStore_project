using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models.ViewModels
{
    public partial class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmpId { get; set; }

        public virtual Employee IdNavigation { get; set; }
    }
}
