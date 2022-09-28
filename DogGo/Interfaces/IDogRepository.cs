using DogGo.Models;

namespace DogGo.Interfaces
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        Dog? GetDogById(int id);
        List<Dog> GetDogByOwnerId(int ownerId);
        void AddDog(Dog dog);
        void UpdateDog(Dog dog);
        void DeleteDog(int id);

    }
}
