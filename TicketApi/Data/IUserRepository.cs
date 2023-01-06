using TicketApi.ModelsDTO.User;

namespace TicketApi.Data
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string email);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
