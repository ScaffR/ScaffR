namespace MvcApplication10.Models.Rules
{
    using System.Web.Mvc;

    public class ModelClientValidationDigitsRule : ModelClientValidationRule
    {
        public ModelClientValidationDigitsRule(string errorMessage)
        {
            ErrorMessage = errorMessage;
            ValidationType = "digits";
        }
    }
}