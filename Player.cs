namespace Players
{
    public class Player
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public Player()
        {

        }
        public Player(string fname, string lname, int age, double weight)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Age = age;
            this.Weight = weight;

        }

        public override string ToString()
        {
            return $"{Fname} {Lname}, Wiek: {Age}, Waga: {Weight} kg";
        }
    }
    
}
