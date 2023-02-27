using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingCollectionButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GoTitleButtonOnClick() 
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void FlipPageLeft()
    {
        Debug.Log(EndingCollectionManager.endingCollectionData.ending1.endingName);
    }

    public void FlipPageRight()
    {
        
    }

    public void ShowData()
    {
        // Debug.Log(EndingCollectionManager.endingData);
    }
}
