using AutoMapper;
using Learnify.BLL.Interfaces;
using Learnify.DAL.Interfaces;
using Learnify.Domain.Entities;
using Learnify.Shared.DTOs.Student;

namespace Learnify.BLL.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;
    private readonly IMapper _mapper;

    public StudentService(IStudentRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<StudentForShortResultDto>> GetAllAsync()
    {
        var students = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<StudentForShortResultDto>>(students);
    }

    public async Task<StudentForResultDto?> GetByIdAsync(long id)
    {
        var student = await _repository.GetByIdAsync(id);

        if (student == null || student.IsDeleted)
            return null;

        return _mapper.Map<StudentForResultDto>(student);
    }

    public async Task<StudentForResultDto> CreateAsync(StudentForCreateDto dto)
    {
        var entity = _mapper.Map<Student>(dto);

        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();

        return _mapper.Map<StudentForResultDto>(entity);
    }

    public async Task<bool> UpdateAsync(long id, StudentForUpdateDto dto)
    {
        var student = await _repository.GetByIdAsync(id);

        if (student == null || student.IsDeleted)
            return false;

        _mapper.Map(dto, student);

        _repository.Update(student);
        await _repository.SaveChangesAsync();

        return true;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var student = await _repository.GetByIdAsync(id);

        if (student == null || student.IsDeleted)
            return false;

        student.IsDeleted = true;

        _repository.Update(student);
        await _repository.SaveChangesAsync();

        return true;
    }
}