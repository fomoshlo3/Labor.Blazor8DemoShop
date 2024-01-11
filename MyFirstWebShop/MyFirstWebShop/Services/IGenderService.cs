using MyFirstWebShop.Data.DTOs;
using MyFirstWebShop.Data.Entity;

namespace MyFirstWebShop.Services
{
    public interface IGenderService
    {

        Task<List<GenderSelectDTO>> GetAllGenderSelectDTOAsync();

        Task<GenderDetailDTO?> GetGenderDetailDTOByIdAsync(int id);

        void AddGender(GenderDetailDTO gender);

        void UpdateGender(GenderDetailDTO gender);

        void DeleteGender(Gender gender);

        void DeleteGenderById(int id);

        
    }
}
