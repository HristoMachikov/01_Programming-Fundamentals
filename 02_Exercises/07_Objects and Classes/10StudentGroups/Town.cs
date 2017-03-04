namespace _10StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Town
    {
       public string Name { get; set; }

       public int SeatPlaces { get; set; }

       public List<Student> Students { get; set; }
    }
}