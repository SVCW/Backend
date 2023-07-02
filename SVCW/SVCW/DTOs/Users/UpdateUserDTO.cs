﻿using System;
namespace SVCW.DTOs.Users
{
	public class UpdateUserDTO : UserResponse
	{
        public string? UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public bool? Gender { get; set; }
        public string? Image { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Status { get; set; }
        public string? RoleId { get; set; }
    }
}
