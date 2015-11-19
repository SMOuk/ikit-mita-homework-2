using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Driver
    {
        public Driver(string name, DateTime licenceDate)
        {
            LicenceDate = licenceDate;
            Name = name;
        }

        public Car Car { get; private set; }

        public string Name { get; }

        public string Category { get; set; }

        public DateTime LicenceDate { get; }

        public int Experience
        {
            get
            {
                int experience = DateTime.Now.Year - LicenceDate.Year;
                if (DateTime.Now.Month < LicenceDate.Month || (DateTime.Now.Month == LicenceDate.Month && DateTime.Now.Day < LicenceDate.Day))
                {
                    experience--;
                }
                return experience;
            }
        }

        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
            {
                Car = car;
            }
            else
            {
                throw new NullReferenceException("Категория водителя не подходит к категории автомобиля");
            }
        }
    }
}