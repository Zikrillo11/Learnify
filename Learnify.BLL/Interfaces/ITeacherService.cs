using Learnify.Shared.DTOs.Teacher;

namespace Learnify.BLL.Interfaces;

public interface ITeacherService
{
    Task<IEnumerable<TeacherForShortResultDto>> GetAllAsync();
    Task<TeacherForResultDto?> GetByIdAsync(long id);
    Task<TeacherForResultDto> CreateAsync(TeacherForCreateDto dto);
    Task<bool> UpdateAsync(long id, TeacherForUpdateDto dto);
    Task<bool> DeleteAsync(long id);
}