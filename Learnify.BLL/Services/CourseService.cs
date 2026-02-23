using AutoMapper;
using Learnify.BLL.Interfaces;
using Learnify.DAL.Interfaces;
using Learnify.Domain.Entities;
using Learnify.Shared.DTOs.Course;

namespace Learnify.BLL.Services;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _repository;
    private readonly IMapper _mapper;

    public CourseService(ICourseRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CourseForShortResultDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<CourseForShortResultDto>>(entities);
    }

    public async Task<CourseForResultDto?> GetByIdAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity == null ? null : _mapper.Map<CourseForResultDto>(entity);
    }

    public async Task<CourseForResultDto> CreateAsync(CourseForCreateDto dto)
    {
        var entity = _mapper.Map<Course>(dto);
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();
        return _mapper.Map<CourseForResultDto>(entity);
    }

    public async Task<bool> UpdateAsync(long id, CourseForUpdateDto dto)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return false;

        _mapper.Map(dto, entity);
        _repository.Update(entity);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) return false;

        entity.IsDeleted = true;
        _repository.Update(entity);
        await _repository.SaveChangesAsync();

        return true;
    }
}