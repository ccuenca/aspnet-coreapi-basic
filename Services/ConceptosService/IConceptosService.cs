using System.Collections.Generic;
using System.Threading.Tasks;
using ConceptosService2.Services.ConceptosService.Dto;

namespace ConceptosService2.Services.ConceptosService
{
    public interface IConceptosService
    {
         Task<List<ConceptoDto>> GetAll();

         Task<List<ConceptoDto>> GetByTipo();

         Task<bool> AddConcepto(ConceptoDto concepto);

         Task<bool> UpdateConcepto(ConceptoDto concepto);
         
    }
}