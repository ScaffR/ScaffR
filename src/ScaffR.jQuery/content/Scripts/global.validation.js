﻿(function ($) {

    $.validator.setDefaults({
        highlight: function (element) {
            $(element).closest(".control-group").removeClass("success");
            $(element).closest(".control-group").addClass("error");
        },
        unhighlight: function (element) {
            $(element).closest(".control-group").removeClass("error");
            $(element).closest(".control-group").addClass("success");
        }
    });

})(jQuery);