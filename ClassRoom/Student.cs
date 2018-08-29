namespace ClassRoom
{
    public  class Student
    {
        public string Name { get; set; }
        public int Fødselsmåned { get; set; }
        public int Fødselsdag { get; set; }

        public override string ToString()
        {
            return $"{Name} {Fødselsdag} {Fødselsmåned}";
        }
    }
}