using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminDashboard.Entities.Models;
using AdminDashboard.Service.ModelDTO;
using AutoMapper;

namespace AdminDashboard.Web.Mvc.Mappings
{
    public class ModelToDomainMapppingProfile : Profile
    {
        public override string ProfileName { get { return "ModelToDomainMappings"; } }
        protected override void Configure()
        {
            var config = new MapperConfiguration(cfg=> { cfg.CreateMap<PersonDTO,Person>(); });

        }
    }
}