﻿using System;
using System.IO;
using System.Text;
using GildedRoseTavern;
using Xunit;

namespace GildedRoseTests
{
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            var lines = File.ReadAllLines("ThirtyDays.txt");

            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            var outputLines = output.Split(Environment.NewLine);
            for (var i = 0; i < Math.Min(lines.Length, outputLines.Length); i++)
            {
                Assert.Equal(lines[i], outputLines[i]);
            }
        }
    }
}
