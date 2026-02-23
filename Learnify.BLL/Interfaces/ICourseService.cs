using Learnify.Shared.DTOs.Course;

namespace Learnify.BLL.Interfaces;

public interface ICourseService
{
    Task<IEnumerable<CourseForShortResultDto>> GetAllAsync();
    Task<CourseForResultDto?> GetByIdAsync(long id);
    Task<CourseForResultDto> CreateAsync(CourseForCreateDto dto);
    Task<bool> UpdateAsync(long id, CourseForUpdateDto dto);
    Task<bool> DeleteAsync(long id);
}