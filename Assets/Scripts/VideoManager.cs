using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    [SerializeField]
    private RectTransform videoScreenRectTransform;
    [SerializeField]
    private VideoPlayer videoPlayer;

    public void PlayVideo(string path)
    {
        videoPlayer.url = path;

        videoPlayer.Play();
    }

    public void Rotate(Vector3 direction)
    {
        videoScreenRectTransform.localEulerAngles += direction * Time.deltaTime;
    }
}
