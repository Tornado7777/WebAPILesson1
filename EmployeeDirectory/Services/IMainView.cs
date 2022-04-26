using EmployeeDirectory.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory.Services
{
    public interface IMainView
    {
        event EventHandler<EventArgs> Load;
        void Update(ObservableCollection<Employee>? employes);
    }
}
