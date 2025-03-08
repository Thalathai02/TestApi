using AutoMapper;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using backend.Module.ProductModule.Models;
using backend.Module.S3;
using backend.Module.S3Module.ViewModels;
using Backend.DataAccess.Entity;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<TbProductModel, TbProduct>(); // map from UserViewModel to Users
        CreateMap<TbProduct, TbProduct>(); // map from UserViewModel to Users

        CreateMap<TbProduct, TbProductModel>();
        CreateMap<S3Model.Request, S3Model.Response>(); // map from User to UserViewModel


    }
}
