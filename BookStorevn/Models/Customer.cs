﻿namespace BookStorevn.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<OrderMaster> OrderMasters { get; set; }
    }
}
