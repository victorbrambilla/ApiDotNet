﻿namespace ApiDotNet.Application.DTOs
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }

        public int UserId { get; set; }
    }
}