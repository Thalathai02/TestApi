using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using backend.Module.S3Module.Repository;
using System.Threading.Tasks;

namespace backend.Module.S3;

[ApiController]
[Route("[controller]")]
public class S3Controller : ControllerBase
{
    private readonly ILogger<S3Controller> _logger;
    private readonly IS3Repository _s3Repository;
    private readonly IMapper _mapper;

    public S3Controller(ILogger<S3Controller> _logger, IS3Repository _S3Repository, IMapper _mapper)
    {
        _logger = _logger;
        _s3Repository = _S3Repository;
        _mapper = _mapper;
    }
    [HttpPost("S3PreSigned")]
    public async Task<S3Model.Response> S3PreSigned(S3Model.Request request)
    {
        var response = await _s3Repository.UploadFile(request);
        return response;
    }

}