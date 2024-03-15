﻿namespace Core.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string TableNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public bool IsOccupied { get; set; } = false;
        public string Image { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<EmployeeTable> EmployeeTables { get; set; }
    }
}
