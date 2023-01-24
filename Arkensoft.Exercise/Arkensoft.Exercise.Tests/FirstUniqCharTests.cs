namespace Arkensoft.Exercise.Tests
{
    public class FirstUniqCharTests
    {
        [Fact]
        public void FindFirstUniqChar_if_first_character_is_unique()
        {
            string str = "lee";
            var firstUniqChar = new FirstUniqChar();
            var index = firstUniqChar.FindFirstUniqChar(str);

            Assert.Equal(0, index);
        }

        [Fact]
        public void FindFirstUniqChar_if_last_character_is_unique()
        {
            string str = "leelt";
            var firstUniqChar = new FirstUniqChar();
            var index = firstUniqChar.FindFirstUniqChar(str);

            Assert.Equal(4, index);
        }

        [Fact]
        public void FindFirstUniqChar_if_middle_character_is_unique()
        {
            string str = "abcab";
            var firstUniqChar = new FirstUniqChar();
            var index = firstUniqChar.FindFirstUniqChar(str);

            Assert.Equal(2, index);
        }

        [Fact]
        public void FindFirstUniqChar_if_request_is_null()
        {
            var firstUniqChar = new FirstUniqChar();
            var index = firstUniqChar.FindFirstUniqChar(null);

            Assert.Equal(-1, index);
        }

        [Fact]
        public void FindFirstUniqChar_if_request_is_empty()
        {
            string str = "";
            var firstUniqChar = new FirstUniqChar();
            var index = firstUniqChar.FindFirstUniqChar(str);

            Assert.Equal(-1, index);
        }
    }
}