using DDRScoring.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDRScoring.Data.Repository
{
    public interface IHighScoreRepository : IDDRScoringRepository<HighScore>
    {
        /// <summary>
        /// HighScoreByHighScoreList
        /// 
        /// Recupere tous les highScores de tous les highScoreList.
        /// </summary>
        /// <param name="highScoreLists"></param>
        /// <returns>List de highscore</returns>
        IList<HighScore> HighScoresByHighScoreList(IList<HighScoreList> highScoreLists);
    }
}
