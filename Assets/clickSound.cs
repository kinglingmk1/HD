using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class clickSound : MonoBehaviour
{
    [SerializeField] private Button Up;
    [SerializeField] private Button Down;
    [SerializeField] private Button Right;
    [SerializeField] private Button Left;
    [SerializeField] private Button Shift;
    [SerializeField] private Button Reset;
    [SerializeField] private AudioSource[] inputSound;
    [SerializeField] private string collectInput;
    [SerializeField] private Canvas gameCanvas;
    [SerializeField] private GameObject gCanvas;
    [SerializeField] private GameObject[] imageArray;
    [SerializeField] private GameObject name;
    [SerializeField] private GameObject TSkillImage;
    [SerializeField] private GameObject SkillImage;
    [SerializeField] private Sprite[] image;
    public GameObject imagePrefab;
    private RectTransform canvasRectTransform;
    private int imageCount;
    private int tempCount;
    // Start is called before the first frame update
    void Start()
    {
        imageCount = 0;
        tempCount = 0;
        Up.onClick.AddListener(buttonUp);
        Down.onClick.AddListener(buttonDown);
        Right.onClick.AddListener(buttonRight);
        Left.onClick.AddListener(buttonLeft);
        Reset.onClick.AddListener(() =>
        {
            collectInput = "";
            imageArray = new GameObject[0];
            for (int i = 0; i < gCanvas.transform.childCount; i++)
            {
                if (gCanvas.transform.GetChild(i).name.Equals("arr(Clone)"))
                {
                    Destroy(gCanvas.transform.GetChild(i).gameObject);
                }
            }
        });
        canvasRectTransform = gameCanvas.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (collectInput)
        {
            case "01222":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle 500kg Bomb";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[0];
                break;
            case "232203":
                name.GetComponent<TextMeshProUGUI>().text = "Supply Pack";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[1];
                break;
            case "232202":
                name.GetComponent<TextMeshProUGUI>().text = "Ballistic Shield Backpack";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[2];
                break;
            case "203131":
                name.GetComponent<TextMeshProUGUI>().text = "Shield Generator Pack";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[3];
                break;
            case "20020":
                name.GetComponent<TextMeshProUGUI>().text = "Jump Pack";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[4];
                break;
            case "203012":
                name.GetComponent<TextMeshProUGUI>().text = "Guard Dog";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[5];
                break;
            case "203011":
                name.GetComponent<TextMeshProUGUI>().text = "Guard Dog Rover";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[6];
                break;
            case "2201":
                name.GetComponent<TextMeshProUGUI>().text = "Resupply";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[7];
                break;
            case "3202":
                name.GetComponent<TextMeshProUGUI>().text = "Medical Supplies";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[8];
                break;
            case "011":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Strafing Run";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[9];
                break;
            case "0103":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle 110mm Rocket Pods";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[10];
                break;
            case "0121":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Airstrike";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[11];
                break;
            case "0120":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Napalm Airstrike";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[12];
                break;
            case "0102":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Smoke Strike";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[13];
                break;
            case "01221":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Cluster Bomb";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[14];
                break;
            case "00301":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Rearm";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[15];
                break;
            case "0100":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Air-to-Air Missiles";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[16];
                break;
            case "223131":
                name.GetComponent<TextMeshProUGUI>().text = "FX-12 Shield Generator Relay";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[17];
                break;
            case "203113":
                name.GetComponent<TextMeshProUGUI>().text = "E/MG-101 HMG Emplacement";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[18];
                break;
            case "2301":
                name.GetComponent<TextMeshProUGUI>().text = "MD-6 Anti-Personnel Minefield";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[19];
                break;
            case "2332":
                name.GetComponent<TextMeshProUGUI>().text = "MD-I4 Incendiary Mines";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[20];
                break;
            case "2300":
                name.GetComponent<TextMeshProUGUI>().text = "Anti-tank Mines";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[21];
                break;
            case "201031":
                name.GetComponent<TextMeshProUGUI>().text = "A/ARC-3 Tesla Tower";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[22];
                break;
            case "2222200":
                name.GetComponent<TextMeshProUGUI>().text = "SSSD Delivery";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[23];
                break;
            case "22200":
                name.GetComponent<TextMeshProUGUI>().text = "SSSD Delivery";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[24];
                break;
            case "2000":
                name.GetComponent<TextMeshProUGUI>().text = "Drilling Charge";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[25];
                break;
            case "300232":
                name.GetComponent<TextMeshProUGUI>().text = "Extraction Beacon";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[26];
                break;
            case "20320120":
                name.GetComponent<TextMeshProUGUI>().text = "Hellbomb";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[27];
                break;
            case "302122":
                name.GetComponent<TextMeshProUGUI>().text = "HIVE BREAKER DRILL";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[28];
                break;
            case "2223131":
                name.GetComponent<TextMeshProUGUI>().text = "Spire Sterilizer";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[29];
                break;
            case "2020":
                name.GetComponent<TextMeshProUGUI>().text = "Super Earth Flag";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[30];
                break;
            case "203120":
                name.GetComponent<TextMeshProUGUI>().text = "Thumper";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[31];
                break;
            case "223122":
                name.GetComponent<TextMeshProUGUI>().text = "Prospecting Drill";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[32];
                break;
            case "003122":
                name.GetComponent<TextMeshProUGUI>().text = "Seismic Probe";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[33];
                break;
            case "20213202":
                name.GetComponent<TextMeshProUGUI>().text = "Hive Scanner";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[34];
                break;
            case "200122313":
                name.GetComponent<TextMeshProUGUI>().text = "Scrambler";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[35];
                break;
            case "0130130":
                name.GetComponent<TextMeshProUGUI>().text = "Extraction";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[36];
                break;
            case "02130":
                name.GetComponent<TextMeshProUGUI>().text = "Reinforce";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[37];
                break;
            case "0210":
                name.GetComponent<TextMeshProUGUI>().text = "SOS Beacon";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[38];
                break;
            case "31000":
                name.GetComponent<TextMeshProUGUI>().text = "Upload Data";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[39];
                break;
            case "0200":
                name.GetComponent<TextMeshProUGUI>().text = "Jammed Pinata";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[40];
                break;
            case "1002":
                name.GetComponent<TextMeshProUGUI>().text = "SEAF Artillery";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[41];
                break;
            case "110":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Precision Strike";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[42];
                break;
            case "111":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Airburst Strike";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[43];
                break;
            case "1132":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital EMS Strike";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[44];
                break;
            case "112312":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital 120mm HE Barrage";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[45];
                break;
            case "1121":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Gas Strike";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[46];
                break;
            case "1200322":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital 380mm HE Barrage";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[47];
                break;
            case "12012":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Laser";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[48];
                break;
            case "10221":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Railcannon Strike";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[49];
                break;
            case "121212":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Walking Barrage";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[50];
                break;
            case "12300":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Gatling Barrage";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[51];
                break;
            case "1120":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Smoke Strike";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[52];
                break;
            case "2203":
                name.GetComponent<TextMeshProUGUI>().text = "Medical Supplies";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[53];
                break;
            case "3210322":
                name.GetComponent<TextMeshProUGUI>().text = "EXO-45 Patriot Exosuit";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[54];
                break;
            case "21013":
                name.GetComponent<TextMeshProUGUI>().text = "A/MLS-4X Rocket Sentry";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[55];
                break;
            case "23201":
                name.GetComponent<TextMeshProUGUI>().text = "Machine Gun";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[56];
                break;
            case "232001":
                name.GetComponent<TextMeshProUGUI>().text = "Autocannon";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[57];
                break;
            case "23032":
                name.GetComponent<TextMeshProUGUI>().text = "Grenade Launcher";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[58];
                break;
            case "232003":
                name.GetComponent<TextMeshProUGUI>().text = "Stalwart";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[59];
                break;
            case "212031":
                name.GetComponent<TextMeshProUGUI>().text = "Railgun";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[60];
                break;
            case "23113":
                name.GetComponent<TextMeshProUGUI>().text = "Recoilless Rifle";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[61];
                break;
            case "23203":
                name.GetComponent<TextMeshProUGUI>().text = "Laser Cannon";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[62];
                break;
            case "22031":
                name.GetComponent<TextMeshProUGUI>().text = "Quasar Cannon";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[63];
                break;
            case "23102":
                name.GetComponent<TextMeshProUGUI>().text = "Anti-Materiel Rifle";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[64];
                break;
            case "22301":
                name.GetComponent<TextMeshProUGUI>().text = "Expendable Anti-Tank";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[65];
                break;
            case "23020":
                name.GetComponent<TextMeshProUGUI>().text = "Flamethrower";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[66];
                break;
            case "23022":
                name.GetComponent<TextMeshProUGUI>().text = "Heavy Machine Gun";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[67];
                break;
            case "20031":
                name.GetComponent<TextMeshProUGUI>().text = "Airburst Rocket Launcher";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[68];
                break;
            case "22022":
                name.GetComponent<TextMeshProUGUI>().text = "Spear";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[69];
                break;
            case "212033":
                name.GetComponent<TextMeshProUGUI>().text = "Arc Thrower";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[70];
                break;
            case "2013":
                name.GetComponent<TextMeshProUGUI>().text = "A/G-16 Gatling Sentry";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[71];
                break;
            case "20110":
                name.GetComponent<TextMeshProUGUI>().text = "A/MG-43 Machine Gun Sentry";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[72];
                break;
            case "20112":
                name.GetComponent<TextMeshProUGUI>().text = "A/M-12 Mortar Sentry";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[73];
                break;
            case "20121":
                name.GetComponent<TextMeshProUGUI>().text = "A/M-23 EMS Mortar Sentry";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[74];
                break;
            case "20113":
                name.GetComponent<TextMeshProUGUI>().text = "A/MLS-4X Rocket Sentry";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[75];
                break;
            case "201030":
                name.GetComponent<TextMeshProUGUI>().text = "A/AC-8 Autocannon Sentry";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[76];
                break;
            case "3210320":
                name.GetComponent<TextMeshProUGUI>().text = "EXO-49 Emancipator Exosuit";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[77];
                break;
            case "031200":
                name.GetComponent<TextMeshProUGUI>().text = "Dark Flulid Vessel";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[78];
                break;
            case "020202":
                name.GetComponent<TextMeshProUGUI>().text = "Tectonic Drill";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[79];
                break;
            case "1133":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Illumination Flare";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[80];
                break;
            case "unused":
                name.GetComponent<TextMeshProUGUI>().text = "Grinder";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[81];
                break;
            case "1031202 usused":
                name.GetComponent<TextMeshProUGUI>().text = "Nuclear Bomb";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[82];
                break;
            case "3110 usused":
                name.GetComponent<TextMeshProUGUI>().text = "Super Earth Troop Support";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[83];
                break;
            case "010101 unused":
                name.GetComponent<TextMeshProUGUI>().text = "Carpet Bomb";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[84];
                break;
            case "20300 usused":
                name.GetComponent<TextMeshProUGUI>().text = "GL-21 Incendiary Grenade Launcher";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[85];
                break;
            case "21032 usused":
                name.GetComponent<TextMeshProUGUI>().text = "AD-289 Angel";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[86];
                break;
            case "231231":
                name.GetComponent<TextMeshProUGUI>().text = "BX-7 Displacer Pack";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[87];
                break;
            case "21032":
                name.GetComponent<TextMeshProUGUI>().text = "MS-220 Missile Silo";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[88];
                break;
            case "23021":
                name.GetComponent<TextMeshProUGUI>().text = "MLS-4X Commando";
                TSkillImage.SetActive(true);
                SkillImage.GetComponent<Image>().sprite = image[89];
                break;
            default:
                name.GetComponent<TextMeshProUGUI>().text = "";
                TSkillImage.SetActive(false);
                break;
        }

        //Input
        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
        {
            buttonUp();
        } else if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            buttonDown();
        } else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            buttonLeft();
        } else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            buttonRight();
        }

        //Count Arrow
        imageCount = 0;
        tempCount = 0;
        for(int i=0; i< gCanvas.transform.childCount; i++)
        {
            if (gCanvas.transform.GetChild(i).name.Equals("arr(Clone)")) {
                imageCount++;
            }
        }
        imageArray = new GameObject[imageCount];
        for (int i = 0; i < gCanvas.transform.childCount; i++)
        {
            if (gCanvas.transform.GetChild(i).name.Equals("arr(Clone)"))
            {
                imageArray[tempCount] = gCanvas.transform.GetChild(i).gameObject;
                tempCount++;
            }
        }
        for(int i=0; i<imageArray.Length; i++)
        {
            imageArray[i].GetComponent<RectTransform>().anchorMin = new Vector2(0,1);
            imageArray[i].GetComponent<RectTransform>().anchorMax = new Vector2(0, 1);
            imageArray[i].GetComponent<RectTransform>().pivot = new Vector2(0.5f, 0.5f);
            imageArray[i].GetComponent<RectTransform>().anchoredPosition = new Vector2(125+ (125*i), -200);
        }
    }
    private void buttonUp()
    {
        SpawnImage(Up.GetComponent<Image>(), 0);
        inputSound[0].Play();
        collectInput += 0;
    }
    private void buttonLeft()
    {
        SpawnImage(Left.GetComponent<Image>(), 90);
        inputSound[0].Play();
        collectInput += 3;
    }
    private void buttonDown()
    {
        SpawnImage(Down.GetComponent<Image>(), 180);
        inputSound[0].Play();
        collectInput += 2;
    }
    private void buttonRight()
    {
        SpawnImage(Right.GetComponent<Image>(), 270);
        inputSound[0].Play();
        collectInput += 1;
    }
    private void SpawnImage(Image buttonImage, int rotation)
    {
        GameObject imageGO = Instantiate(imagePrefab, Vector3.zero, Quaternion.identity);
        imageGO.transform.SetParent(canvasRectTransform, false);
        RectTransform imageRectTransform = imageGO.GetComponent<RectTransform>();
        if (imageRectTransform == null)
        {
            Destroy(imageGO);
            return;
        }
        float x = canvasRectTransform.rect.width / 2f;
        float y = canvasRectTransform.rect.height / 2f;
        imageRectTransform.anchoredPosition = new Vector2(0,350);
        imageGO.AddComponent<Image>();
        imageGO.GetComponent<Image>().sprite = buttonImage.sprite;
        imageRectTransform.sizeDelta = new Vector2(100, 100);
        imageRectTransform.rotation = Quaternion.Euler(0,0,rotation);
    }
}
