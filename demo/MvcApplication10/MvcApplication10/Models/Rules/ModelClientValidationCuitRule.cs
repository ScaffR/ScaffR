namespace MvcApplication10.Models.Rules
{
    using System.Web.Mvc;

    public class ModelClientValidationCuitRule : ModelClientValidationRule
    {
        public ModelClientValidationCuitRule(string errorMessage, string regex)
        {
            ErrorMessage = errorMessage;
            ValidationType = "regex";
            ValidationParameters["pattern"] = regex;
        }
    }
}