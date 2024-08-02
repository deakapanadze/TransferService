using AutoMapper;
using TransferServiceWebAPI.Models;
using ShareModels;
namespace TransferServiceWebAPI.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile() { 
            CreateMap<Transfer, TransferDto > ();
            CreateMap<CreateTransferDto, Transfer>();

        
        
        }
    }
}
