using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasYGrupos.Models
{
    internal class InicialBuilder : IListaBuilder
    {
        public List<Employee> dameEmpleados()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee()
            {
                ID = 1,
                FName = "John",
                MName = "",
                LName = "Shields",
                DOB = DateTime.Parse("1971/12/11"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 2,
                FName = "Mary",
                MName = "Matthew",
                LName = "Jacobs",
                DOB = DateTime.Parse("1961/01/17"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 3,
                FName = "Amber",
                MName = "Carl",
                LName = "Agar",
                DOB = DateTime.Parse("1971/12/23"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 4,
                FName = "Kathy",
                MName = "",
                LName = "Berry",
                DOB = DateTime.Parse("1976/11/15"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 5,
                FName = "Lena",
                MName = "Ashco",
                LName = "Bilton",
                DOB = DateTime.Parse("1978/05/11"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 6,
                FName = "Susanne",
                MName = "",
                LName = "Buck",
                DOB = DateTime.Parse("1965/03/7"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 7,
                FName = "Jim",
                MName = "",
                LName = "Brown",
                DOB = DateTime.Parse("1972/09/11"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 8,
                FName = "Jane",
                MName = "G",
                LName = "Hooks",
                DOB = DateTime.Parse("1972/12/11"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 9,
                FName = "Robert",
                MName = "",
                LName = "",
                DOB = DateTime.Parse("1964/06/28"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 10,
                FName = "Cindy",
                MName = "Preston",
                LName = "Fox",
                DOB = DateTime.Parse("1978/01/11"),
                Sex = 'M'
            });
            return empList;
        }
    }
}
