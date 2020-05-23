using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace EFCore.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var options = new DbContextOptionsBuilder<SampleContext>().Options;

            using (var context = new SampleContext(options))
            {
                context.Add(new Country() { Id = Guid.NewGuid(), Name = "Portugal" });
            }
        }
    }
}
