// sticking with smartphones b/c I work for Fido in real life, so it is adjacent to my day to day
using System;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace MVCAssignment.Models
{
    public class Smartphone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }  
        public string OS { get; set; }
        public int Storage { get; set; }

    }
}