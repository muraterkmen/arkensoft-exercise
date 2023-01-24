using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise.Tests
{
    public class SubsequenceStringTests
    {
        [Fact]
        public void IsSubsequence_subsequent_found()
        {
            string s = "abc", t = "ahbgdc";

            var subsequence = new SubsequenceString();
            var result = subsequence.IsSubsequence(s, t);

            Assert.True(result);
        }
        
        [Fact]
        public void IsSubsequence_subsequent_not_found()
        {
            string s = "axc", t = "ahbgdc";

            var subsequence = new SubsequenceString();
            var result = subsequence.IsSubsequence(s, t);

            Assert.False(result);
        }
    }
}
