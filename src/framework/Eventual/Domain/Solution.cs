using System;
using System.Collections.Generic;
using Eventual.Domain;

namespace Eventual.Domain
{
    /// <summary>
    /// A Solution describes the architecture and domain of a cloud solution
    /// </summary>
    public class Solution
    {
        public Solution()
        {
            Contexts = new List<Context>();
            Descriptors = new List<Descriptor>();
            Entities = new List<Entity>();
            Events = new List<Event>();
            Modules = new List<Module>();
            Roles = new List<Role>();
            Sagas = new List<Saga>();
            Name = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// A list of Bounded Contexts for the domain.
        /// </summary>
        public IEnumerable<Context> Contexts { get; }

        /// <summary>
        /// A list of Entity Descriptors belonging to the 
        /// </summary>
        public IEnumerable<Descriptor> Descriptors { get; }

        public IEnumerable<Entity> Entities { get; }

        /// <summary>
        /// A list of Events belonging to the domain
        /// </summary>
        public IEnumerable<Event> Events { get; }

        /// <summary>
        /// A list of the Modules belonging to the domain
        /// </summary>
        public IEnumerable<Module> Modules { get; }

        /// <summary>
        /// A list of the Sagas belonging to the domain
        /// </summary>
        public IEnumerable<Saga> Sagas { get; }

        /// <summary>
        /// A list of the Roles belonging to the domain
        /// </summary>
        public IEnumerable<Role> Roles { get; }

        /// <summary>
        /// The name of the Solution.
        /// </summary>
        public string Name { get; }
    }
}