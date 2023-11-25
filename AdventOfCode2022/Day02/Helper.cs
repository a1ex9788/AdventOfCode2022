using System;

namespace AdventOfCode2022.Day02
{
    internal static class Helper
    {
        internal static Bid GetOpponentBid(string bid)
        {
            return bid switch
            {
                "A" => Bid.Rock,
                "B" => Bid.Paper,
                "C" => Bid.Scissors,
                _ => throw new NotSupportedException(),
            };
        }

        internal static Bid GetMyBidByOrderCriteria(string bid)
        {
            return bid switch
            {
                "X" => Bid.Rock,
                "Y" => Bid.Paper,
                "Z" => Bid.Scissors,
                _ => throw new NotSupportedException(),
            };
        }

        internal static Bid GetMyBidByResultCriteria(Bid opponent, string me)
        {
            if (me == "Y")
            {
                return opponent;
            }

            if (me == "X")
            {
                return opponent switch
                {
                    Bid.Rock => Bid.Scissors,
                    Bid.Paper => Bid.Rock,
                    Bid.Scissors => Bid.Paper,
                    _ => throw new NotSupportedException(),
                };
            }

            if (me == "Z")
            {
                return opponent switch
                {
                    Bid.Rock => Bid.Paper,
                    Bid.Paper => Bid.Scissors,
                    Bid.Scissors => Bid.Rock,
                    _ => throw new NotSupportedException(),
                };
            }

            throw new NotSupportedException();
        }

        internal static int GetRoundScore(Bid opponent, Bid me)
        {
            int score = (int)me;

            if (opponent == me)
            {
                score += 3;
            }
            else if (WinForMe(opponent, me))
            {
                score += 6;
            }

            return score;
        }

        private static bool WinForMe(Bid opponent, Bid me)
        {
            return (opponent == Bid.Rock && me == Bid.Paper)
                || (opponent == Bid.Paper && me == Bid.Scissors)
                || (opponent == Bid.Scissors && me == Bid.Rock);
        }
    }
}