





using ZooProject.Business;
using ZooProject.Data;
using ZooProject.Models;

Console.WriteLine("Tech Career -> Zoo Exercise");

IZooService _zooService = new ZooService(new ZooRepository());
_zooService.GetList();
_zooService.Delete(1);
_zooService.Add(new Zoo() { Id = 7, Location = "Malatya/Yeşilyurt", Name = "Yeşilyurt Kuş Cenneti" });
_zooService.GetList();
_zooService.GetByName("Bulamayacaksın");
_zooService.GetById(-99);
_zooService.Add(new Zoo() { Id = 888, Location = "Mozambik", Name = "xx" });

