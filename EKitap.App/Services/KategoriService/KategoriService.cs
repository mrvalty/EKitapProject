using AutoMapper;
using EKitap.App.Models.DTOs.Kategori;
using EKitap.Dom.Repositories;
using EKitap.Domain.Models;

namespace EKitap.App.Services.KategoriService
{
    public class KategoriService : IKategoriService
    {
        private readonly IKategoriRepository _kategoriRepository;
        private readonly IMapper _mapper;

        public KategoriService(IKategoriRepository kategoriRepository, IMapper mapper)
        {
            _kategoriRepository = kategoriRepository;
            _mapper = mapper;
        }

        public async Task<List<Kategori>> GetAll()
        {
            var kategoriler = _kategoriRepository.GetAll();
            return kategoriler;
        }

        public async Task<IEnumerable<Kategori_DTO>> TumKategorilerAsync()
        {
            List<Kategori_DTO> kategorilerDTO = new List<Kategori_DTO>();
            var kategoriler = await _kategoriRepository.TumunuListeleAsync();
            _mapper.Map(kategoriler, kategorilerDTO);
            return kategorilerDTO;
        }
    }
}
