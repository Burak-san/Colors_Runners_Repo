using System;
using UnityEngine;
using Managers;

namespace Controllers
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        #region Self Variables

        #region Public Variables
        #endregion

        #region Serialized Variables

        [SerializeField] private PlayerManager playerManager;
        [SerializeField] private new Collider collider;
        [SerializeField] private new Rigidbody rigidbody;
        [SerializeField] private GameObject playerObj;
        #endregion

        #region Private Variables
        #endregion

        #endregion

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Finish"))
            {
                //UISignals.Instance.onOpenPanel?.Invoke(UIPanels.IdlePanel);
            }
            if(other.CompareTag("DroneAreaPhysics"))
            {
                Debug.Log("DroneAreaPhysics");
                playerManager.RepositionPlayerForDrone(other.gameObject);
                playerManager.EnableVerticalMovement();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("DroneArea"))
            {
                playerManager.StopVerticalMovement();
            }
        }
    }

}
