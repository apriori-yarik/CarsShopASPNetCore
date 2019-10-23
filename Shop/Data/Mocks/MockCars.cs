using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Porsche 911 Carrera",
                        ShortDescription = "Fast, stylish and modern",
                        LongDescription = "Timeless and contemporary have never been so close!",
                        Image = "/img/SportCars/Porsche911.jpg",
                        Price = 160860,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "SportCars")
                    },
                    new Car {
                        Name = "Lexus LC",
                        ShortDescription = "Brilliant, large and leaden-footed",
                        LongDescription = "Modest price for one of the best sportcars!",
                        Image = "/img/SportCars/LexusLC.jpg",
                        Price = 145399,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "SportCars")
                    },
                    new Car {
                        Name = "Jaguar F-Type",
                        ShortDescription = "Inspired, wonderful and vivacious car",
                        LongDescription = "Since its arrival in 2013, two attributes have come to define the F-Type: its sublime aluminium bodywork and the way it sounds.",
                        Image = "/img/SportCars/JaguarFType.jpg",
                        Price = 227733,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "SportCars")
                    },
                    new Car {
                        Name = "Chevrolet Corvette C7",
                        ShortDescription = "Enjoyable, likeable and dramatic",
                        LongDescription = "Take the fun way into the office. Your commute will never be the same.",
                        Image = "/img/SportCars/ChevroletCorvetteC7.jpg",
                        Price = 150000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "SportCars")
                    },
                    new Car
                    {
                        Name = "Alfa Romeo 4C",
                        ShortDescription = "Easy, ambitious and rich",
                        LongDescription = "The Alfa Romeo 4C may look better than it drives. But by gum, it looks good.",
                        Image = "/img/SportCars/AlfaRomeo4C.jpg",
                        Price = 117910,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "SportCars")
                    },
                    new Car
                    {
                        Name = "BMW i8",
                        ShortDescription = "Innovative, free and exhilarating",
                        LongDescription = "More than innovation. Revolution.", 
                        Image = "/img/SportCars/BMWi8.jpg",
                        Price = 263213,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "SportCars")
                    },
                    new Car
                    {
                        Name = "Lotus Evrora",
                        ShortDescription = "Manic, ferocious and hilarious",
                        LongDescription = "The lightest, lithest GT car that money can buy. Oh, and did we mention one of the best-driving?",
                        Image = "/img/SportCars/LotusEvrora.jpg",
                        Price = 165250,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "SportCars")
                    },
                    new Car
                    {
                        Name = "Maserati GranTurismo",
                        ShortDescription = "Complex, dynamic and desirable",
                        LongDescription = "Rarely seen, always heard",
                        Image = "/img/SportCars/MaseratiGranTurismo.jpg",
                        Price = 236654,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "SportCars")
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDescription = "Classic, cheap and comfortable",
                        LongDescription = "This gen-2 Leaf hits a broad sweet spot of usability, likability and affordability.",
                        Image = "/img/E-Cars/NissanLeaf.jpg",
                        Price = 74000,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "E-Cars")
                    },
                    new Car
                    {
                        Name = "Tesla Model X",
                        ShortDescription = "Modern, dominant and easy",
                        LongDescription = "Tesla's second step along the path to world domination. Fear its Falcon Doors!",
                        Image = "/img/E-Cars/TeslaX.jpg",
                        Price = 173775,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "E-Cars")
                    },
                    new Car
                    {
                        Name = "Hyundai Ioniq Electric",
                        ShortDescription = "Powerful, smooth and joyful",
                        LongDescription = "A well-equipped EV with 26 miles more range – that’s an entire marathon – than an entry-level Leaf.",
                        Image = "/img/E-Cars/HyundaiIoniq.jpg",
                        Price = 73566,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "E-Cars")
                    },
                    new Car
                    {
                        Name = "Renault Zoe",
                        ShortDescription = "Efficient, competing and hugely popular",
                        LongDescription = "Renault mends the bits that needed mending and leaves the bits that didn’t. A big step forwards.",
                        Image = "/img/E-Cars/RenaultZoe.jpg",
                        Price = 71234,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "E-Cars")
                    },
                    new Car
                    {
                        Name = "BMW i3",
                        ShortDescription = "Small, compact and fashionable",
                        LongDescription = "The i3 remains the best premium small EV out there. Just be prepared to pay proper money.",
                        Image = "/img/E-Cars/BMWi3.jpg",
                        Price = 90393,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "E-Cars")
                    },
                    new Car
                    {
                        Name = "Audi e-tron",
                        ShortDescription = "Developed, safe and well executed",
                        LongDescription = "A very conventional Audi, built to persuade regular SUV buyers to make the EV jump.",
                        Image = "/img/E-Cars/AudiE-tron.jpg",
                        Price = 161883,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "E-Cars")
                    },
                    new Car
                    {
                        Name = "Hyundai Kona Electric",
                        ShortDescription = "Different, useful and smart",
                        LongDescription = "A proper tipping point BEV: genuine 300-mile (ish) range in a small SUV for under £30k. Consider it.",
                        Image = "/img/E-Cars/HyundaiConaElectric.jpg",
                        Price = 87263,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "E-Cars")
                    },
                    new Car
                    {
                        Name = "Jaguar I-Pace",
                        ShortDescription = "Massive, rewarding and spacious",
                        LongDescription = "The I-Pace won’t be for everyone, but hats off to Jaguar for making a car that steps boldly into the unknown, and shows those pesky Germans the way.",
                        Image = "/img/E-Cars/JaguarI-Pace.jpg",
                        Price = 141997,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "E-Cars")
                    },
                    new Car
                    {
                        Name = "Tesla Model 3",
                        ShortDescription = "Satisfying, well-engineered and unique",
                        LongDescription = "Everything Tesla has done up to this point has built towards the Model 3... and it's been worth it",
                        Image = "/img/E-Cars/TeslaModel3.jpg",
                        Price = 89000,
                        IsFavourite = true,
                        Available = false,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "E-Cars")
                    },
                    new Car
                    {
                        Name = "Honda Accord Hybrid",
                        ShortDescription = "Cheap, powerful and staggering",
                        LongDescription = "Roomy, comfortable sedan with a smooth ride",
                        Image = "/img/CommutingCars/HondaAccordHybrid.jpg",
                        Price = 28083,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "CommutingCars")
                    },
                    new Car
                    {
                        Name = "Mazda3",
                        ShortDescription = "Quick, comfortable and domineering",
                        LongDescription = "Mazda’s new 3 family hatch: low on excitement, high on quiet satisfaction",
                        Image = "/img/CommutingCars/Mazda3.jpg",
                        Price = 32120,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "CommutingCars")
                    },
                    new Car
                    {
                        Name = "Lexus CT 200H Hybrid",
                        ShortDescription = "Heavy, lucky and easy to drive",
                        LongDescription = "To call this a posh Prius may sound a little harsh, but that’s what it is.",
                        Image = "/img/CommutingCars/LexusCT200HHybrid.jpg",
                        Price = 41072,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "CommutingCars")
                    },
                    new Car
                    {
                        Name = "Mercedes E250 BluTec",
                        ShortDescription = "Prestigious, powerful and manageable",
                        LongDescription = "Brilliant BlueTec Benz's only flaw is dashboard tech",
                        Image = "/img/CommutingCars/MercedesE250BluTec.jpg",
                        Price = 43880,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "CommutingCars")
                    },
                    new Car
                    {
                        Name = "Lincoln MKZ Hybrid",
                        ShortDescription = "Luxurious, practical and classy",
                        LongDescription = "It’s not about pure logic, it’s about emotion. Pride, joy and envy will make Lincoln succeed. Maintaining the relatively safe, inoffensive designs and clever engineering will not.",
                        Image = "/img/CommutingCars/LincolnMKZHybrid.jpg",
                        Price = 41247,
                        IsFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.FirstOrDefault(c => c.CategoryName == "CommutingCars")
                    }


                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
