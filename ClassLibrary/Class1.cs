using System;

namespace ClassLibrary
{
    public class Class1
    {
        public int Id { get; set; }

        public string Name { get; set; }  

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
