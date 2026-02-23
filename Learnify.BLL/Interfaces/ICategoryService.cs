using Learnify.Shared.DTOs.Category;

namespace Learnify.BLL.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryForShortResultDto>> GetAllAsync();
    Task<CategoryForResultDto?> GetByIdAsync(long id);
    Task<CategoryForResultDto> CreateAsync(CategoryForCreateDto dto);
    Task<bool> UpdateAsync(long id, CategoryForUpdateDto dto);
    Task<bool> DeleteAsync(long id);
}