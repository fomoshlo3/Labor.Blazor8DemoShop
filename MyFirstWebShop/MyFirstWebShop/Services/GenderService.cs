using Microsoft.EntityFrameworkCore;
using MyFirstWebShop.Data;
using MyFirstWebShop.Data.DTOs;
using MyFirstWebShop.Data.Entity;
using System;

namespace MyFirstWebShop.Services
{
    public class GenderService : IGenderService
    {

        private ApplicationDbContext _context;

        public GenderService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddGender(GenderDetailDTO gender)
        {
            _context.Genders.Add(new Gender()
            {
                Title = gender.Title,
                Notes = gender.Notes,
            });
        }

        public void DeleteGender(Gender gender)
        {
            _context.Genders.Remove(gender);
        }

        public void DeleteGenderById(int id)
        {
            Gender? g = _context.Genders.FirstOrDefault(w => w.GenderId == id);
            if (g != null)
            {
                _context.Remove(g);
            }
        }

        public async Task<List<GenderSelectDTO>> GetAllGenderSelectDTOAsync()
        {
            return await (from x in _context.Genders
                          orderby x.Title
                          select new GenderSelectDTO()
                          {
                              GenderId = x.GenderId,
                              Title = x.Title
                          }).AsNoTracking().ToListAsync();
        }

        public async Task<GenderDetailDTO?> GetGenderDetailDTOByIdAsync(int id)
        {
            return await (from x in _context.Genders
                          orderby x.Title
                          select new GenderDetailDTO()
                          {
                              GenderId = x.GenderId,
                              Title = x.Title,
                              Notes = x.Notes
                          }).FirstOrDefaultAsync();
        }

        public GenderSelectDTO? GetGenderSelectDTOById(int id)
        {
            return (from x in _context.Genders
                    where x.GenderId == id
                    select new GenderSelectDTO()
                    {
                        GenderId = x.GenderId,
                        Title = x.Title,
                    }).FirstOrDefault();
        }

        public void UpdateGender(GenderDetailDTO gender)
        {

            Gender? g = _context.Genders.FirstOrDefault(x => x.GenderId == gender.GenderId);
            if (g != null)
            {
                g.Title = gender.Title;
                g.Notes = gender.Notes;
                _context.Genders.Update(g);
            }

        }
    }
}
