using DDRScoring.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Services
{
    public interface ISaveScoringService
    {
        /// <summary>
        /// SaveAndMergeAsync
        /// Sauvegarde le fichier xml du joueur
        /// </summary>
        /// <param name="stats">Stats</param>
        /// <returns>Nombre de nouveau score engristre</returns>
        Task<int> SaveAndMergeAsync(ClaimsPrincipal userAuthentified, Stats stats);
    }
}
