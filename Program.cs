using System;

namespace Model_Three_Things
{
    class Program
    {
         public class House
        {
            //properties
            public string FloorType { get; set; }
            public string PaintColor { get; set; }
            public string RoofType  { get; set; }

            //constructor
            public House(string FloorType, string PaintColor, string RoofType)
            {
                FloorType = FloorType;
                PaintColor = PaintColor;
                RoofType = RoofType;
            }

            public override string ToString()
            {
                return $"My house has {FloorType} floors, is {PaintColor} on the exterior, and has a {RoofType} roof.";
            }

        }

        public class FavTeam
        {
            public string Team { get; set; }
            public string Mascot { get; set; }
            public string Color { get; set; }

            public FavTeam(string Team, string Mascot, string Color)
            {
                Team = Team;
                Mascot = Mascot;
                Color = Color;
            }

            public override string ToString()
            {
                return $"My favorite football team is {Team}, its mascot is {Mascot}, with the primary color of {Color}";
            }

        }

        public class Family
        {
            public string WifeName { get; set; }
            public string DaughterName { get; set; }
            public string DogName { get; set; }

        public Family(string WifeName, string DaughterName, string DogName)
            {
                WifeName = WifeName;
                DaughterName = DaughterName;
                DogName = DogName;
            }

            public override string ToString()
            {
                return $"Members of my family includes {WifeName}, {DaughterName}, {DogName}";
            }

        }
        static void Main(string[] args)
        {
            var MyHome = new House("Tile", "Gray", "Shingle");

            var MyFavTeam = new FavTeam("Saints", "Sir Saint", "Black");

            var FamilyNames = new Family("Mary", "Maggie", "Cody");

            Console.WriteLine(MyHome);
            Console.WriteLine(MyFavTeam);
            Console.WriteLine(FamilyNames);
        }
    }
}
