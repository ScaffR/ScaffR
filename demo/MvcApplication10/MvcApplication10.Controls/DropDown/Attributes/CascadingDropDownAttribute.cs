namespace MvcApplication10.Controls.DropDown.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class CascadingDropDownAttribute : DropDownAttribute
    {
        public CascadingDropDownAttribute(string parentName, string methodName, params object[] arguments) : 
            this(parentName, methodName, false, arguments)
        {            
        }

        public CascadingDropDownAttribute(string parentName, string methodName, bool heirarchy, params object[] arguments) : base(methodName, arguments)
        {
            RequireHeirarchy = heirarchy;
            ParentName = parentName;
        }

        public IEnumerable<SelectListItem> GetMethodResult(object[] parentValues)
        {
            var serviceInstance = Activator.CreateInstance(_serviceType);
            var methodInfo = _serviceType.GetMethod(_methodName);

            return methodInfo.Invoke(serviceInstance, parentValues) as IEnumerable<SelectListItem>;
        } 

        public bool RequireHeirarchy { get; set; }

        public string ParentName { get; set; }

        public override void OnMetadataCreated(ModelMetadata metadata)
        {
            metadata.AdditionalValues.Add("parentName", ParentName);
            metadata.AdditionalValues.Add("methodName", _methodName);
            metadata.AdditionalValues.Add("heirarchy", RequireHeirarchy);

            base.OnMetadataCreated(metadata);
        }
    }
}