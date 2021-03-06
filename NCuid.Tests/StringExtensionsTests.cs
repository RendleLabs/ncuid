﻿using Xunit;

namespace NCuid.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void SliceTest()
        {
            Assert.Equal("eac", "Peaceful".Slice(1, 4));
            Assert.Equal(" morning is upon u", "The morning is upon us.".Slice(3, -2));

            const string s = "0123456789_";
            Assert.Equal("0", s.Slice(0, 1));
            Assert.Equal("01", s.Slice(0, 2));
            Assert.Equal("1", s.Slice(1, 2));
            Assert.Equal("89_", s.Slice(8, 11));

            Assert.Equal("dqsd", "qsqdsqdqsdqsd".Slice(-4));

            Assert.Equal("0", "0".Slice(-1));
            Assert.Equal("0", "0".Slice(-4));
            Assert.Equal("0", "0".Slice(-6));

            Assert.Equal("", "".Slice(-6));
        }
    }
}
