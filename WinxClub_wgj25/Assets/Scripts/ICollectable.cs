using UnityEngine;

namespace DefaultNamespace
{
    public interface ICollectable
    {
        public bool CanCollect(Collider other);
    }
}