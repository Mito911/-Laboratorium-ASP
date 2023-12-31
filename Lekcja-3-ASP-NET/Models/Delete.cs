﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lekcja_3_ASP_NET.Models
{

    public class Delete
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public int Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }

        public bool Confirm { get; set; }
    }

}