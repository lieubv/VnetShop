
// Usage: UnitOfWork Pattern
// Dam bao co nhieu thao tac tren cung 1 transaction
// Dam bao su toan ven giua nhieu thao tac
// Dam bao nhieu repository tren 1 connection

namespace VnetShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit(); 
    }
}