﻿using System.Drawing;
using BetterGenshinImpact.Core.Recognition;
using OpenCvSharp;

namespace BetterGenshinImpact.GameTask.AutoPick.Assets
{
    public class AutoPickAssets
    {
        public RecognitionObject FRo;
        public RecognitionObject ChatIconRo;
        public RecognitionObject SettingsIconRo;

        public AutoPickAssets()
        {
            var info = TaskContext.Instance().SystemInfo;
            FRo = new RecognitionObject
            {
                Name = "F",
                RecognitionType = RecognitionTypes.TemplateMatch,
                TemplateImageMat = GameTaskManager.LoadAssetImage("AutoPick", "F.png"),
                RegionOfInterest = new Rect(info.CaptureAreaRect.Width / 2,
                    (int)(330 * info.AssetScale),
                    info.CaptureAreaRect.Width - info.CaptureAreaRect.Width / 2,
                    (int)(420 * info.AssetScale)),
                DrawOnWindow = false
            }.InitTemplate();

            ChatIconRo = new RecognitionObject
            {
                Name = "ChatIcon",
                RecognitionType = RecognitionTypes.TemplateMatch,
                TemplateImageMat = GameTaskManager.LoadAssetImage("AutoSkip", "icon_option.png"),
                DrawOnWindow = false,
                DrawOnWindowPen = new Pen(Color.Chocolate, 2)
            }.InitTemplate();
            SettingsIconRo = new RecognitionObject
            {
                Name = "SettingsIcon",
                RecognitionType = RecognitionTypes.TemplateMatch,
                TemplateImageMat = GameTaskManager.LoadAssetImage("AutoPick", "icon_settings.png"),
                DrawOnWindow = false,
                DrawOnWindowPen = new Pen(Color.Chocolate, 2)
            }.InitTemplate();
        }
    }
}