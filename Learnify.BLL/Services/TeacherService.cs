using AutoMapper;
using Learnify.BLL.Interfaces;
using Learnify.Domain.Entities;
using Learnify.Domain.Interfaces.Teachers;
using Learnify.Shared.DTOs.Teacher;

namespace Learnify.BLL.Services;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _repository;
    private readonly IMapper _mapper;

    public TeacherService(ITeacherRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TeacherForShortResultDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<TeacherForShortResultDto>>(entities);
    }

    public async Task<TeacherForResultDto?> GetByIdAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity == null ? null : _mapper.Map<TeacherForResultDto>(entity);
    }

    public async Task<TeacherForResultDto> CreateAsync(TeacherForCreateDto dto)
    {
        var entity = _mapper.Map<Teacher>(dto);
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();

        return _mapper.Map<TeacherForResultDto>(entity);
    }

    public async Task<bool> UpdateAsync(long id, TeacherForUpdateDto dto)
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