using UnityEngine;

namespace RickSzaboDev.Behaviour
{
    public class LookAtCamera : MonoBehaviour
    {
        [SerializeField] private Transform CameraTransform;

        private void Update()
        {
            if (!CameraTransform)
            {
                Debug.LogWarning($"Trying to make {gameObject.name} look at camera, but no camera target was assigned.");
                return;
            }

            transform.rotation = Quaternion.LookRotation(transform.position - CameraTransform.position);
        }
    }
}