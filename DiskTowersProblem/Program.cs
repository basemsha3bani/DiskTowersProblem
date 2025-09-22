
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;
using InfraStructure.Persistence;
using DiskTower.Application.Features.TestTower.Commands;
using DiskTower.Application.Features.TestTower.Commands.CreateDisk.DTOS;
using System.Drawing;
using System.Threading.Tasks;
class program
{
    static async Task Main(string[] args)
    {

       await Start();
    }
    static async Task Start()
    {
       var services= CreateService();
        Application app = services.GetRequiredService<Application>();
     string result= await  app.CreateDisk();
    }
    static IServiceProvider CreateService()
    {
        return new ServiceCollection()
            .AddCustomServices()
             .AddSingleton(typeof(Application))
             .AddLogging()
            .BuildServiceProvider();
    }
}
public class Application
{
    CreateDiskCommand _createDiskCommand;
    public Application(CreateDiskCommand createDiskCommand)
    {

        _createDiskCommand = createDiskCommand;
    }
   public async Task<string> CreateDisk()
    {


        DiskTowerDto towerDto = new DiskTowerDto();
        towerDto.numberOfDisks = 3;
        towerDto.disks = new List<DiskDto>()
        {
            new DiskDto() { size = 3},
            new DiskDto() { size = 0},
            new DiskDto() { size = 1}
};
      return  await _createDiskCommand.CreateDisk(towerDto);
    }
}








