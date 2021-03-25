using System.Runtime.Serialization;

namespace Players
{
    public class Player
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public Player()
        {

        }
        public Player(string fname, string lname, int age, double weight, int height)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;

        }

        public override string ToString()
        {
            return $"{Fname} {Lname}, Wiek: {Age}, Waga: {Weight} kg, Wzrost: {Height} cm";
        }

        public override bool Equals(object obj)
        {
            var p = obj as Player;
            if (p.Fname != this.Fname) return false;
            if (p.Lname != this.Lname) return false;
            if (p.Age != this.Age) return false;
            if (p.Weight != this.Weight) return false;
            if (p.Height != this.Height) return false;

            return true;
        }
    }
    
}
