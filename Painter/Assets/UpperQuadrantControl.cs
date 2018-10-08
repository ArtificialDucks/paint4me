using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperQuadrantControl : MonoBehaviour {
    //need to track keys in each quadrant to activate and deactivate when switching
    public List<GameObject> Quadrant1 = new List<GameObject>();
    public List<GameObject> Quadrant2 = new List<GameObject>();
    public List<GameObject> Quadrant3 = new List<GameObject>();
    public List<GameObject> Quadrant4 = new List<GameObject>();
    public List<GameObject> Quadrant5 = new List<GameObject>();
    public List<GameObject> Quadrant6 = new List<GameObject>();
    public List<GameObject> Quadrant7 = new List<GameObject>();
    public List<GameObject> Quadrant8 = new List<GameObject>();
    public List<GameObject> Quadrant9 = new List<GameObject>();
    PaintingCore paint;
    //need to know which quadrants are empty
    public bool q1 = true, q2 = true, q3 = true, q4 = true, q5 = true, q6 = true, q7 = true, q8 = true, q9 = true;
    // Use this for initialization
    void Start () {
      if (Quadrant1.Count > 0) q1 = true;
      else q1 = false;
      
      if (Quadrant2.Count > 0) q2 = true;
      else q2 = false;
      
      if (Quadrant3.Count > 0) q3 = true;
      else q3 = false;
      
      if (Quadrant4.Count > 0) q4 = true;
      else q4 = false;
      
      if (Quadrant5.Count > 0) q5 = true;
      else q5 = false;
      
      if (Quadrant6.Count > 0) q6 = true;
      else q6 = false;
      
      if (Quadrant7.Count > 0) q7 = true;
      else q7 = false;
      
      if (Quadrant8.Count > 0) q8 = true;
      else q8 = false;
      
      if (Quadrant9.Count > 0) q9 = true;
      else q9 = false;

        for (int i = 0; i < Quadrant4.Count; i++)
        {
            paint = Quadrant4[i].GetComponent<PaintingCore>();
            paint.CanChangeColor = true;
           //if (q1 == true)
           //{
           //    paint = Quadrant1[i].GetComponent<PaintingCore>();
           //    paint.CanChangeColor = false;
           //}
           //
           //if (q2 == true)
           //{
           //    paint = Quadrant2[i].GetComponent<PaintingCore>();
           //    paint.CanChangeColor = false;
           //}
           //if (q3 == true)
           //{
           //    paint = Quadrant3[i].GetComponent<PaintingCore>();
           //    paint.CanChangeColor = false;
           //}
           //if (q5 == true)
           //{
           //    paint = Quadrant5[i].GetComponent<PaintingCore>();
           //    paint.CanChangeColor = false;
           //}
           //if (q6 == true)
           //{
           //    paint = Quadrant6[i].GetComponent<PaintingCore>();
           //    paint.CanChangeColor = false;
           //}
           //if (q7 == true)
           //{
           //    paint = Quadrant7[i].GetComponent<PaintingCore>();
           //    paint.CanChangeColor = false;
           //}
           //if (q8 == true)
           //{
           //    paint = Quadrant8[i].GetComponent<PaintingCore>();
           //    paint.CanChangeColor = false;
           //}
           //if (q9 == true)
           //{
           //    paint = Quadrant9[i].GetComponent<PaintingCore>();
           //    paint.CanChangeColor = false;
           //}
        }
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void Activateq1()
    {
        if (q1 == true)
        {
            for (int i = 0; i < Quadrant4.Count; i++)
            {
                if (q1 == true)
                {
                    paint = Quadrant1[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = true;
                }
                if (q2 == true)
                {
                    paint = Quadrant2[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                
                if (q3 == true)
                {
                    paint = Quadrant3[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                
                if (q4 == true)
                {
                    paint = Quadrant4[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q5 == true)
                {
                    paint = Quadrant5[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q6 == true)
                {
                    paint = Quadrant6[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q7 == true)
                {
                    paint = Quadrant7[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q8 == true)
                {
                    paint = Quadrant8[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q9 == true)
                {
                    paint = Quadrant9[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                } 
            }
        }
    }

    public void Activateq2()
    {
        if (q2 == true)
        {
            for (int i = 0; i < Quadrant4.Count; i++)
            {
                if (q1 == true)
                {
                    paint = Quadrant1[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                
                if (q2 == true)
                {
                    paint = Quadrant2[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = true;
                }

                if (q3 == true)
                {
                    paint = Quadrant3[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q4 == true)
                {
                    paint = Quadrant4[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q5 == true)
                {
                    paint = Quadrant5[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q6 == true)
                {
                    paint = Quadrant6[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q7 == true)
                {
                    paint = Quadrant7[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q8 == true)
                {
                    paint = Quadrant8[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q9 == true)
                {
                    paint = Quadrant9[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
            }
        }
    }

    public void Activateq3()
    {
        if (q3 == true)
        {
            for (int i = 0; i < Quadrant4.Count; i++)
            {
                if (q1 == true)
                {
                    paint = Quadrant1[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q2 == true)
                {
                    paint = Quadrant2[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q3 == true)
                {
                    paint = Quadrant3[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = true;
                }

                if (q4 == true)
                {
                    paint = Quadrant4[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q5 == true)
                {
                    paint = Quadrant5[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q6 == true)
                {
                    paint = Quadrant6[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q7 == true)
                {
                    paint = Quadrant7[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q8 == true)
                {
                    paint = Quadrant8[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q9 == true)
                {
                    paint = Quadrant9[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
            }
        }
    }

    public void Activateq4()
    {
        if (q4 == true)
        {
            for (int i = 0; i < Quadrant4.Count; i++)
            {
                if (q1 == true)
                {
                    paint = Quadrant1[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q2 == true)
                {
                    paint = Quadrant2[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q3 == true)
                {
                    paint = Quadrant3[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q4 == true)
                {
                    paint = Quadrant4[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = true;
                }
                if (q5 == true)
                {
                    paint = Quadrant5[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q6 == true)
                {
                    paint = Quadrant6[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q7 == true)
                {
                    paint = Quadrant7[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q8 == true)
                {
                    paint = Quadrant8[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q9 == true)
                {
                    paint = Quadrant9[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
            }
        }
    }

    public void Activateq5()
    {
        if (q5 == true)
        {
            for (int i = 0; i < Quadrant4.Count; i++)
            {
                if (q1 == true)
                {
                    paint = Quadrant1[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q2 == true)
                {
                    paint = Quadrant2[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q3 == true)
                {
                    paint = Quadrant3[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q4 == true)
                {
                    paint = Quadrant4[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q5 == true)
                {
                    paint = Quadrant5[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = true;
                }
                if (q6 == true)
                {
                    paint = Quadrant6[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q7 == true)
                {
                    paint = Quadrant7[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q8 == true)
                {
                    paint = Quadrant8[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q9 == true)
                {
                    paint = Quadrant9[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
            }
        }
    }

    public void Activateq6()
    {
        if (q6 == true)
        {
            for (int i = 0; i < Quadrant4.Count; i++)
            {
                if (q1 == true)
                {
                    paint = Quadrant1[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q2 == true)
                {
                    paint = Quadrant2[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q3 == true)
                {
                    paint = Quadrant3[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q4 == true)
                {
                    paint = Quadrant4[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q5 == true)
                {
                    paint = Quadrant5[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q6 == true)
                {
                    paint = Quadrant6[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = true;
                }
                if (q7 == true)
                {
                    paint = Quadrant7[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q8 == true)
                {
                    paint = Quadrant8[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q9 == true)
                {
                    paint = Quadrant9[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
            }
        }
    }

    public void Activateq7()
    {
        if (q7 == true)
        {
            for (int i = 0; i < Quadrant4.Count; i++)
            {
                if (q1 == true)
                {
                    paint = Quadrant1[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q2 == true)
                {
                    paint = Quadrant2[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q3 == true)
                {
                    paint = Quadrant3[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q4 == true)
                {
                    paint = Quadrant4[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q5 == true)
                {
                    paint = Quadrant5[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q6 == true)
                {
                    paint = Quadrant6[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q7 == true)
                {
                    paint = Quadrant7[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = true;
                }
                if (q8 == true)
                {
                    paint = Quadrant8[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q9 == true)
                {
                    paint = Quadrant9[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
            }
        }
    }

    public void Activateq8()
    {
        if (q8 == true)
        {
            for (int i = 0; i < Quadrant4.Count; i++)
            {
                if (q1 == true)
                {
                    paint = Quadrant1[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q2 == true)
                {
                    paint = Quadrant2[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q3 == true)
                {
                    paint = Quadrant3[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q4 == true)
                {
                    paint = Quadrant4[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q5 == true)
                {
                    paint = Quadrant5[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q6 == true)
                {
                    paint = Quadrant6[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q7 == true)
                {
                    paint = Quadrant7[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q8 == true)
                {
                    paint = Quadrant8[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = true;
                }
                if (q9 == true)
                {
                    paint = Quadrant9[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
            }
        }
    }

    public void Activateq9()
    {
        if (q9 == true)
        {
            for (int i = 0; i < Quadrant4.Count; i++)
            {
                if (q1 == true)
                {
                    paint = Quadrant1[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q2 == true)
                {
                    paint = Quadrant2[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q3 == true)
                {
                    paint = Quadrant3[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }

                if (q4 == true)
                {
                    paint = Quadrant4[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q5 == true)
                {
                    paint = Quadrant5[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q6 == true)
                {
                    paint = Quadrant6[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q7 == true)
                {
                    paint = Quadrant7[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q8 == true)
                {
                    paint = Quadrant8[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = false;
                }
                if (q9 == true)
                {
                    paint = Quadrant9[i].GetComponent<PaintingCore>();
                    paint.CanChangeColor = true;
                }
            }
        }
    }
}
