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
                break;
            case "232002":
                name.GetComponent<TextMeshProUGUI>().text = "Supply Pack";
                break;
            case "232202":
                name.GetComponent<TextMeshProUGUI>().text = "Ballistic Shield Backpack";
                break;
            case "203131":
                name.GetComponent<TextMeshProUGUI>().text = "Shield Generator Pack";
                break;
            case "20020":
                name.GetComponent<TextMeshProUGUI>().text = "Jump Pack";
                break;
            case "203012":
                name.GetComponent<TextMeshProUGUI>().text = "Guard Dog";
                break;
            case "203011":
                name.GetComponent<TextMeshProUGUI>().text = "Guard Dog Rover";
                break;
            case "2201":
                name.GetComponent<TextMeshProUGUI>().text = "Resupply";
                break;
            case "3202":
                name.GetComponent<TextMeshProUGUI>().text = "Medical Supplies";
                break;
            case "011":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Strafing Run";
                break;
            case "0103":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle 110mm Rocket Pods";
                break;
            case "0121":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Airstrike";
                break;
            case "0120":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Napalm Airstrike";
                break;
            case "0102":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Smoke Strike";
                break;
            case "01221":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Cluster Bomb";
                break;
            case "00301":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Rearm";
                break;
            case "0100":
                name.GetComponent<TextMeshProUGUI>().text = "Eagle Air-to-Air Missiles";
                break;
            case "223131":
                name.GetComponent<TextMeshProUGUI>().text = "FX-12 Shield Generator Relay";
                break;
            case "203113":
                name.GetComponent<TextMeshProUGUI>().text = "E/MG-101 HMG Emplacement";
                break;
            case "2301":
                name.GetComponent<TextMeshProUGUI>().text = "MD-6 Anti-Personnel Minefield";
                break;
            case "2332":
                name.GetComponent<TextMeshProUGUI>().text = "MD-I4 Incendiary Mines";
                break;
            case "2300":
                name.GetComponent<TextMeshProUGUI>().text = "Anti-tank Mines";
                break;
            case "201031":
                name.GetComponent<TextMeshProUGUI>().text = "A/ARC-3 Tesla Tower";
                break;
            case "2222200":
                name.GetComponent<TextMeshProUGUI>().text = "SSSD Delivery";
                break;
            case "22200":
                name.GetComponent<TextMeshProUGUI>().text = "SSSD Delivery";
                break;
            case "2000":
                name.GetComponent<TextMeshProUGUI>().text = "Drilling Charge";
                break;
            case "300232":
                name.GetComponent<TextMeshProUGUI>().text = "Extraction Beacon";
                break;
            case "20320120":
                name.GetComponent<TextMeshProUGUI>().text = "Hellbomb";
                break;
            case "302122":
                name.GetComponent<TextMeshProUGUI>().text = "HIVE BREAKER DRILL";
                break;
            case "2223131":
                name.GetComponent<TextMeshProUGUI>().text = "Spire Sterilizer";
                break;
            case "2020":
                name.GetComponent<TextMeshProUGUI>().text = "Super Earth Flag";
                break;
            case "203120":
                name.GetComponent<TextMeshProUGUI>().text = "Thumper";
                break;
            case "223122":
                name.GetComponent<TextMeshProUGUI>().text = "Prospecting Drill";
                break;
            case "003122":
                name.GetComponent<TextMeshProUGUI>().text = "Seismic Probe";
                break;
            case "20213202":
                name.GetComponent<TextMeshProUGUI>().text = "Hive Scanner";
                break;
            case "200122313":
                name.GetComponent<TextMeshProUGUI>().text = "Scrambler";
                break;
            case "0130130":
                name.GetComponent<TextMeshProUGUI>().text = "Extraction";
                break;
            case "02130":
                name.GetComponent<TextMeshProUGUI>().text = "Reinforce";
                break;
            case "0210":
                name.GetComponent<TextMeshProUGUI>().text = "SOS Beacon";
                break;
            case "31000":
                name.GetComponent<TextMeshProUGUI>().text = "Upload Data";
                break;
            case "0200":
                name.GetComponent<TextMeshProUGUI>().text = "Jammed Pinata";
                break;
            case "1002":
                name.GetComponent<TextMeshProUGUI>().text = "SEAF Artillery";
                break;
            case "110":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Precision Strike";
                break;
            case "111":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Airburst Strike";
                break;
            case "1132":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital EMS Strike";
                break;
            case "112312":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital 120mm HE Barrage";
                break;
            case "1121":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Gas Strike";
                break;
            case "1200322":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital 380mm HE Barrage";
                break;
            case "12012":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Laser";
                break;
            case "10221":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Railcannon Strike";
                break;
            case "121212":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Walking Barrage";
                break;
            case "12300":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Gatling Barrage";
                break;
            case "1120":
                name.GetComponent<TextMeshProUGUI>().text = "Orbital Smoke Strike";
                break;
            case "2203":
                name.GetComponent<TextMeshProUGUI>().text = "Medical Supplies";
                break;
            case "3210322":
                name.GetComponent<TextMeshProUGUI>().text = "EXO-45 Patriot Exosuit";
                break;
            case "21013":
                name.GetComponent<TextMeshProUGUI>().text = "A/MLS-4X Rocket Sentry";
                break;
            case "23201":
                name.GetComponent<TextMeshProUGUI>().text = "Machine Gun";
                break;
            case "232001":
                name.GetComponent<TextMeshProUGUI>().text = "Autocannon";
                break;
            case "23032":
                name.GetComponent<TextMeshProUGUI>().text = "Grenade Launcher";
                break;
            case "232003":
                name.GetComponent<TextMeshProUGUI>().text = "Stalwart";
                break;
            case "212031":
                name.GetComponent<TextMeshProUGUI>().text = "Railgun";
                break;
            case "23113":
                name.GetComponent<TextMeshProUGUI>().text = "Recoilless Rifle";
                break;
            case "23203":
                name.GetComponent<TextMeshProUGUI>().text = "Laser Cannon";
                break;
            case "22031":
                name.GetComponent<TextMeshProUGUI>().text = "Quasar Cannon";
                break;
            case "23102":
                name.GetComponent<TextMeshProUGUI>().text = "Anti-Materiel Rifle";
                break;
            case "22301":
                name.GetComponent<TextMeshProUGUI>().text = "Expendable Anti-Tank";
                break;
            case "23020":
                name.GetComponent<TextMeshProUGUI>().text = "Flamethrower";
                break;
            case "23022":
                name.GetComponent<TextMeshProUGUI>().text = "Heavy Machine Gun";
                break;
            case "20031":
                name.GetComponent<TextMeshProUGUI>().text = "Airburst Rocket Launcher";
                break;
            case "22022":
                name.GetComponent<TextMeshProUGUI>().text = "Spear";
                break;
            case "212033":
                name.GetComponent<TextMeshProUGUI>().text = "Arc Thrower";
                break;
            case "2013":
                name.GetComponent<TextMeshProUGUI>().text = "A/G-16 Gatling Sentry";
                break;
            case "20110":
                name.GetComponent<TextMeshProUGUI>().text = "A/MG-43 Machine Gun Sentry";
                break;
            case "20112":
                name.GetComponent<TextMeshProUGUI>().text = "A/M-12 Mortar Sentry";
                break;
            case "20121":
                name.GetComponent<TextMeshProUGUI>().text = "A/M-23 EMS Mortar Sentry";
                break;
            case "20113":
                name.GetComponent<TextMeshProUGUI>().text = "A/MLS-4X Rocket Sentry";
                break;
            case "201030":
                name.GetComponent<TextMeshProUGUI>().text = "A/AC-8 Autocannon Sentry";
                break;
            case "3210320":
                name.GetComponent<TextMeshProUGUI>().text = "EXO-49 Emancipator Exosuit";
                break;
            default:
                name.GetComponent<TextMeshProUGUI>().text = "";
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