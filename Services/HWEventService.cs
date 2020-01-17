using net_core_bootcamp_b1.DTOs;
using net_core_bootcamp_b1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace net_core_bootcamp_b1.Services
{
    public interface IHWEventService
    {
        public string Add(HWEventAddDto model);
        public string UpDate(HWEventUpDateDto model);
        public string Delete(Guid Id);
        public IList<HWEventGetDto> Get();
    }
    public class HWEventService : IHWEventService
    {
        private static readonly IList<HWEvent> data = new List<HWEvent>();
        public string Add(HWEventAddDto model)
        {
            var entity = new HWEvent
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow
            };
            entity.Name = model.Name;
            entity.StartDate = model.StartDate;
            entity.FinishDate = model.FinishDate;
            entity.Address = model.Address;
            entity.IsFree = model.IsFree;
            entity.Price = model.Price;
            entity.Subject = model.Subject;
            entity.Desc = model.Desc;

            data.Add(entity);
            return model.Name + " Eklendi";
        }

        public string Delete(Guid Id)
        {
            var entity = data.Where(x => x.Id == Id).FirstOrDefault();
            if (entity == null)
            {
                return "ID bulunamadi";
            }
            entity.IsDeleted = true;
            return entity.Name + " silindi";
        }

        public IList<HWEventGetDto> Get()
        {
            var result = new List<HWEventGetDto>();

            result = data
                .Where(x => !x.IsDeleted)
                .Select(s => new HWEventGetDto
                {
                    Id = s.Id,
                    CreatedAt=s.CreatedAt,
                    Name=s.Name,
                    StartDate = s.StartDate,
                    FinishDate = s.FinishDate,
                    Address = s.Address,
                    IsFree = s.IsFree,
                    Price = s.Price,
                    Subject = s.Subject,
                    Desc = s.Desc,
                })
                .ToList();
                return result;

        }

        public string UpDate(HWEventUpDateDto model)
        {
            var entity = data.Where(x => x.Id == model.Id && x.IsDeleted != true).FirstOrDefault();
            if (entity == null)
            {
                return "ID bulunumadi";
            }
            entity.Name = model.Name;
            entity.StartDate = model.StartDate;
            entity.FinishDate = model.FinishDate;
            entity.Address = model.Address;
            entity.IsFree = model.IsFree;
            entity.Price = model.Price;
            entity.Subject = model.Subject;
            entity.Desc = model.Desc;

            return ($"{entity.Id} Basariyla degistirildi");
        }
    }
}
