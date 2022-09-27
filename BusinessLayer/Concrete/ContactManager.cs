using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactdal;

        public ContactManager(IContactDal contactdal)
        {
            _contactdal = contactdal;
        }

        public void AddContact(Contact contact)
        {
            _contactdal.Insert(contact);
        }

        public void DeleteContact(Contact contact)
        {
            _contactdal.Delete(contact);
        }

        public Contact GetByID(int id)
        {
            return _contactdal.Get(x => x.ContactId == id);
        }

        public List<Contact> GetList()
        {
            return _contactdal.List();
        }

        public void UpdateContact(Contact contact)
        {
            _contactdal.Update(contact);
        }
    }
}
