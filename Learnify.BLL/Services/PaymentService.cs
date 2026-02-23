using AutoMapper;
using Learnify.BLL.Interfaces;
using Learnify.DAL.Interfaces;
using Learnify.Domain.Entities;
using Learnify.Shared.DTOs.Payment;

public class PaymentService : IPaymentService
{
    private readonly IPaymentRepository _repository;
    private readonly IMapper _mapper;

    public PaymentService(IPaymentRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PaymentForShortResultDto>> GetAllAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<PaymentForShortResultDto>>(entities);
    }

    public async Task<PaymentForResultDto?> GetByIdAsync(long id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity == null ? null : _mapper.Map<PaymentForResultDto>(entity);
    }

    public async Task<PaymentForResultDto> CreateAsync(PaymentForCreateDto dto)
    {
        var entity = _mapper.Map<Payment>(dto);
        await _repository.AddAsync(entity);
        await _repository.SaveChangesAsync();

        return _mapper.Map<PaymentForResultDto>(entity);
    }
}