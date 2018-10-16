using System;
using Microsoft.AspNetCore.NodeServices;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Trainees.Data.Entities
{
    public class Trainee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Date { get; set; }
        public string Grade { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string IsDelete { get; set; }
        public Trainee()
        {

        }


    }
}
