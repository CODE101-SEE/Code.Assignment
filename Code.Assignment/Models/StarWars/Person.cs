using System;

namespace Code.Assignment.Models.StarWars
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
    }
}