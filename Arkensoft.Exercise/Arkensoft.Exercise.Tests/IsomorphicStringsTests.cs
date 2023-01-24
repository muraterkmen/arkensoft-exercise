using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise.Tests
{
    public class IsomorphicStringsTests
    {
        [Fact]
        public void IsomorphicStrings_result_true()
        {
            string s = "egg", t = "add";
            IsomorphicStrings isomorphic = new IsomorphicStrings();
            var result = isomorphic.IsIsomorphic(s, t);

            Assert.True(result);
        }

        [Fact]
        public void IsomorphicStrings_result_false()
        {
            string s = "foo", t = "bar";
            IsomorphicStrings isomorphic = new IsomorphicStrings();
            var result = isomorphic.IsIsomorphic(s, t);

            Assert.False(result);
        }


    }
}
