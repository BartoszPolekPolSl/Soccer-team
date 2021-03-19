namespace Players
{
    class Player
    {
        private string Fname { get; set; }
        private string Lname { get; set; }
        private int Age { get; set; }
        private double Weight { get; set; }
        public Player(string fname, string lname, int age, double weight)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Age = age;
            this.Weight = weight;

        }

        public override string ToString()
        {
            return $"{Fname} {Lname}, Wiek: {Age}, Waga: {Weight}";
        }
    }
    
}
