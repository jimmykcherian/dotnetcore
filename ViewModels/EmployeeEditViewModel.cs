using ClientManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientManagement.ViewModels
{
    public class EmployeeEditViewModel:Employee
    {
        public new int Id { get; set; }
    }
}
