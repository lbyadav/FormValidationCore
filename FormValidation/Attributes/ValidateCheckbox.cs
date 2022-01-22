using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace FormValidation.Attributes

{
    public class ValidateCheckbox: ValidationAttribute, IClientModelValidator
    {
        public void AddValidation(ClientModelValidationContext context)
        {

            context.Attributes.Add("data-val-checkbox", ErrorMessage);
        }
        public override bool IsValid(object? value)
        {
            return (bool)value;

            //if ((bool)value == true)
            //    return true;
            //else
            //    return false;
        }

    }
}
