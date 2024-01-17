using Example02.Attributes;
using Example02.Control;
using UnityEngine;

namespace Example02
{
    [RequireComponent(typeof(PlayerInputReceiver))]
    [RequireComponent(typeof(Mover))]
    [RequireComponent(typeof(Age))]
    public class Player : MonoBehaviour
    {
    }
}