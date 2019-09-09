using Shop.Infrastructure.EFDataContext;
using Shop.Services.Interfaces.Handlers;
using Shop.Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services.implementation
{
    public class EFCanalesHandler : ICanalesHandler
    {
        //public IEnumerable<RegisteredCanales> GetAllCanales()
        //{
        //    using (var db = new ShopDb())
        //    {
        //        return db.Canales.ToList().Select(x => new RegisteredCanales
        //        {
        //            Plan = x.Plan,
        //            HD = x.HD,
        //            SD = x.SD,
        //            Audio = x.Audio
        //        });
        //    }
        //}
        public IEnumerable<RegisteredGenero> GetAllGenero()
        {
            using (var db = new ShopDb())
            {
                //EFContext.TestAddresses.Select(m => m.Name).Distinct();


                return db.Generos.ToList().Select(x => new RegisteredGenero
                {
                    Genero = x.GeneroCanal
                });
            }
        }

        public IEnumerable<RegisteredCanalesTotal> GetCanalesByCategory(string category)
        {
            using (var db = new ShopDb())
            {
                return db.CanalesTotal
                         .Where(x => x.GENERO.Equals(category))
                         .ToList()
                         .Select(x => new RegisteredCanalesTotal
                         {
                             TECNOLOGIA = x.TECNOLOGIA,
                             DEFINICION = x.DEFINICION,
                             GENERO = x.GENERO,
                             NUMERO_CANAL = x.NUMERO_CANAL,
                             NUMERO_CANAL2 = x.NUMERO_CANAL2,
                             OBSERVACIONES = x.OBSERVACIONES,
                             NOMBRE_CANAL = x.NOMBRE_CANAL,
                             Claro_HDTV_Basico = x.Claro_HDTV_Basico,
                             Claro_HDTV_Avanzado = x.Claro_HDTV_Avanzado,
                             Claro_HDTV_Superior = x.Claro_HDTV_Superior,

                             Paquete_HBO = x.Paquete_HBO,
                             Paquete_Fox_Premium = x.Paquete_Fox_Premium,
                             Canal_NHK = x.Canal_NHK,
                             HotPack_HD = x.HotPack_HD,
                             ADRENALINA_SPORTS_NETWORK = x.ADRENALINA_SPORTS_NETWORK,
                             Golden_Premier = x.Golden_Premier,
                             nombreCanal = x.nombreCanal
                         });
            }
        }

        public IEnumerable<RegisteredCanales> GetAllCanales()
        {
            using (var db = new ShopDb())
            {
                return db.Canales
                         .ToList()
                         .Select(x => new RegisteredCanales
                         {
                             Plan = x.Plan,
                             HD = x.HD,
                             SD = x.SD,
                             Audio = x.Audio,
                             Total = x.Total
                         });
            }
        }
        public IEnumerable<RegisteredCanalesPlus> GetAllCanalesPlus()
        {
            using (var db = new ShopDb())
            {
                return db.CanalesPlus
                         .ToList()
                         .Select(x => new RegisteredCanalesPlus
                         {
                             Plan = x.Plan,
                             HD = x.HD,
                             SD = x.SD,
                             Total = x.Total
                         });
            }
        }

        public IEnumerable<RegisteredCanalesTotal> GetAllCanalesTotal()
        {
            using (var db = new ShopDb())
            {
                return db.CanalesTotal
                         .ToList()
                         .Select(x => new RegisteredCanalesTotal
                         {
                             TECNOLOGIA = x.TECNOLOGIA,
                             DEFINICION = x.DEFINICION,
                             GENERO = x.GENERO,
                             NUMERO_CANAL = x.NUMERO_CANAL,
                             NUMERO_CANAL2 = x.NUMERO_CANAL2,
                             OBSERVACIONES = x.OBSERVACIONES,
                             NOMBRE_CANAL = x.NOMBRE_CANAL,
                             Claro_HDTV_Basico = x.Claro_HDTV_Basico,
                             Claro_HDTV_Avanzado = x.Claro_HDTV_Avanzado,
                             Claro_HDTV_Superior = x.Claro_HDTV_Superior,

                             Paquete_HBO = x.Paquete_HBO,
                             Paquete_Fox_Premium = x.Paquete_Fox_Premium,
                             Canal_NHK = x.Canal_NHK,
                             HotPack_HD = x.HotPack_HD,
                             ADRENALINA_SPORTS_NETWORK = x.ADRENALINA_SPORTS_NETWORK,
                             Golden_Premier = x.Golden_Premier,
                             nombreCanal = x.nombreCanal
                         });
            }
        }
    }
}

