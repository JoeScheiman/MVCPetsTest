using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCVirtualPets.Models;

namespace MVCVirtualPets.Repositories
{
    public class PetRepository
    {
        public Dictionary<int, Pet> petz = new Dictionary<int, Pet>()
        {
            {1, new Pet() { Id = 1, Name = "Dex"}},
            {2, new Pet() { Id = 2, Name = "Jameson" } },
            {3, new Pet() { Id = 3, Name = "Molly" } }
        };

        public IEnumerable<Pet> GetAll()
        {
            return petz.Values.ToList();
        }

        public object GetById(int id)
        {
            return petz[id];
        }
        
        
    }
}
