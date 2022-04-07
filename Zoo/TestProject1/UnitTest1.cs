using System;
using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Zoo;
using static Zoo.Animals1;

namespace TestProject1
{
    public class UnitTest1
    {
        Animals1 canar = new Canar();


        [Fact]
        public void Test1()
        {
            Assert.Equal("seeds its favorit food",canar.Eat());
        }

        [Fact]
        public void Test2()
        {
            Mammals camel = new Camel();
            //Camel camel = new Camel();
            Assert.Equal("cactes its favorit food", camel.Eat());
        }

        [Fact]
        public void Test3()
        {
            Lion lion = new Lion();
            Assert.Equal("waaaw", lion.Sound());
        }

        [Fact]
        public void TestinterfaceIStrong()
        {
            Lion lion = new Lion();
            Assert.Equal("lion is the king of the savana", lion.IsStrong());

        }

        [Fact]
        public void TestinterfaceIFriendly()
        {
            Mammals camel = new Camel();
            Assert.Equal("camel is my best frind", camel.IsFriendly());

        }

        [Fact]
        public void TestDiscrobeTheTast()
        {
            Fishs redtuna = new Tuna();
            Assert.Equal("mmm it dose tast raly gooood!!!", redtuna.DiscrobeTheTast());

        }





    }
}
