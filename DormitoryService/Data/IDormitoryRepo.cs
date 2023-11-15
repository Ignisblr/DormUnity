using DormitoryService.Models;

namespace DormitoryService.Data
{
    public interface IDormitoryRepo
    {
        bool SaveChanges();

        ICollection<Dormitory> GetDormitories();
        
        Dormitory GetDormitoryById(int id);

        // Dormitory GetDormitoryByName(string name);

        void AddDormitory(Dormitory dormitory);
    }
}