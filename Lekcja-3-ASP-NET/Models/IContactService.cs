using Microsoft.AspNetCore.Mvc;

namespace Lekcja_3_ASP_NET.Models
{
    public interface IContactService
    {
        void Add(Contact contact);
        void RemoveById(int id);
        void Update(Contact contact);
        List<Contact> FindAll();
        Contact? Find(int id);
    }
}