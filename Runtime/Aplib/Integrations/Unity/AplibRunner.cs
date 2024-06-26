// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// Copyright Utrecht University (Department of Information and Computing Sciences)

using Aplib.Core;
using System.Collections;
using Aplib.Core.Agents;

namespace Aplib.Integrations.Unity
{
    public class AplibRunner
    {
        /// <summary>
        /// The agent that the test runner is testing.
        /// </summary>
        private readonly IAgent _agent;

        public AplibRunner(IAgent agent)
        {
            _agent = agent;
        }

        /// <summary>
        /// Runs the test for the agent. The test continues until the agent's status is no longer Unfinished.
        /// </summary>
        /// <returns>An IEnumerator that can be used to control the execution of the test.</returns>
        public IEnumerator Test()
        {
            while (_agent.Status == CompletionStatus.Unfinished)
            {
                // Perform computation or update the agent here
                _agent.Update();

                // Wait for the next frame
                yield return null;
            }
        }
    }
}
