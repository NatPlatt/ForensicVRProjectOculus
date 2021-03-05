using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedGallery : MonoBehaviour
{
    public ScreenShot savePhotoScript;
    public int counter = 0;
    public int maxCount = 0;

    public void LoadFirstPhoto()
    {

        if (savePhotoScript.savedImages.Count == 0)
        {
            return;
        }
        else
        {
            savePhotoScript.savedImages[counter].SetActive(true);
        }
    }


    public void LoadNextPhoto()
    {

        maxCount = savePhotoScript.savedImages.Count - 1;

        if (savePhotoScript.savedImages.Count >= 1 && counter != savePhotoScript.savedImages.Count - 1)
        {
            savePhotoScript.savedImages[counter].SetActive(false);
            counter++;
            savePhotoScript.savedImages[counter].SetActive(true);

        }
        else
        {
            Debug.Log("no more pictures to see");
            return;
        }
    }

    public void LoadPreviousPhoto()
    {

        maxCount = savePhotoScript.savedImages.Count - 1;

        if (savePhotoScript.savedImages.Count >= 1 && counter != 0)
        {
            savePhotoScript.savedImages[counter].SetActive(false);
            counter--;
            savePhotoScript.savedImages[counter].SetActive(true);

        }
        else
        {
            Debug.Log("this is the first picture");
            return;
        }
    }
    public void TurnOffPhoto()
    {
        if (savePhotoScript.savedImages.Count == 0)
        {
            return;
        }
        else
        {
            savePhotoScript.savedImages[counter].SetActive(false);
            counter = 0;
        }

    }
}