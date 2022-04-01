

using System.Collections.Generic;

namespace Hotel
{
    public class Room
    {
        public int Id { get; set; } 
        public int NumberRoom { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public decimal Cost { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }

        public Room(int id, int numberRoom, string type, string status, decimal cost)
        {
            Id = id;
            NumberRoom = numberRoom;
            Type = type;
            Status = status;
            Cost = cost;
        }

        public Room(int numberRoom, string type, string status, decimal cost)
        {
            NumberRoom = numberRoom;
            Type = type;
            Status = status;
            Cost = cost;
        }

        public Room(int id, int numberRoom, string type, decimal cost)
        {
            Id = id;
            NumberRoom = numberRoom;
            Type = type;
            Cost = cost;
        }

        public Room ()
        {

        }
    }
}
