using System;
using ObjCRuntime;

[assembly: LinkWith ("libGTM_NSData+zlib.a", LinkTarget.ArmV7 | LinkTarget.Simulator64 | LinkTarget.Simulator | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
