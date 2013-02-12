﻿@{
    Func<ModelMetadata, bool> isPropertyBool = (meta) =>
    {
        return meta.ModelType == typeof(bool) || meta.ModelType == typeof(bool?);
    };
}

@foreach (var prop in ViewData.ModelMetadata.Properties.Where(pm => pm.ShowForEdit && !ViewData.TemplateInfo.Visited(pm)))
{
    if (prop.HideSurroundingHtml)
    {
    <text>@Html.Hidden(prop.PropertyName)</text>
    }
    else
    {
        
    <div class="control-group">

        @if (isPropertyBool(prop))
        {
            <div class="controls">
                <label class="checkbox">
                    @Html.Editor(prop.PropertyName)
                    @prop.GetDisplayName()
                </label>
            </div>

        }
        else
        {
            <label class="control-label">
                @prop.GetDisplayName()
                @if(prop.IsRequired)
                {
                    <span class="required">*</span>
                }
            </label>
            <div class="controls">
                @Html.Editor(prop.PropertyName)
                @Html.ValidationMessage(prop.PropertyName, new { @class = "help-inline" })
            </div>
        }

    </div>                 
    }
}