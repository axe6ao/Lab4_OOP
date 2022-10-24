using System;

namespace Third
{
    public class Vehicle
    {
        public int Speed { get; set; }
        public int Weight { get; set; }

        public virtual void ShowPoperties()
        {
            Console.WriteLine(GetType().Name);
            foreach (var propertyInfo in GetType().GetProperties())
            {
                Console.WriteLine($"{propertyInfo.PropertyType} {propertyInfo.Name}");
            }
            Console.WriteLine();
        }
    }
}