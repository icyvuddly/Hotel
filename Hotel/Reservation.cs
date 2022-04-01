namespace Hotel
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ResidentId { get; set; }
        public int RoomId { get; set; }
        public int EmployeeId { get; set; }
        public int ReservationPeriod { get; set; }
        public decimal TotalCost { get; set; }
        public virtual Resident Resident { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Room Room { get; set; }
    }
}
