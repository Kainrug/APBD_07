using FluentValidation;
using APBD_7.DTO;
using APBD_7.Services;

namespace APBD_7.Validators;

public class CreateProductWarehouseValidator : AbstractValidator<CreateProductWarehouseDto>
{
    public CreateProductWarehouseValidator()
    {
        RuleFor(e => e.IdProduct).NotNull();
        RuleFor(e => e.IdWarehouse).NotNull();
        RuleFor(e => e.Amount).NotNull();
        RuleFor(e => e.CreatedAt).NotNull();
    }
}