using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextList : MonoBehaviour
{
   [SerializeField] private Text[] texts;

   public Text[] Texts => texts;
}
