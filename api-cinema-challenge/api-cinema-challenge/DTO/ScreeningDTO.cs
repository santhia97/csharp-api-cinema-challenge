﻿using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public int Id { get; set; }

        public int ScreenNumber { get; set; }

        public int ScreenCapacity { get; set; }

        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
