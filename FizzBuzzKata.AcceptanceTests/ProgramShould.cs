﻿using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace FizzBuzzKata.AcceptanceTests
{
    [TestFixture]
    [UseReporter(typeof(NUnitReporter))]
    public class ProgramShould
    {
        [Test]
        public void TwentyValues()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();
            Approvals.Verify(output);
        }
    }
}
