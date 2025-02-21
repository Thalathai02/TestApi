using backend.Database;
using backend.Module.S3;

// using backend.Installers;
using AutoMapper;

namespace backend.Module.S3Module.Repository
{
    public class S3Repository : IS3Repository
    {

        private readonly DatabaseContext _context;

        public IMapper Mapper { get; }

        public S3Repository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            Mapper = mapper;
        }


        public async Task<S3Model.Response> UploadFile(S3Model.Request request)
        {
            var s3 = new S3Model.Request
            {
                Id = request.Id,
                Url = request.Url
            };

            // await _context.S3.AddAsync(s3);
            // await _context.SaveChangesAsync();

            return Mapper.Map<S3Model.Response>(s3);
        }

    }

}
