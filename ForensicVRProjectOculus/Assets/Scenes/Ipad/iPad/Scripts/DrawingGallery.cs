using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingGallery : MonoBehaviour
{
    public ScreenShot saveDrawingScript;
    public int counter = 0;
    public int maxCount = 0;

    public void LoadFirstPhoto()
    {

        if (saveDrawingScript.savedImages.Count == 0)
        {
            return;
        }
        else
        {
            saveDrawingScript.savedImages[counter].SetActive(true);
        }
    }


    public void LoadNextPhoto()
    {

        maxCount = saveDrawingScript.savedImages.Count - 1;

        if (saveDrawingScript.savedImages.Count >= 1 && counter != saveDrawingScript.savedImages.Count - 1)
        {
            saveDrawingScript.savedImages[counter].SetActive(false);
            counter++;
            saveDrawingScript.savedImages[counter].SetActive(true);

        }
        else
        {
            Debug.Log("no more pictures to see");
            return;
        }
    }

    public void LoadPreviousPhoto()
    {

        maxCount = saveDrawingScript.savedImages.Count - 1;

        if (saveDrawingScript.savedImages.Count >= 1 && counter != 0)
        {
            saveDrawingScript.savedImages[counter].SetActive(false);
            counter--;
            saveDrawingScript.savedImages[counter].SetActive(true);

        }
        else
        {
            Debug.Log("this is the first picture");
            return;
        }
    }
    public void TurnOffPhoto()
    {
        if (saveDrawingScript.savedImages.Count == 0)
        {
            return;
        }
        else
        {
            saveDrawingScript.savedImages[counter].SetActive(false);
            counter = 0;
        }

    }
}