using AutoMapper;
using EKitap.App.Models.DTOs.Yazar;
using EKitap.Dom.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKitap.App.Services.YazarService
{
    public class YazarService : IYazarService
    {
        private readonly IYazarRepository _yazarRepository;
        private readonly IMapper _mapper;

        public YazarService(IYazarRepository yazarRepository, IMapper mapper)
        {
            _yazarRepository = yazarRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Yazar_DTO>> TumMarkalarAsync()
        {
            List<Yazar_DTO> yazarlarDTO = new List<Yazar_DTO>();
            var yazarlar = await _yazarRepository.TumunuListeleAsync();
            _mapper.Map(yazarlar, yazarlarDTO);
            return yazarlarDTO;
        }
    }
}
