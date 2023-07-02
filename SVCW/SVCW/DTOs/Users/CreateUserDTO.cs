namespace SVCW.DTOs.Users
{
	public class CreateUserDTO : UserResponse
	{
        public string UserId { get; set; }
        public string Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public bool? Gender { get; set; }
        public string? Image { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? CreateAt { get; set; }
        public string? Status { get; set; }
        public string? RoleId { get; set; }

        public static explicit operator CreateUserDTO(LoginUserDTO v)
        {
            var result = new CreateUserDTO();

            result.UserId = v.UserId;
            result.Email = v.Email;
            result.Username = v.Username;
            result.Password = v.Password;
            result.FullName = v.FullName;
            result.Phone = v.Phone;
            result.Gender = v.Gender;
            result.Image = v.Image;
            result.DateOfBirth = v.DateOfBirth ?? result.DateOfBirth;
            result.CreateAt = v.CreateAt ?? result.CreateAt;
            result.Status = v.Status;
            result.RoleId = v.RoleId;

            return result;
        }
    }
}

