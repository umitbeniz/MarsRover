using AutoFixture;

namespace MarsRover.Operation.UnitTest
{
    public class UnitTestBase
    {
        public Fixture Fixture { get; set; }

        public UnitTestBase()
        {
            this.InitializeAllObject();
        }

        private void InitializeAllObject()
        {
            this.Fixture = new Fixture();
        }
    }
}