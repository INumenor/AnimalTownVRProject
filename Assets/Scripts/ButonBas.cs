using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;

public class ButonBas : MonoBehaviour
{
    public GameObject player;
    public Scene Sahne;
    private void OnHandHoverBegin(Hand hand)
    {
        Debug.Log("lab� ald�m");
        SceneManager.LoadScene(1);
        Destroy(player);
    }
}
