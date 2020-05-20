using HelloWorld.Controllers;
using System;
using Xunit;

namespace HelloWorldDemo
{
    public class UnitTest1
    {
        HelloController HC = new HelloController();

        [Fact]
        public void Test1()
        {


        Assert.NotEmpty(HC.Get());

        }
    }
}
