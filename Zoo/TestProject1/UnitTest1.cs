using System;
using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Zoo;
using static Zoo.Animals1;
using static Zoo.Canar;
namespace TestProject1
{
    public class UnitTest1
    {
        Animals1 canar = new Canar();


        [Fact]
        public void Test1()
        {
            Assert.Equal("seeds its favorit food",canar.Eat();
        }
    }
}
