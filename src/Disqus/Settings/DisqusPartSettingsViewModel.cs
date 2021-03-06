﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Disqus.OrchardCore.Settings
{
    public class DisqusPartSettingsViewModel
    {
        public string ShortName { get; set; }

        [BindNever]
        public DisqusPartSettings DisqusPartSettings { get; set; }
    }
}
