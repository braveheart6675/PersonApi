using Grpc.Core;
using PersonApi.Protos;
using PersonApi.Models;
using PersonApi.Data;
using Microsoft.EntityFrameworkCore;
using Google.Protobuf.WellKnownTypes;
using System;
using Google.Protobuf;

namespace PersonApi.Services
{
    public class PersonServiceImplementation : PersonService.PersonServiceBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PersonServiceImplementation(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // Create
        public override async Task<PersonResponse> CreatePerson(PersonApi.Protos.Person request, ServerCallContext context)
        {
            var person = new Models.Person
            {
                Name = request.Name,
                FamilyName = request.FamilyName,
                SocialNumber = request.SocialNumber,
            };

            _applicationDbContext.Persons.Add(person);
            await _applicationDbContext.SaveChangesAsync();

            return new PersonResponse { Id = person.Id };
        }

        // Read (by ID)
        public override async Task<PersonApi.Protos.Person> GetPerson(PersonIdRequest request, ServerCallContext context)
        {
            var person = await _applicationDbContext.Persons.FindAsync(request.Id);
            if (person == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Person with ID {request.Id} not found."));
            }

            return new PersonApi.Protos.Person
            {
                Id = person.Id,
                Name = person.Name,
                FamilyName = person.FamilyName,
                SocialNumber = person.SocialNumber,
            };
        }

        // Update
        public override async Task<Empty> UpdatePerson(PersonApi.Protos.Person request, ServerCallContext context)
        {
            var person = await _applicationDbContext.Persons.FindAsync(request.Id);
            if (person == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Person with ID {request.Id} not found."));
            }

            person.Name = request.Name;
            person.FamilyName = request.FamilyName;
            person.SocialNumber = request.SocialNumber;

            await _applicationDbContext.SaveChangesAsync();
            return new Empty();
        }

        // Delete
        public override async Task<Empty> DeletePerson(PersonIdRequest request, ServerCallContext context)
        {
            var person = await _applicationDbContext.Persons.FindAsync(request.Id);
            if (person == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Person with ID {request.Id} not found."));
            }

            _applicationDbContext.Persons.Remove(person);
            await _applicationDbContext.SaveChangesAsync();
            return new Empty();
        }

        // Get All
        public override async Task<PersonList> GetAllPersons(Empty request, ServerCallContext context)
        {
            var people = await _applicationDbContext.Persons.ToListAsync();
            var list = new PersonList();
            list.People.AddRange(people.Select(p => new PersonApi.Protos.Person
            {
                Id = p.Id,
                Name = p.Name,
                FamilyName = p.FamilyName,
                SocialNumber = p.SocialNumber,
                BirthDate = p.BirthDate.ToString()
            }));

            return list;
        }
    }
}
