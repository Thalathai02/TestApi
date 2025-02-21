
using backend.Module.S3;

namespace backend.Module.S3Module.Repository
{
    public interface IS3Repository
    {

        Task<S3Model.Response> UploadFile(S3Model.Request request);

    }
}
