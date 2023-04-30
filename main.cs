using System;
using MelonLoader;
using MagnetLib;
using BoneLib;
using Player = BoneLib.Player;
using SLZ.Rig;
using UnityEngine;

[assembly: MelonInfo(typeof(main), "Magnet Lib", "0.1.0", "Void Vapor Inc")]
[assembly: MelonGame("Stress Level Zero", "BONELAB")]

namespace MagnetLib
{
    public class main : MelonMod
    {
        public static Transform physpelvis;
        public static Transform physhead;
        public static Transform arthead;
        public static Transform artforearml;
        public static Transform artforearmr;
        public static Transform artfootl;
        public static Transform artfootr;
        public static RigManager storedrm;

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            storedrm = Player.rigManager;
            physpelvis = Player.GetPhysicsRig().m_pelvis;
            physhead = Player.GetPhysicsRig().m_head;
            Transform Artoutput = storedrm.transform.Find("[ArtOutputRig (Marrow1)]");
            arthead = Artoutput.transform.Find("Head");
            artforearmr = Artoutput.transform.Find("Chest/clavRt/ShoulderRt/ElbowRt/artLowerArmRt");
            artforearml = Artoutput.transform.Find("Chest/clavLf/ShoulderLf/ElbowLf/artLowerArmLf");
            artfootl = Artoutput.transform.Find("Foot (left)");
            artfootr = Artoutput.transform.Find("Foot (right)");
            LoggerInstance.Msg(storedrm.gameObject.name);
            LoggerInstance.Msg(physhead.gameObject.name);
            LoggerInstance.Msg(physpelvis.gameObject.name);
            LoggerInstance.Msg(arthead.gameObject.name);
            LoggerInstance.Msg(artforearml.gameObject.name);
            LoggerInstance.Msg(artforearmr.gameObject.name);
            LoggerInstance.Msg(artfootr.gameObject.name);
            LoggerInstance.Msg(artfootl.gameObject.name);
        }
    }
}
