using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07FinalTask.N01RawData.Enumerations
{
    public static class MonitorEnums
    {
        public enum MonitorModel : uint
        {
            NotSpecified = 0,
            _275QF,
            _27GN800_B,
            _321URX_QD_OLED,
            _32GS95UE_B,
            _341CQPX_QD_OLED,
            _342C_QD_OLED,
            _38WR85QC_W,
            C34G55TWWI,
            CB342CKsmiiphzx,
            G80SD,
            M80C,
            MPG341QR,
            PA279CRV,
            PG32UCDM,
            PG38UQ,
            S25BG400EI,
            S27B800PXI,
            S27DG600SI,
            VG27AQ1A,
            X32Xbmiipphuzx,
            XG27ACS_W,
            XV272KLVbmiipruzx
        }

        public enum MonitorScreenSize : uint
        {
            NotSpecified = 0,
            _21_4 = 214,
            _23_8 = 238,
            _24_5 = 245,
            _25 = 250,
            _26_5 = 265,
            _27 = 270,
            _28 = 280,
            _29 = 290,
            _30 = 300,
            _31_5 = 315,
            _32 = 320,
            _34 = 340,
            _37_5 = 375,
            _38 = 380,
            _38_5 = 385,
            _40 = 400,
            _47_5 = 475,
            _49 = 490,
            _55 = 550
        }

        public enum MaxResolution : uint
        {
            NotSpecified = 0,
            _1920x1080 = 19201080,
            _2560x1440 = 25601440,
            _3440x1440 = 34401440,
            _3840x1600 = 38401600,
            _3840x2160 = 38402160,
            _5120x1440 = 51201440
        }

        public enum RefreshRate : uint
        {
            NotSpecified = 0,
            _60 = 60,
            _75 = 75,
            _120 = 120,
            _144 = 144,
            _160 = 160,
            _165 = 165,
            _170 = 170,
            _175 = 175,
            _180 = 180,
            _200 = 200,
            _240 = 240,
            _250 = 250,
            _260 = 260,
            _270 = 270,
            _280 = 280,
            _300 = 300,
            _310 = 310,
            _360 = 360,
            _540 = 540
        }

        // --------------------------------------

        public enum VideoInputs : byte
        {
            NotSpecified = 0,
            DisplayPort12_HDMI20,
            DisplayPort14_HDMI20,
            DisplayPort14_HDMI20_USBTypeC,
            DisplayPort14_HDMI20_HDMI21_USBTypeC,
            DisplayPort14_HDMI21,
            DisplayPort14_HDMI21_USBTypeC,
            DisplayPort14a_HDMI21_USBTypeC,
            HDMI20_USBTypeC
        }

        public static string VideoInputsToString(VideoInputs videoInputs)
        {
            switch (videoInputs)
            {
                case VideoInputs.DisplayPort12_HDMI20: return "DisplayPort 1.2, HDMI 2.0";
                case VideoInputs.DisplayPort14_HDMI20: return "DisplayPort 1.4, HDMI 2.0";
                case VideoInputs.DisplayPort14_HDMI20_USBTypeC: return "DisplayPort 1.4, HDMI 2.0, USB Type-C";
                case VideoInputs.DisplayPort14_HDMI20_HDMI21_USBTypeC: return "DisplayPort 1.4, HDMI 2.0, HDMI 2.1, USB Type-C";
                case VideoInputs.DisplayPort14_HDMI21: return "DisplayPort 1.4, HDMI 2.1";
                case VideoInputs.DisplayPort14_HDMI21_USBTypeC: return "DisplayPort 1.4, HDMI 2.1, USB Type-C";
                case VideoInputs.DisplayPort14a_HDMI21_USBTypeC: return "DisplayPort 1.4a, HDMI 2.1, USB Type-C";
                case VideoInputs.HDMI20_USBTypeC: return "HDMI 2.0, USB Type-C";
                default: return "Not specified";
            }
        }

        // --------------------------------------

        public enum DisplayType : byte
        {
            NotSpecified = 0,
            IPS,
            OLED,
            TN,
            VA
        }

        // --------------------------------------

        public enum AspectRatio : uint
        {
            NotSpecified = 0,
            _4_3 = 43,
            _5_4 = 54,
            _16_9 = 169,
            _16_10 = 1610,
            _21_9 = 219,
            _32_9 = 329
        }

        public static string AspectRatioToString(AspectRatio aspectRatio)
        {
            switch ((uint)aspectRatio)
            {
                case 43: return "4:3";
                case 54: return "5:4";
                case 169: return "16:9";
                case 1610: return "16:10";
                case 219: return "21:9";
                case 329: return "32:9";
                default: return "Not specified";
            }
        }

        // --------------------------------------

        public enum ContrastRatio : uint
        {
            NotSpecified = 0,
            _1000_1 = 10001,
            _1330_1 = 13001,
            _2500_1 = 25001,
            _3000_1 = 30001,
            _4000_1 = 40001,
            _1000000_1 = 10000001,
            _1200000_1 = 12000001,
            _1500000_1 = 15000001
        }

        public static string ContrastRatioToString(ContrastRatio contrastRatio)
        {
            switch ((uint)contrastRatio)
            {
                case 10001: return "1000:1";
                case 13001: return "1300:1";
                case 25001: return "2500:1";
                case 30001: return "3000:1";
                case 40001: return "4000:1";
                case 10000001: return "1000000 : 1";
                case 12000001: return "1200000 : 1";
                case 15000001: return "1500000 : 1";
                default: return "Not specified";
            }
        }

        // --------------------------------------

        public enum Brightness : uint
        {
            NotSpecified = 0,
            _250 = 250,
            _280 = 280,
            _300 = 300,
            _320 = 320,
            _350 = 350,
            _360 = 360,
            _370 = 370,
            _400 = 400,
            _420 = 420,
            _450 = 450,
            _500 = 500,
            _550 = 550,
            _600 = 600,
            _750 = 750,
            _900 = 900,
            _1000 = 1000,
            _1300 = 1300,
            _1600 = 1600
        }

        // --------------------------------------

        public enum PixelResponseTime : uint
        {
            NotSpecified = 0,
            _0_03 = 1003,
            _0_1 = 101,
            _0_5 = 105,
            _1 = 1,
            _4 = 4,
            _5 = 5,
        }

        public static string PixelResponseTimeToString(PixelResponseTime pixelResponseTime)
        {
            switch (pixelResponseTime)
            {
                case PixelResponseTime._0_03: return "0.03 ms";
                case PixelResponseTime._0_1: return "0.1 ms";
                case PixelResponseTime._0_5: return "0.5 ms";
                case PixelResponseTime._1: return "1 ms";
                case PixelResponseTime._4: return "4 ms";
                case PixelResponseTime._5: return "5 ms";
                default: return "Not specified";
            }
        }

        // --------------------------------------
    }
}
