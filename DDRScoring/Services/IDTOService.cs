using DDRScoring.Data.DTO;
using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Services
{
    public interface IDTOService
    {
        Data.Entities.Player DTOStatsToEntitiesPlayer(Data.DTO.Stats stats, StoreUser user);
    }
}
