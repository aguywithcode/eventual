using Eventual.Domain;
using Xunit;

namespace Eventual.Tests
{
    /// <summary>
    /// This class specifies the Invariants of a Solution when it is initialized.
    /// </summary>
    public class When_Creating_a_Solution
    {
        private readonly Solution _solution;

        public When_Creating_a_Solution()
        {
            _solution = new Solution();
        }


        [Fact]
        public void it_should_have_a_random_name_assigned()
        {
            Assert.False(string.IsNullOrEmpty(_solution.Name));
        }

        [Fact]
        public void it_should_have_no_contexts()
        {
            Assert.Empty(_solution.Contexts);
        }

        [Fact]
        public void it_should_have_no_descriptors()
        {
            Assert.Empty(_solution.Descriptors);
        }

        [Fact]
        public void it_should_have_no_entities()
        {
            Assert.Empty(_solution.Entities);
        }

        [Fact]
        public void it_should_have_no_events()
        {
            Assert.Empty(_solution.Events);
        }

        [Fact]
        public void it_should_have_no_modules()
        {
            Assert.Empty(_solution.Modules);
        }

        [Fact]
        public void it_should_have_no_roles()
        {
            Assert.Empty(_solution.Roles);
        }

        [Fact]
        public void it_should_have_no_sagas()
        {
            Assert.Empty(_solution.Sagas);
        }

    }
}
