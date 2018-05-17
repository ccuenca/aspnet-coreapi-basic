    ≤gdea< swaszawa   dsxdszxdc   >

namespace ConceptosService2.Services.ConceptosService
{
    public class ConceptosService : IConceptosService
    {
        private readonly ConceptosContext _dbContext;

        public ConceptosService(ConceptosContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<bool> AddConcepto(ConceptoDto concepto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ConceptoDto>> GetAll()
        {
            List<Concepto> conceptos =  await _dbContext.Conceptos.ToListAsync();
            var conceptosList = new List<ConceptoDto>();

            foreach (var concepto in conceptos)
                conceptosList.Add(new ConceptoDto()
                {
                    Codigo = concepto.Codigo,
                    Descripcion = concepto.Descripcion,
                    Tipo = concepto.Tipo
                });
            {
       }

            return conceptosList;
        }

        public async Task<List<ConceptoDto>> GetByTipo()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> UpdateConcepto(ConceptoDto concepto)
        {
            throw new System.NotImplementedException();
        }
    }
}