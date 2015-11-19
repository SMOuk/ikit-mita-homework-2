using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Domain
{
    public class Car
    {
        public string Model { get; }

        public string Category { get; }

        public string CarNumber { get; private set; }

        public CarPassport CarPassport { get; }

        public Car()
        {
            Category = Category;
            Model = Model;
            CarPassport CarPassport = new CarPassport(this);
        }
        public Car(string model, string category)
        {
            Model = model;
            Category = category;
            CarPassport = new CarPassport(this);
        }

        public Color Color { get; set; } = Color.Blue;

        public void ChangeOwner(Driver name, string carNumber)
        {
            CarNumber = carNumber;
            CarPassport.Owner = name;
            name.OwnCar(this);

        }
    }
}
