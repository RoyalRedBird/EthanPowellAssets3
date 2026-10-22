using UnityEngine;

public class JacobManager : MonoBehaviour
{

    public GameObject[] TorsoParts;
    public GameObject[] NeutralArmParts;
    public GameObject[] ForwardLeanArmParts;
    public GameObject[] BackwardLeanArmParts;
    public GameObject[] LegParts;
    public GameObject[] EyeParts;
    public GameObject[] MouthParts;
    public GameObject[] HeadLocations;
    public GameObject Head;

    public int activeTorso = 0;
    public int activeArmSet = 0;
    public int activeLegSet = 0;
    private int activeHeadSpot = 0;
    public int activeEyeSet = 0;
    public int activeMouthSet = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        SpriteArranger();
        
    }

    // Update is called once per frame
    void Update()
    {

        SpriteArranger();

    }

    public void SpriteArranger()
    {

        for(int i = 0; i < TorsoParts.Length; i++)
        {

            if(i == activeTorso)
            {

                TorsoParts[i].gameObject.SetActive(true);
                activeHeadSpot = i;

            }
            else
            {

                TorsoParts[i].gameObject.SetActive(false);

            }

        }

        for(int i = 0; i < NeutralArmParts.Length; i++)
        {

            if(i == activeArmSet)
            {

                NeutralArmParts[i].gameObject.SetActive(true);
                ForwardLeanArmParts[i].gameObject.SetActive(true);
                BackwardLeanArmParts[i].gameObject.SetActive(true);

            }
            else
            {

                NeutralArmParts[i].gameObject.SetActive(false);
                ForwardLeanArmParts[i].gameObject.SetActive(false);
                BackwardLeanArmParts[i].gameObject.SetActive(false);

            }

        }

        for(int i = 0; i < LegParts.Length; i++)
        {

            if(i == activeLegSet)
            {

                LegParts[i].gameObject.SetActive(true);

            }
            else
            {

                LegParts[i].gameObject.SetActive(false);

            }

        }

        for (int i = 0; i < EyeParts.Length; i++)
        {

            if (i == activeEyeSet)
            {

                EyeParts[i].gameObject.SetActive(true);

            }
            else
            {

                EyeParts[i].gameObject.SetActive(false);

            }

        }

        for (int i = 0; i < MouthParts.Length; i++)
        {

            if (i == activeMouthSet)
            {

                MouthParts[i].gameObject.SetActive(true);

            }
            else
            {

                MouthParts[i].gameObject.SetActive(false);

            }

        }

        for (int i = 0; i < HeadLocations.Length; i++)
        {

            if (i == activeHeadSpot)
            {

                Head.transform.localPosition = HeadLocations[i].transform.localPosition;

            }

        }

    }

}
