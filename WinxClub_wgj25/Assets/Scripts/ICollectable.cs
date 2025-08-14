using System;
using UnityEngine;

namespace DefaultNamespace
{
    public interface ICollectable
    {
        public event Action OnCollected;
        public bool CanCollect(Collider other);
    }
}