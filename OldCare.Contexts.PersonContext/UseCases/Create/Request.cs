using OldCare.Contexts.SharedContext.UseCases;
using MediatR;
using OldCare.Contexts.SharedContext.ValueObjects;

namespace OldCare.Contexts.PersonContext.UseCases.Create;

public class Request : IRequest<BaseResponse<ResponseData>>
{
    public string ZipCode { get; set; } = string.Empty;
    public string AddressNumber { get; set; } = string.Empty;
    public string Complement { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public List<Document?> Documents { get; set; } = new();
    public DateTime BirthDate { get; set; }
    public string Nationality { get; set; } = string.Empty;
    public string Citizenship { get; set; } = string.Empty;
    public bool Gender { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Obs { get; set; } = string.Empty;

    public string FullNumber { get; set; } = string.Empty;
    public string Photo { get; set; } = string.Empty;
}