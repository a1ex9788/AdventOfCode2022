using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2022.Day02
{
    public class Day02Solver : IDaySolver
    {
        private readonly IList<string> rounds;

        public Day02Solver(string input)
        {
            this.rounds = input.Split("\r\n").ToList();
        }

        public long SolvePart1()
        {
            IList<(Bid Opponent, Bid Me)> parsedRounds = new List<(Bid Opponent, Bid Me)>();

            foreach (string round in this.rounds)
            {
                string[] bids = round.Split(' ');

                Bid opponent = Helper.GetOpponentBid(char.Parse(bids[0]));
                Bid me = Helper.GetMyBidByOrderCriteria(char.Parse(bids[1]));

                parsedRounds.Add((opponent, me));
            }

            return GetScore(parsedRounds);
        }

        public long SolvePart2()
        {
            IList<(Bid Opponent, Bid Me)> parsedRounds = new List<(Bid Opponent, Bid Me)>();

            foreach (string round in this.rounds)
            {
                string[] bids = round.Split(' ');

                Bid opponent = Helper.GetOpponentBid(char.Parse(bids[0]));
                Bid me = Helper.GetMyBidByResultCriteria(opponent, char.Parse(bids[1]));

                parsedRounds.Add((opponent, me));
            }

            return GetScore(parsedRounds);
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