using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07FinalTask.N01RawData.Enumerations
{
    public static class LaptopEnums
    {
        public enum LaptopModel : uint
        {
            NotSpecified = 0,
            _15IRH8,
            _16ARX8H,
            _16IRX9,
            _83BY0000CD,
            A1VHG_051RU,
            AN16_41_R4MY,
            B7VF_037XRU,
            FA507NV_LP025,
            FA507UV_LP070,
            G614JV_N4071,
            G614JZ_N4125,
            GU604VI_N4034W,
            GU605MI_QR077,
            GV601VI_NL018W,
            H7606WI_ME145X,
            K3605ZV_N1028,
            N6506MV_MA113,
            PHN16_72_72NX
        }
        public enum LaptopScreenSize : byte
        {
            NotSpecified = 0,
            _13_3 = 133,
            _14 = 140,
            _15_6 = 156,
            _16 = 160,
            _17_3 = 173,
            _18 = 180
        }

        // --------------------------------------

        public enum LaptopProcessor : uint
        {
            NotSpecified = 0,
            AMD_Ryzen_5_7535HS,
            AMD_Ryzen_7_7840H,
            AMD_Ryzen_7_8845HS,
            AMD_Ryzen_9_7945HX,
            AMD_Ryzen_AI_9_HX_370,
            Intel_Core_i5_12500H,
            Intel_Core_i7_13620H,
            Intel_Core_i7_13650HX,
            Intel_Core_i7_14650HX,
            Intel_Core_i7_14700HX,
            Intel_Core_i9_13900H,
            Intel_Core_i9_13905H,
            Intel_Core_i9_13980HX,
            Intel_Core_Ultra_7_155H,
            Intel_Core_Ultra_9_185H
        }
        public static string LaptopProcessorToString(LaptopProcessor laptopProcessor)
        {
            switch (laptopProcessor)
            {
                case LaptopProcessor.AMD_Ryzen_5_7535HS: return "AMD Ryzen 5 7535HS";
                case LaptopProcessor.AMD_Ryzen_7_7840H: return "AMD Ryzen 7 7840H";
                case LaptopProcessor.AMD_Ryzen_7_8845HS: return "AMD Ryzen 7 8845HS";
                case LaptopProcessor.AMD_Ryzen_9_7945HX: return "AMD Ryzen 9 7945HX";
                case LaptopProcessor.AMD_Ryzen_AI_9_HX_370: return "AMD Ryzen AI 9 HX 370";
                case LaptopProcessor.Intel_Core_i5_12500H: return "Intel Core i5 12500H";
                case LaptopProcessor.Intel_Core_i7_13620H: return "Intel Core i7 13620H";
                case LaptopProcessor.Intel_Core_i7_13650HX: return "Intel Core i7 13650HX";
                case LaptopProcessor.Intel_Core_i7_14650HX: return "Intel Core i7 14650HX";
                case LaptopProcessor.Intel_Core_i7_14700HX: return "Intel Core i7 14700HX";
                case LaptopProcessor.Intel_Core_i9_13900H: return "Intel Core i9 13900H";
                case LaptopProcessor.Intel_Core_i9_13905H: return "Intel Core i9 13905H";
                case LaptopProcessor.Intel_Core_i9_13980HX: return "Intel Core i9 13980HX";
                case LaptopProcessor.Intel_Core_Ultra_7_155H: return "Intel Core Ultra 7 155H";
                case LaptopProcessor.Intel_Core_Ultra_9_185H: return "Intel Core Ultra 9 185H";
                default: return "Not specified";
            }
        }

        // --------------------------------------

        public enum LaptopRAMSize : byte
        {
            NotSpecified = 0,
            _8 = 8,
            _16 = 16,
            _24 = 24,
            _32 = 32,
            _64 = 64
        }

        // --------------------------------------

        public enum LaptopGPU : byte
        {
            NotSpecified = 0,
            GeForceRTX4060,
            GeForceRTX4070,
            GeForceRTX4080,
            GeForceRTX4090
        }
        public static string LaptopGPUToString(LaptopGPU laptopGPU)
        {
            switch (laptopGPU)
            {
                case LaptopGPU.GeForceRTX4060: return "GeForce RTX 4060";
                case LaptopGPU.GeForceRTX4070: return "GeForce RTX 4070";
                case LaptopGPU.GeForceRTX4080: return "GeForce RTX 4080";
                case LaptopGPU.GeForceRTX4090: return "GeForce RTX 4090";
                default: return "Not specified";
            }
        }

        // --------------------------------------

        public enum LaptopOperatingSystem : byte
        {
            NotSpecified = 0,
            NoOS,
            Windows11Home,
            Windows11Professional,
            Linux
        }
        public static string LaptopOperatingSystemToString(LaptopOperatingSystem laptopOperatingSystem)
        {
            switch (laptopOperatingSystem)
            {
                case LaptopOperatingSystem.NoOS: return "No OS";
                case LaptopOperatingSystem.Windows11Home: return "Windows 11 Home";
                case LaptopOperatingSystem.Windows11Professional: return "Windows 11 Professional";
                case LaptopOperatingSystem.Linux: return "Linux";
                default: return "Not specified";
            }
        }

        // --------------------------------------

        public enum LaptopStorageType : byte
        {
            NotSpecified = 0,
            SSD,
            HDD,
            HDDandSSD
        }
        public enum LaptopStorageCapacity : uint
        {
            NotSpecified = 0,
            _128 = 128,
            _256 = 256,
            _512 = 512,
            _1000 = 1000,
            _1024 = 1024,
            _2000 = 2000
        }
    }
}
