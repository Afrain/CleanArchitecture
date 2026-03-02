namespace CleanArchitecture.Application.UserCases.DeleteUser
{
    public sealed class DeleteUserResponse
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
    }
}
