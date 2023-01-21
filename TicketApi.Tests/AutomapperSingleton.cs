using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApi.Configuration;

namespace TicketApi.Tests
{
    public class AutomapperSingleton
    {
        private static IMapper _mapper;
        public static IMapper Mapper
        {
            get
            {
                if (_mapper == null)
                {
                    // Auto Mapper Configurations
                    var mappingConfig = new MapperConfiguration(mc =>
                    {
                        mc.AddProfile(new MapperInitlizer());
                    });

                    IMapper mapper = mappingConfig.CreateMapper();
                    _mapper = mapper;
                }

                return _mapper;
            }
        }
    }
}
