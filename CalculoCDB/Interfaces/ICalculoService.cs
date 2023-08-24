using CalculoCDB.Domain;

namespace CalculoCDB.Interfaces
{
    public interface ICalculoService
    {
        Resultado CalculaCDB(Calculo calculo);
    }
}
