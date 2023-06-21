using AlquileresAutos.Models;

namespace AlquileresAutos.Services
{
    public class ProvinciaService
    {
        public bool HayLocalidadesAsociadas(Provincia provincia)
        {
            if (provincia.Localidades.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
