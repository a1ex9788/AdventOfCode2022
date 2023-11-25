using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2022.Day02
{
    public class Day02Solver : IDaySolver
    {
        private readonly IList<string> rounds;

        public Day02Solver(string input)
        {
            this.rounds = input.Split("\r\n").ToList();
        }

        public string SolvePart1()
        {
            IList<(Bid Opponent, Bid Me)> parsedRounds = new List<(Bid Opponent, Bid Me)>();

            foreach (string round in this.rounds)
            {
                GroupCollection matchGroups =
                    Regex.Match(round, @"([A-Z]) ([A-Z])").Groups;

                Bid opponent = Helper.GetOpponentBid(matchGroups[1].Value);
                Bid me = Helper.GetMyBidByOrderCriteria(matchGroups[2].Value);

                parsedRounds.Add((opponent, me));
            }

            return GetScore(parsedRounds).ToString();
        }

        public string SolvePart2()
        {
            IList<(Bid Opponent, Bid Me)> parsedRounds = new List<(Bid Opponent, Bid Me)>();

            foreach (string round in this.rounds)
            {
                GroupCollection matchGroups =
                    Regex.Match(round, @"([A-Z]) ([A-Z])").Groups;

                Bid opponent = Helper.GetOpponentBid(matchGroups[1].Value);
                Bid me = Helper.GetMyBidByResultCriteria(opponent, matchGroups[2].Value);

                parsedRounds.Add((opponent, me));
            }

            return GetScore(parsedRounds).ToString();
        }

        private static long GetScore(IList<(Bid Opponent, Bid Me)> rounds)
        {
            long score = 0;

            foreach ((Bid opponent, Bid me) in rounds)
            {
                score += Helper.GetRoundScore(opponent, me);
            }

            return score;
        }
    }
}