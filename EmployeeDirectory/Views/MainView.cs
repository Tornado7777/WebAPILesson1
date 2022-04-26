using EmployeeDirectory.Models;
using EmployeeDirectory.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDirectory
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> Load;

        public void Update(ObservableCollection<Employee> employes)
        {
            employesDataGridView.DataSource = employes;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Load?.Invoke(sender, e);
        }
    }
}
