﻿namespace MvcApplication10.Controls.DropDown.Extensions
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    public static class MetadataExtensions
    {
        public static ModelMetadata BuildDropdownListenerAttributes(this ModelMetadata metadata, TemplateInfo templateInfo, ref IDictionary<string, object> attributes)
        {            
            if (metadata.AdditionalValues.ContainsKey("dropdownlistener"))
            {
                var parentName = metadata.AdditionalValues["dropdownlistener-parent"].ToString();

                var id = templateInfo.GetFullHtmlFieldId(parentName);

                attributes.Add("data-dropdownlistener", true);
                attributes.Add("data-dropdownlistener-parent", parentName);
                attributes.Add("data-dropdownlistener-callback", metadata.AdditionalValues["dropdownlistener-callback"]);
            }

            return metadata;
        }

        public static ModelMetadata BuildDropdownListenerWithSpecificValue(this ModelMetadata metadata, TemplateInfo templateInfo, ref IDictionary<string, object> attributes)
        {
            if (metadata.AdditionalValues.ContainsKey("dropdownlistenerwithspecificvalue"))
            {
                var parentName = metadata.AdditionalValues["dropdownlistenerwithspecificvalue-parent"].ToString();

                var id = templateInfo.GetFullHtmlFieldId(parentName);

                attributes.Add("data-dropdownlistenerwithspecificvalue", true);
                attributes.Add("data-dropdownlistenerwithspecificvalue-match", metadata.AdditionalValues["dropdownlistenerwithspecificvalue-match"]);
                attributes.Add("data-dropdownlistenerwithspecificvalue-parent", parentName);
                attributes.Add("data-dropdownlistenerwithspecificvalue-callback", metadata.AdditionalValues["dropdownlistenerwithspecificvalue-callback"]);
            }

            return metadata;
        }

        public static ModelMetadata GetValue(this ModelMetadata metadata, string value, ref IDictionary<string, object> attrs)
        {
            if (metadata.AdditionalValues.ContainsKey(value))
            {
                attrs.Add(value, true);
            }
            return metadata;
        }
    }
}
