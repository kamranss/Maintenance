using Application.DTOs.Equipment;
using Application.RequestParameters;
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
        List<EquipmentGetDto> GetCategories();
        void CreateEquipment(EquipmentCreateDto product);
        void Delete(int? id);
        EquipmentGetDto FindEquipment(int? id);
        ProductUpdateVM MapProducTotVM(Product product);

        //void RemoveImage(int? id);

        Product Deatil(int? id);

        void SaveProImage(IFormFile newImage, Product product);
        void SaveChanges();
        Product IsProductExist(int? id);
        Image FindImage(int? id);
        void RemoveProImage(Image image);

    }
}
