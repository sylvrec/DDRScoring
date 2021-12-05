using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository
{
    public interface IHighScoreListRepository : IDDRScoringRepository<HighScoreList>
    {
        /// <summary>
        /// HighScoresBySteps
        /// 
        /// Recupere tous les Higcsores de tous les steps
        /// </summary>
        /// <param name="steps"></param>
        /// <returns>List de HighScoreList</returns>
        IList<HighScoreList> HighScoresListBySteps(IList<Steps> steps);
    }
}
