using System;
using MelonLoader;
using UnityEngine;

namespace MagnetLib
{
    [RegisterTypeInIl2Cpp]
    class FixOntoBodyParts : MonoBehaviour
    {
        public FixOntoBodyParts(IntPtr ptr) : base(ptr) { }
        private Transform Bodypart;
        private Vector3 zeroedvector;
        public void PickPart(string part)
        {
            if (part == "head")
            {
                Bodypart = MagnetLib.main.arthead;
                MelonLogger.Msg(part);
                MelonLogger.Msg(Bodypart.gameObject.name);
            }
            else if (part == "forearml")
            {
                Bodypart = MagnetLib.main.artforearml;
                MelonLogger.Msg(part);
                MelonLogger.Msg(Bodypart.gameObject.name);
            }
            else if (part == "forearmr")
            {
                Bodypart = MagnetLib.main.artforearmr;
                MelonLogger.Msg(part);
                MelonLogger.Msg(Bodypart.gameObject.name);
            }
            else if (part == "footr")
            {
                Bodypart = MagnetLib.main.artfootr;
                MelonLogger.Msg(part);
                MelonLogger.Msg(Bodypart.gameObject.name);
            }
            else if (part == "footl")
            {
                Bodypart = MagnetLib.main.artfootl;
                MelonLogger.Msg(part);
                MelonLogger.Msg(Bodypart.gameObject.name);
            }
            else
            {
                MelonLogger.Msg($"Body part is {part} and not bindable, defaulting to head");
                Bodypart = MagnetLib.main.arthead;
                MelonLogger.Msg(Bodypart.gameObject.name);
            }
            FixOntoPickedPart();

        }
        public void Awake()
        {
            zeroedvector = new Vector3(0.0f, 0.0f, 0.0f);
        }
        public void FixOntoPickedPart()
        {
            gameObject.transform.SetParent(Bodypart);
            gameObject.transform.localPosition = zeroedvector;
            gameObject.transform.localEulerAngles = zeroedvector;
            MelonLogger.Msg(gameObject.name);
            MelonLogger.Msg(gameObject.transform.parent.name);
            MelonLogger.Msg($"Position: {gameObject.transform.localPosition} amd rotation: {gameObject.transform.localEulerAngles}");
        }
    }
}