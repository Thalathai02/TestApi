using AutoMapper;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using backend.Module.ProductModule.Models;
using backend.Module.ProductModule.ViewModels;
using static backend.Module.S3.S3Model;
using backend.Module.S3Module.ViewModels;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<TbProduct, TbProductViewModel>(); // map from UserViewModel to Users
        CreateMap<Request, Response>(); // map from User to UserViewModel


    }
}
