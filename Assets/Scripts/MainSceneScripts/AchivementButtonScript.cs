using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementButtonScript : MonoBehaviour
{
    public GameObject openPopup;
    public GameObject closePopup;

    public void OnButtonClick()
    {
        openPopup.SetActive(true);
        closePopup.SetActive(false);
    }
}
