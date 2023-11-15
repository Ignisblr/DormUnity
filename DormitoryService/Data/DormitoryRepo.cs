using DormitoryService.Models;

namespace DormitoryService.Data
{
    public class DormitoryRepo : IDormitoryRepo
    {
        private readonly AppDbContext _context;

        public DormitoryRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddDormitory(Dormitory dormitory)
        {
            if (dormitory is null) throw new NotImplementedException(nameof(dormitory));

            _context.Dormitories.Add(dormitory);
        }

        public ICollection<Dormitory> GetDormitories()
        {
            return _context.Dormitories.ToList();
        }

        public Dormitory GetDormitoryById(int id)
        {
            return _context.Dormitories.FirstOrDefault(dormitory => dormitory.Id == id);
        }

        // public Dormitory GetDormitoryByName(string name)
        // {
        //    return _context.Dormitories.FirstOrDefault(dormitory => dormitory.Name == name);
        // }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}