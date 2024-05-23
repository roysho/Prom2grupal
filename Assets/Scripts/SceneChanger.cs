using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] string EscenaCambiar;
    
    
   public void Cambio()
    {
        SceneManager.LoadScene(EscenaCambiar);
    }

}
