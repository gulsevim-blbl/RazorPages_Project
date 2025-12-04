using razorpages.Models;

namespace razorpages.Repository;

public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;
    public MockEmployeeRepository()
    {
        _employeeList = new List<Employee>()
        {
            new Employee { Id = 1, Name="Ahmet Yılmaz", Email = "ahmetyilmaz@gmailc.com", Photo = "1.jpg", Deparment = "Muhasebe"},
            new Employee { Id = 2, Name="Hasan Cengiz", Email = "hasancengiz@gmailc.com", Photo = "2.jpg", Deparment = "Muhasebe"},
            new Employee { Id = 3, Name="Canan Turan", Email = "cananturan@gmailc.com", Photo = "3.jpg", Deparment = "Muhasebe"},
            new Employee { Id = 4, Name="Volkan Yükselen", Email = "volkanyukselen@gmailc.com", Photo = "4.jpg", Deparment = "Muhasebe"},
            new Employee { Id = 5, Name="Demet Özdemir", Email = "demetozdemir@gmail.com", Photo = "5.jpg", Deparment = "Muhasebe"},
            new Employee { Id = 6, Name="Seniha Çalışkan", Email = "senihacaliskan@gmail.com", Photo = "6.jpg", Deparment = "Muhasebe"},
             new Employee { Id = 7, Name="Semih Akkan", Email = "semihakkan@gmail.com", Photo = "7.jpg", Deparment = "Muhasebe"},
              new Employee { Id = 8, Name="Selin Duymaz", Email = "selinduymaz@gmail.com", Photo = "8.jpg", Deparment = "Muhasebe"},
        };
    }
    public IEnumerable<Employee> GetAll()
    {
        return _employeeList;
    }
    public Employee GetById(int id)
    {
        return _employeeList.FirstOrDefault(i => i.Id == id);
    }
}

