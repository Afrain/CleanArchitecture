namespace CleanArchitecture.Application.UserCases.GetAllUser
{
    public sealed record GetAllUserResponse
    {
        public Guid Id { get; set; }
        public String? Name { get; set; }
        public String? Email { get; set; }
    }
}
