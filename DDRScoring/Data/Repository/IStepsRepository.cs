using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository
{
    public interface IStepsRepository : IDDRScoringRepository<Steps>
    {
        /// <summary>
        /// StepsByPlayer
        /// 
        /// Recupere tous les steps de tous les songs
        /// du joueur.
        /// </summary>
        /// <param name="songs"></param>
        /// <returns>List de step</returns>
        IList<Steps> StepsBySongs(IList<Song> songs);
    }
}
