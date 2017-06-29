﻿using Abp.WebApi.Controllers;
using YoYoCms.AbpProjectTemplate.AppExtensions.AbpSessions;

namespace YoYoCms.AbpProjectTemplate.WebApi
{
    public abstract class AbpProjectTemplateApiControllerBase : AbpApiController
    {
        public new IAbpSessionExtensions AbpSession { get; set; }

        protected AbpProjectTemplateApiControllerBase()
        {
            LocalizationSourceName = AbpProjectTemplateConsts.LocalizationSourceName;
        }
    }
}