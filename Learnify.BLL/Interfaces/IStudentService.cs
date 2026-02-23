using Learnify.Shared.DTOs.Student;

namespace Learnify.BLL.Interfaces;

public interface IStudentService
{
    Task<IEnumerable<StudentForShortResultDto>> GetAllAsync();
    Task<StudentForResultDto?> GetByIdAsync(long id);
    Task<StudentForResultDto> CreateAsync(StudentForCreateDto dto);
    Task<bool> UpdateAsync(long id, StudentForUpdateDto dto);
    Task<bool> DeleteAsync(long id);
}