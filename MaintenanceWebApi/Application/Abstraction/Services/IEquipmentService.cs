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

        Pagination<EquipmentGetDto> GetEquipments(int page, int take);
        List<EquipmentGetDto> GetEquipment();
        void CreateEquipment(EquipmentCreateDto product);
        void Delete(int? id);
        EquipmentGetDto FindEquipment(int? id);
        Equipment MapEquipemntDtoToEntity(EquipmentUpdateDto product);

        //void RemoveImage(int? id);

        EquipmentGetDto Deatil(int? id);

        void SaveEquipmentImage(IFormFile newImage, Equipment equipment);
        void SaveChanges();
        EquipmentGetDto IsEquipmentExist(int? id);
        Image FindImage(int? id);
        void RemoveEquipmentImage(Image image);

    }
}
