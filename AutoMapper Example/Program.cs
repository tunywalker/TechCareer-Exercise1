
using AutoMapper;
using AutoMapper_Example.Data;
using AutoMapper_Example.Model;
using AutoMapper_Example.Services;




var userService = new UserService(new UserRepository(), new AutoMapperService());

userService.GetById(1);//1 Numaralı Id'ye sahip Kullanıcı bilgilerini yazdırır.
userService.ViewProfile(1);//1 Numaralı Id'ye sahip Name, Username, Description alanlarını yazdırır.
