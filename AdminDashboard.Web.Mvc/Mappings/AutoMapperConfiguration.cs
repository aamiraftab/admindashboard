using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace AdminDashboard.Web.Mvc.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DomainToModelMappingProfile>();
                cfg.AddProfile<ModelToDomainMapppingProfile>();
            });

            var mapper = config.CreateMapper();
        }
    }
}