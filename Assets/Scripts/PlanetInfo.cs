using UnityEngine;
// PlanetInfo.cs digunakan untuk wadah info planet, seperti
// nama, deskripsi, dan audio
public class PlanetInfo : MonoBehaviour
{
    [SerializeField] private string nama;
    [SerializeField][TextArea] private string deskripsi;
    [SerializeField] private AudioClip audioClip;

    // Terdapat fungsi GetNama untuk digunakan mengambil nama
    // yg akan digunakan di Script InfoManager.cs
    // GetNama akan mereturn nama yg telah diset di Marker
    public string GetNama()
    {
        return nama;
    }

    // Terdapat fungsi GetDeskripsi untuk digunakan mengambil deskripsi
    // yg akan digunakan di Script InfoManager.cs
    // GetDeskripsi akan mereturn deskripsi yg telah diset di Marker
    public string GetDeskripsi()
    {
        return deskripsi;
    }


    // Terdapat fungsi GetAudioClip untuk digunakan mengambil audio
    // yg akan digunakan di Script InfoManager.cs
    // GetAudioClip akan mereturn audioClip yg telah dipasang di Marker
    public AudioClip GetAudioClip()
    {
        return audioClip;
    }

}
