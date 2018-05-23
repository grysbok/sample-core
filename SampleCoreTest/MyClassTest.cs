using SampleCoreWeb;
using Xunit;

namespace SampleCoreTest
{
    public class MyClassTest
    {
        [Fact]
        public void NewIdShouldReturnUniqueValues()
        {
            var myClass = new MyClass();
            var id1 = myClass.NewId();
            var id2 = myClass.NewId();

            Assert.NotEqual(id1, id2);
        }
    }
}