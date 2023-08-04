using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RoomUI.ScriptForTest
{
    public class PlayerEntry : MonoBehaviour
    {
        [SerializeField] TMP_Text playerName;
        [SerializeField] TMP_Text playerReady;
        [SerializeField] Button playerReadyButton;

        public void Ready()
        {

        }
    }
}