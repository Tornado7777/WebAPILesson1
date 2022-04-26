using EmployeeDirectory.Models;
using EmployeeDirectory.Services;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace EmployeeDirectory.Controllers
{
    public class MainController
    {

        private readonly IMainView _view;

        public MainController(IMainView view)
        {
            _view = view;
            Initialize();
        }

        private void Initialize()
        {
            _view.Load += OnLoad;
        }

        private void OnLoad(object? sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Employee>));
            using FileStream fileStream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "Employes.xml", FileMode.Open, FileAccess.Read);
            Employes = xmlSerializer.Deserialize(fileStream) as ObservableCollection<Employee>;
            _view.Update(Employes);
        }

        public ObservableCollection<Employee>? Employes { get; set; }
    }
}
