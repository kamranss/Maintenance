using Application.Abstraction.Contracts;
using Application.DTOs.Department;
using Application.DTOs.Equipment;
using Application.RequestParameters;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Application.Abstraction.Services
{
    public interface IEquipmentService
    {
        Task<byte[]> QrCodeToEquipmentAsync(string equipmentId);
        Task StockUpdateToEquipmentAsync(string equipmentId, int stock);

        Task<IServiceResult<Pagination<EquipmentListDto>>> GetEquipmentsAsync(int? page, int? take);
        //List<EquipmentGetDto> GetEquipment();
        Task<IServiceResult<EquipmentCreateDto>> CreateEquipment(EquipmentCreateDto equipment);

        //void Delete(int? id);
        Task<IServiceResult<EquipmentDto>> DeleteEquipmentAsync(int id);
        //EquipmentGetDto FindEquipment(int? id);
        Task<IServiceResult<EquipmentListDto>> FindEquipmentAsync(int? id);
        //Equipment MapEquipemntDtoToEntity(EquipmentUpdateDto equipment);

        //void RemoveImage(int? id);

        EquipmentGetDto Deatil(int? id);

        void SaveEquipmentImage(IFormFile newImage, Equipment equipment);
        //void SaveChanges();
        //EquipmentGetDto IsEquipmentExist(int? id);
        //Image FindImage(int? id);
        //void RemoveEquipmentImage(Image image);

    }
}
