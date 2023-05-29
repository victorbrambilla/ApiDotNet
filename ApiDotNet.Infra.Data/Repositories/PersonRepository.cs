﻿using ApiDotNet.Domain.Entities;
using ApiDotNet.Domain.FiltersDb;
using ApiDotNet.Domain.Repositories;
using ApiDotNet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiDotNet.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _db;

        public PersonRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Person> CreateAsync(Person person)
        {
            _db.Add(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task DeleteAsync(Person person)
        {
            _db.Remove(person);
            await _db.SaveChangesAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _db.People.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> GetIdByDocumentAsync(string document)
        {
            return (await _db.People.FirstOrDefaultAsync(x => x.Document == document))?.Id ?? 0;
        }

        public async Task<PagedBaseResponse<Person>> GetPagedAsync(PersonFilterDb request)
        {
            var people = _db.People.AsQueryable();
            // print the name 
            System.Console.WriteLine(!string.IsNullOrEmpty(request.Name));

            if (!string.IsNullOrEmpty(request.Name)) 
                people = people.Where(x => x.Name.ToLower().Contains(request.Name.ToLower()));

            return await PagedBaseResponseHelper.GetResponseAsync<PagedBaseResponse<Person>, Person>(people, request);
                
        }

        public async Task<ICollection<Person>> GetPeopleAsync()
        {
            return await _db.People.ToListAsync();
        }

        public async Task UpdateAsync(Person person)
        {
            _db.Update(person);
            await _db.SaveChangesAsync();
        }
    }
}