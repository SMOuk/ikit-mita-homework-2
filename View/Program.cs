using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Drawing;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Лада", "D") { Color = Color.Purple };

            try
            {
                Console.WriteLine($"Владелец: {car.CarPassport.Owner.Name}");
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine($"Владелец еще не назначен\n{exception.Message}");
            }

            var driver = new Driver("Вольдемар", new DateTime(1996, 10, 5)) { Category = "BC" };

            try
            {
                car.ChangeOwner(driver, "o777oo");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            driver.Category += "D";

            car.ChangeOwner(driver, "o777oo");

            Console.WriteLine($"Номер машины: {car.CarNumber}");

            try
            {
                Console.WriteLine($"Владелец: {car.CarPassport.Owner.Name}");
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine($"Владелец еще не назначен {exception.Message}");
            }

            Console.ReadKey();
        }
    }
}
