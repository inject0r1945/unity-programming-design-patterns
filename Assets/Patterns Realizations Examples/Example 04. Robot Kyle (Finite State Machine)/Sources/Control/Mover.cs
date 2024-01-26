using UnityEngine;
using UnityEngine.AI;

namespace Example04.Control
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Mover : MonoBehaviour
    {
        private Transform _transform;
        private NavMeshAgent _agent;
        private bool _isInitialized;

        public bool HasReachedTarget => Vector3.Distance(_agent.destination, _transform.position) < 0.01;

        public bool IsStopped => _agent.isStopped;

        public void Initialize()
        {
            _transform = transform;
            _agent = GetComponent<NavMeshAgent>();
            _isInitialized = true;
            _agent.isStopped = true;
        }

        public void Move(Vector3 target)
        {
            _agent.isStopped = false;
            _agent.destination =target;
        }

        public void Stop()
        {
            _agent.isStopped = true;
            _agent.ResetPath();
        }

        private void ValidateInitialization()
        {
            if (_isInitialized == false)
                throw new System.Exception($"{nameof(Mover)} is not initialized");
        }
    }
}