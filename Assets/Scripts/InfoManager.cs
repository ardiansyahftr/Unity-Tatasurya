using UnityEngine;
using UnityEngine.UI;

public class InfoManager : MonoBehaviour
{
    private bool[] isMarker;
    private GameObject planet;
    private int hitungMarker;
    [SerializeField] int jmlMarker;
    [SerializeField] private Text txNama, txDeskr;
    public AudioSource audioDefault;
    public AudioClip[] audioClipsObject;
    public void Start()
    {
        isMarker = new bool[jmlMarker];
    }

    public void SetMarkerOn(int indexMarker)
    {
        // jika ismarker pada index false (null)
        if (!isMarker[indexMarker])
        {
            // maka menset ismarker pada index indexmarker sebagai true
            isMarker[indexMarker] = true;
            // lalu melakukan increment pada hitungMarker
            hitungMarker++;
        }
        // jika tidak memenuhi kondisi, maka akan dilewati
    }
    public void SetMarkerOff(int indexMarker)
    {
        // jika ismarker pada index true (bervalue)
        if (isMarker[indexMarker])
        {
            // maka menset ismarker pada index indexmarker sebagai false
            isMarker[indexMarker] = false;
            // lalu melakukan decrement pada hitungMarker
            hitungMarker--;
        }
        // jika tidak memenuhi kondisi, maka akan dilewati
    }

    // melakukan set planet saat ini sesuai paramater planet yg diset/dikirim
    public void SetPlanet(GameObject planet)
    {
        this.planet = planet;
    }

    // SetUI berfungsi untuk mengaktifkan dan menonaktifkan UI
    // jika b == true, maka UI aktif. jika b == false maka UI nonaktif
    private void SetUI(bool b)
    {
        txNama.transform.parent.gameObject.SetActive(b);
        txDeskr.transform.parent.gameObject.SetActive(b);
        audioDefault.transform.parent.gameObject.SetActive(b);
    }

    // Update is called once per frame
    void Update()
    {
        // jika tidak ada marker,
        if (hitungMarker == 0)
        {
            // maka SetUI(false) => menonaktifkan UI
            SetUI(false);
            return;
        }

        // jika planet tidak kosong,
        if (planet != null)
        {
            // maka SetUI(true) => mengaktifkan UI
            SetUI(true);
            for (int i = 0; i < isMarker.Length; i++)
            {
                // melakukan perulangan untuk menset text nama, deskripsi, dan audio planet
                // mengambil dari PlanetInfo.cs
                txNama.text = planet.GetComponent<PlanetInfo>().GetNama();
                txDeskr.text = planet.GetComponent<PlanetInfo>().GetDeskripsi();
                audioDefault.clip = planet.GetComponent<PlanetInfo>().GetAudioClip();
            }
        }
    }
}
