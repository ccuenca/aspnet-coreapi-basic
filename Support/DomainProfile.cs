using AutoMapper;
using ConceptosService2.Domain;
using ConceptosService2.Dto;
using ConceptosService2.Persistence.Models;

namespace ConceptosService2.Support
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<prcConceptos_Model, ConceptoDto>()
                .ForMember( dest => dest.Codigo , opt => opt.MapFrom( src => src.conCodigo.Trim()))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.conNombre.Trim()))
                .ForMember(dest => dest.Tipo, opt => opt.MapFrom(src => src.conTipo.Trim()));

            //CreateMap<prcConceptos_Model, Concepto>();
        }
    }
}
