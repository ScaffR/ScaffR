namespace MvcApplication10.Models.Rules
{
    using System.Web.Mvc;

    public class ModelClientValidationDateRule : ModelClientValidationRule
    {
        public ModelClientValidationDateRule(string errorMessage)
        {
            ErrorMessage = errorMessage;
            ValidationType = "date";
        }
    }
}