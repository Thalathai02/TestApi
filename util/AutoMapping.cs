using AutoMapper;
using backend.Models;
using backend.ViewModels;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        // CreateMap<RegisterViewModel, User>(); // map from RegisterViewModel to Users
        CreateMap<TbProduct, TbProductViewModel>(); // map from UserViewModel to Users


    }
}
