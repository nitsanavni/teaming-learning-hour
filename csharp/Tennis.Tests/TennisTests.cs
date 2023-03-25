using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Tennis.Tests
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {0, 0, "Love-All"},
            new object[] {1, 1, "Fifteen-All"},
            new object[] {2, 2, "Thirty-All"},
            new object[] {3, 3, "Deuce"},
            new object[] {4, 4, "Deuce"},
            new object[] {1, 0, "Fifteen-Love"},
            new object[] {0, 1, "Love-Fifteen"},
            new object[] {2, 0, "Thirty-Love"},
            new object[] {0, 2, "Love-Thirty"},
            new object[] {3, 0, "Forty-Love"},
            new object[] {0, 3, "Love-Forty"},
            new object[] {4, 0, "Win for player1"},
            new object[] {0, 4, "Win for player2"},
            new object[] {2, 1, "Thirty-Fifteen"},
            new object[] {1, 2, "Fifteen-Thirty"},
            new object[] {3, 1, "Forty-Fifteen"},
            new object[] {1, 3, "Fifteen-Forty"},
            new object[] {4, 1, "Win for player1"},
            new object[] {1, 4, "Win for player2"},
            new object[] {3, 2, "Forty-Thirty"},
            new object[] {2, 3, "Thirty-Forty"},
            new object[] {4, 2, "Win for player1"},
            new object[] {2, 4, "Win for player2"},
            new object[] {4, 3, "Advantage player1"},
            new object[] {3, 4, "Advantage player2"},
            new object[] {5, 4, "Advantage player1"},
            new object[] {4, 5, "Advantage player2"},
            new object[] {15, 14, "Advantage player1"},
            new object[] {14, 15, "Advantage player2"},
            new object[] {6, 4, "Win for player1"},
            new object[] {4, 6, "Win for player2"},
            new object[] {16, 14, "Win for player1"},
            new object[] {14, 16, "Win for player2"},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class TennisTests
    {
        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis1Test(int p1, int p2, string expected)
        {
            var game = new GameDriver((p1, p2) => new TennisGame1(p1, p2));

            Assert.Equal(expected, game.GetScore(p1, p2));
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis2Test(int p1, int p2, string expected)
        {
            var game = new GameDriver((p1, p2) => new TennisGame2(p1, p2));

            Assert.Equal(expected, game.GetScore(p1, p2));
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis3Test(int p1, int p2, string expected)
        {
            var game = new GameDriver((p1, p2) => new TennisGame3(p1, p2));

            Assert.Equal(expected, game.GetScore(p1, p2));
        }

        private class GameDriver
        {
            private readonly ITennisGame game;
            public GameDriver(Func<string, string, ITennisGame> makeGame)
            {
                game = makeGame("player1", "player2");
            }

            public string GetScore(int player1points, int player2Points)
            {
                WinPlayersPoints(player1points, player2Points);

                return game.GetScore();
            }

            private void WinPlayersPoints(int player1points, int player2Points)
            {
                WinPoints(player1points, "player1");
                WinPoints(player2Points, "player2");
            }

            private void WinPoints(int points, string name)
            {
                Repeat(times: points, action: () => game.WonPoint(name));
            }

            private void Repeat(int times, Action action)
            {
                for (int i = 0; i < times; i++)
                {
                    action();
                }
            }
        }
    }
}