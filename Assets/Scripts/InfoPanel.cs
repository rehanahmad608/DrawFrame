using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    public AudioSource mAudioSource;
    public AudioClip mAudioClip;
    public GameObject mContentPanel;
    public AnimateObject mAnimateObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowInfo()
    {
        mContentPanel.SetActive(true);
        PlayAudio();

        if (mAnimateObject != null)
            mAnimateObject.MoveToPosition();

    }
    public void HideInfo()
    {
        Debug.Log("clicked");
        mContentPanel.SetActive(false);
        StopAudio();

        if (mAnimateObject != null)
            mAnimateObject.MoveToOrigin();
    }
    
    public void PlayAudio()
    {
        mAudioSource.Stop();
        mAudioSource.clip = mAudioClip;
        mAudioSource.Play();
    }
    public void StopAudio()
    {
        if(mAudioSource.clip == mAudioClip)
            mAudioSource.Stop();
    }

}
