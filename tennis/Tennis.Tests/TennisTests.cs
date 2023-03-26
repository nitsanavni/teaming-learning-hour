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
            var game = GameDriver.ForTennis1();

            game.WonPoints(p1, p2);

            Assert.Equal(expected, game.GetScore());
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis2Test(int p1, int p2, string expected)
        {
            var game = GameDriver.ForTennis2();

            game.WonPoints(p1, p2);

            Assert.Equal(expected, game.GetScore());
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void Tennis3Test(int p1, int p2, string expected)
        {
            var game = GameDriver.ForTennis3();

            game.WonPoints(p1, p2);

            Assert.Equal(expected, game.GetScore());
        }

        private class GameDriver
        {
            private readonly ITennisGame game;

            public static GameDriver ForTennis1()
            {
                return new GameDriver((a, b) => new TennisGame1(a, b));
            }

            public static GameDriver ForTennis2()
            {
                return new GameDriver((a, b) => new TennisGame2(a, b));
            }

            public static GameDriver ForTennis3()
            {
                return new GameDriver((a, b) => new TennisGame3(a, b));
            }

            public GameDriver(Func<string, string, ITennisGame> makeGame)
            {
                game = makeGame("player1", "player2");
            }

            public string GetScore() => game.GetScore();

            public void WonPoints(int player1Points, int player2Points)
            {
                Repeat(times: player1Points, action: () => game.WonPoint("player1"));
                Repeat(times: player2Points, action: () => game.WonPoint("player2"));
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