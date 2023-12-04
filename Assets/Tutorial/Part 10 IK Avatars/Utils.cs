using Oculus.Interaction.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static string[] OculusHandSidePrefix = { "l_", "r_" };
    public static string[] AvatarHandSidePrefix = { "LeftHand", "RightHand" };
    public static string OculusHandBonePrefix = "b_";

    public static string[] OculusHandBoneNames =
    {
            "wrist",
            "forearm_stub",
            "thumb0",
            "thumb1",
            "thumb2",
            "thumb3",
            "index1",
            "index2",
            "index3",
            "middle1",
            "middle2",
            "middle3",
            "ring1",
            "ring2",
            "ring3",
            "pinky0",
            "pinky1",
            "pinky2",
            "pinky3"
    };

    public static string[] AvatarHandBoneNames =
    {
        "",
        "NA",
        "NA",
        "Thumb1",
        "Thumb2",
        "Thumb3",
        "Index1",
        "Index2",
        "Index3",
        "Middle1",
        "Middle2",
        "Middle3",
        "Ring1",
        "Ring2",
        "Ring3",
        "NA",
        "Pinky1",
        "Pinky2",
        "Pinky3"
    };

    public static string[] OculusHandFingerNames =
    {
            "thumb",
            "index",
            "middle",
            "ring",
            "pinky"
    };

    public static string OculusBoneNameFromHandJointId(Handedness handedness, HandJointId handJointId)
    {
        if (handJointId >= HandJointId.HandThumbTip && handJointId <= HandJointId.HandPinkyTip)
        {
            return OculusHandSidePrefix[(int)handedness] + OculusHandFingerNames[(int)handJointId - (int)HandJointId.HandThumbTip] + "_finger_tip_marker";
        }
        else
        {
            return OculusHandBonePrefix + OculusHandSidePrefix[(int)handedness] + OculusHandBoneNames[(int)handJointId];
        }
    }

    public static string AvatarBoneNameFromHandJointId(Handedness handedness, HandJointId handJointId)
    {
        if ((int)handJointId > AvatarHandBoneNames.Length)
        {
            return "";
        }
        else if (AvatarHandBoneNames[(int)handJointId] != "NA")
        {
            return AvatarHandSidePrefix[(int)handedness] + AvatarHandBoneNames[(int)handJointId];
        }
        else
        {
            return "";
        }
    }

   public static void CopyTransform(Transform source, Transform target, bool useLocal = false)
    {
        if (useLocal)
        {
            target.localPosition = source.localPosition;
            target.localRotation = source.localRotation;
            target.localScale = source.localScale;
        }
        else
        {
            target.position = source.position;
            target.rotation = source.rotation;
            target.localScale = source.localScale;
        }
    }
}
