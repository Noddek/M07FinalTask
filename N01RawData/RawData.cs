
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using M07FinalTask.N01RawData.Enumerations;
using M07FinalTask.N02Products;
using M07FinalTask.N03Customers;
using M07FinalTask.N04Delivery;
using M07FinalTask.N05Orders;
using M07FinalTask.N11Contacts;
using static M07FinalTask.N01RawData.Enumerations.CommonEnums;
using static M07FinalTask.N01RawData.Enumerations.MonitorEnums;

namespace M07FinalTask.N01RawData;
/// <summary>
/// This is the static class that inputs the raw data for the program
/// </summary>
public static class RawData
{
    // METHODS

    // RAW DATA FOR LAPTOPS -----------------------------------------------------
    // ----------------------------------------------------------------------------

    // Method 1.

    /// <summary>
    /// The method creates an array for the initial laptop nomenclature
    /// </summary>
    /// <returns>Array of laptops</returns>
    public static Laptop[] CreateLaptopsForProductNomenclature()
    {
        Laptop[] laptopArrayForNomenclature = new Laptop[100];

        // ASUS --------------------------

        laptopArrayForNomenclature[0] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "TUF Gaming",
                "Gaming Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.FA507UV_LP070,
                LaptopEnums.LaptopScreenSize._15_6,
                LaptopEnums.LaptopProcessor.AMD_Ryzen_7_8845HS,
                LaptopEnums.LaptopRAMSize._16,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._512
            );
        laptopArrayForNomenclature[1] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "ROG Zephyrus G16",
                "Gaming Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.GU605MI_QR077,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_Ultra_7_155H,
                LaptopEnums.LaptopRAMSize._32,
                LaptopEnums.LaptopGPU.GeForceRTX4070,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );
        laptopArrayForNomenclature[2] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "VivoBook Pro 15",
                "Business & Gaming Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.N6506MV_MA113,
                LaptopEnums.LaptopScreenSize._15_6,
                LaptopEnums.LaptopProcessor.Intel_Core_Ultra_9_185H,
                LaptopEnums.LaptopRAMSize._24,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );
        laptopArrayForNomenclature[3] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "ProArt",
                "Designing Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.H7606WI_ME145X,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.AMD_Ryzen_AI_9_HX_370,
                LaptopEnums.LaptopRAMSize._64,
                LaptopEnums.LaptopGPU.GeForceRTX4070,
                LaptopEnums.LaptopOperatingSystem.Windows11Home,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._2000
            );
        laptopArrayForNomenclature[4] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "ROG Strix G16",
                "Gaming Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.G614JZ_N4125,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_i9_13980HX,
                LaptopEnums.LaptopRAMSize._32,
                LaptopEnums.LaptopGPU.GeForceRTX4080,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );
        laptopArrayForNomenclature[5] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "TUF Gaming",
                "Gaming Laptop",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.FA507NV_LP025,
                LaptopEnums.LaptopScreenSize._15_6,
                LaptopEnums.LaptopProcessor.AMD_Ryzen_5_7535HS,
                LaptopEnums.LaptopRAMSize._16,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._512
            );
        laptopArrayForNomenclature[6] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "ROG Strix G16",
                "Gaming Laptop",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.G614JV_N4071,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_i7_13650HX,
                LaptopEnums.LaptopRAMSize._16,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );
        laptopArrayForNomenclature[7] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "ROG Flow X16",
                "Ultra-thin Gaming Laptop",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.GV601VI_NL018W,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_i9_13900H,
                LaptopEnums.LaptopRAMSize._32,
                LaptopEnums.LaptopGPU.GeForceRTX4070,
                LaptopEnums.LaptopOperatingSystem.Windows11Home,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );
        laptopArrayForNomenclature[8] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "VivoBook 16X",
                "Business & Gaming Laptop",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.K3605ZV_N1028,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_i5_12500H,
                LaptopEnums.LaptopRAMSize._16,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._512
            );
        laptopArrayForNomenclature[9] = new Laptop
            (
                Brand.ASUS,
                ProductCategory.Laptop,
                "ROG Zephyrus M16",
                "Gaming Laptop",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.GU604VI_N4034W,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_i9_13900H,
                LaptopEnums.LaptopRAMSize._32,
                LaptopEnums.LaptopGPU.GeForceRTX4070,
                LaptopEnums.LaptopOperatingSystem.Windows11Home,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );

        // Acer --------------------------

        laptopArrayForNomenclature[10] = new Laptop
            (
                Brand.Acer,
                ProductCategory.Laptop,
                "Predator Helios Neo",
                "Gaming Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.PHN16_72_72NX,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_i7_14700HX,
                LaptopEnums.LaptopRAMSize._16,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.Windows11Home,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1024
            );
        laptopArrayForNomenclature[11] = new Laptop
            (
                Brand.Acer,
                ProductCategory.Laptop,
                "Nitro 16",
                "Gaming Laptop",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.AN16_41_R4MY,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.AMD_Ryzen_7_7840H,
                LaptopEnums.LaptopRAMSize._16,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );

        // MSI --------------------------

        laptopArrayForNomenclature[12] = new Laptop
            (
                Brand.MSI,
                ProductCategory.Laptop,
                "Creator 16 AI Studio",
                "Designer Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.A1VHG_051RU,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_Ultra_9_185H,
                LaptopEnums.LaptopRAMSize._32,
                LaptopEnums.LaptopGPU.GeForceRTX4080,
                LaptopEnums.LaptopOperatingSystem.Windows11Professional,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );
        laptopArrayForNomenclature[13] = new Laptop
            (
                Brand.MSI,
                ProductCategory.Laptop,
                "Thin A15",
                "Gaming Laptop",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel.B7VF_037XRU,
                LaptopEnums.LaptopScreenSize._15_6,
                LaptopEnums.LaptopProcessor.AMD_Ryzen_5_7535HS,
                LaptopEnums.LaptopRAMSize._16,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._512
            );

        // Lenovo --------------------------

        laptopArrayForNomenclature[14] = new Laptop
            (
                Brand.Lenovo,
                ProductCategory.Laptop,
                "Yoga Pro 16S",
                "Business & Designing Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel._83BY0000CD,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_i9_13905H,
                LaptopEnums.LaptopRAMSize._32,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.Windows11Home,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );
        laptopArrayForNomenclature[15] = new Laptop
            (
                Brand.Lenovo,
                ProductCategory.Laptop,
                "Legion Pro 5",
                "Gaming Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel._16IRX9,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.Intel_Core_i7_14650HX,
                LaptopEnums.LaptopRAMSize._32,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );
        laptopArrayForNomenclature[16] = new Laptop
            (
                Brand.Lenovo,
                ProductCategory.Laptop,
                "Legion Pro 7",
                "Gaming Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel._16ARX8H,
                LaptopEnums.LaptopScreenSize._16,
                LaptopEnums.LaptopProcessor.AMD_Ryzen_9_7945HX,
                LaptopEnums.LaptopRAMSize._32,
                LaptopEnums.LaptopGPU.GeForceRTX4090,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._1000
            );
        laptopArrayForNomenclature[17] = new Laptop
            (
                Brand.Lenovo,
                ProductCategory.Laptop,
                "LOQ",
                "Gaming Laptop",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                LaptopEnums.LaptopModel._15IRH8,
                LaptopEnums.LaptopScreenSize._15_6,
                LaptopEnums.LaptopProcessor.Intel_Core_i7_13620H,
                LaptopEnums.LaptopRAMSize._16,
                LaptopEnums.LaptopGPU.GeForceRTX4060,
                LaptopEnums.LaptopOperatingSystem.NoOS,
                LaptopEnums.LaptopStorageType.SSD,
                LaptopEnums.LaptopStorageCapacity._512
            );

        return laptopArrayForNomenclature;
    }






    // RAW DATA FOR MONITORS -------------------------------------------------------
    // -----------------------------------------------------------------------------

    // Method 2.

    /// <summary>
    /// The method creates an array for the initial monitor nomenclature
    /// </summary>
    /// <returns>Array of computer monitors</returns>
    public static N02Products.Monitor[] CreateMonitorsForProductNomenclature()
    {
        N02Products.Monitor[] monitorArrayForNomenclature = new N02Products.Monitor[100];

        // Samsung --------------------------

        monitorArrayForNomenclature[0] = new N02Products.Monitor
            (
                Brand.Samsung,
                ProductCategory.Monitor,
                "Odyssey OLED G6",
                "Gaming Monitor",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                MonitorModel.S27DG600SI,
                MonitorScreenSize._27,
                MaxResolution._2560x1440,
                RefreshRate._360,
                VideoInputs.DisplayPort14_HDMI21,
                DisplayType.OLED,
                AspectRatio._16_9,
                ContrastRatio._1000000_1,
                Brightness._250,
                PixelResponseTime._0_03
            );
        monitorArrayForNomenclature[1] = new N02Products.Monitor
            (
                Brand.Samsung,
                ProductCategory.Monitor,
                "Odyssey G4",
                "Gaming Monitor",
                ReleaseYear._2022,
                UnitOfMeasurement.Pieces,
                MonitorModel.S25BG400EI,
                MonitorScreenSize._25,
                MaxResolution._1920x1080,
                RefreshRate._240,
                VideoInputs.DisplayPort12_HDMI20,
                DisplayType.IPS,
                AspectRatio._16_9,
                ContrastRatio._1000_1,
                Brightness._400,
                PixelResponseTime._1
            );
        monitorArrayForNomenclature[2] = new N02Products.Monitor
            (
                Brand.Samsung,
                ProductCategory.Monitor,
                "Odyssey OLED G8",
                "Gaming Monitor",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                MonitorModel.G80SD,
                MonitorScreenSize._31_5,
                MaxResolution._3840x2160,
                RefreshRate._240,
                VideoInputs.DisplayPort14_HDMI21,
                DisplayType.OLED,
                AspectRatio._16_9,
                ContrastRatio._1000000_1,
                Brightness._250,
                PixelResponseTime._0_03
            );
        monitorArrayForNomenclature[3] = new N02Products.Monitor
            (
                Brand.Samsung,
                ProductCategory.Monitor,
                "Odyssey G5",
                "Gaming Monitor",
                ReleaseYear._2020,
                UnitOfMeasurement.Pieces,
                MonitorModel.C34G55TWWI,
                MonitorScreenSize._34,
                MaxResolution._3440x1440,
                RefreshRate._165,
                VideoInputs.DisplayPort14_HDMI20,
                DisplayType.VA,
                AspectRatio._21_9,
                ContrastRatio._2500_1,
                Brightness._250,
                PixelResponseTime._1
            );
        monitorArrayForNomenclature[4] = new N02Products.Monitor
            (
                Brand.Samsung,
                ProductCategory.Monitor,
                "ViewFinity S8",
                "Monitor for business professionals, content creators, and graphic designers",
                ReleaseYear._2022,
                UnitOfMeasurement.Pieces,
                MonitorModel.S27B800PXI,
                MonitorScreenSize._27,
                MaxResolution._3840x2160,
                RefreshRate._60,
                VideoInputs.DisplayPort14_HDMI20_USBTypeC,
                DisplayType.IPS,
                AspectRatio._16_9,
                ContrastRatio._1000_1,
                Brightness._350,
                PixelResponseTime._5
            );
        monitorArrayForNomenclature[5] = new N02Products.Monitor
            (
                Brand.Samsung,
                ProductCategory.Monitor,
                "Smart Monitor M8",
                "Monitor for studio apartment dwellers, both a television and a computer monitor",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                MonitorModel.M80C,
                MonitorScreenSize._32,
                MaxResolution._3840x2160,
                RefreshRate._60,
                VideoInputs.HDMI20_USBTypeC,
                DisplayType.VA,
                AspectRatio._16_9,
                ContrastRatio._3000_1,
                Brightness._400,
                PixelResponseTime._4
            );

        // LG --------------------------

        monitorArrayForNomenclature[6] = new N02Products.Monitor
            (
                Brand.LG,
                ProductCategory.Monitor,
                "UltraGear",
                "Gaming Monitor",
                ReleaseYear._2020,
                UnitOfMeasurement.Pieces,
                MonitorModel._27GN800_B,
                MonitorScreenSize._27,
                MaxResolution._2560x1440,
                RefreshRate._144,
                VideoInputs.DisplayPort14_HDMI20,
                DisplayType.IPS,
                AspectRatio._16_9,
                ContrastRatio._1000_1,
                Brightness._350,
                PixelResponseTime._1
            );
        monitorArrayForNomenclature[7] = new N02Products.Monitor
            (
                Brand.LG,
                ProductCategory.Monitor,
                "UltraWide",
                "Monitor for Content Creation and Gaming",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                MonitorModel._38WR85QC_W,
                MonitorScreenSize._37_5,
                MaxResolution._3840x1600,
                RefreshRate._144,
                VideoInputs.DisplayPort14_HDMI21_USBTypeC,
                DisplayType.IPS,
                AspectRatio._21_9,
                ContrastRatio._1000_1,
                Brightness._600,
                PixelResponseTime._1
            );
        monitorArrayForNomenclature[8] = new N02Products.Monitor
            (
                Brand.LG,
                ProductCategory.Monitor,
                "UltraGear OLED",
                "Gaming Monitor",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                MonitorModel._32GS95UE_B,
                MonitorScreenSize._31_5,
                MaxResolution._3840x2160,
                RefreshRate._240,
                VideoInputs.DisplayPort14_HDMI21,
                DisplayType.OLED,
                AspectRatio._16_9,
                ContrastRatio._1200000_1,
                Brightness._1300,
                PixelResponseTime._0_03
            );

        // ASUS --------------------------

        monitorArrayForNomenclature[9] = new N02Products.Monitor
            (
                Brand.ASUS,
                ProductCategory.Monitor,
                "TUF Gaming",
                "Gaming Monitor",
                ReleaseYear._2020,
                UnitOfMeasurement.Pieces,
                MonitorModel.VG27AQ1A,
                MonitorScreenSize._27,
                MaxResolution._2560x1440,
                RefreshRate._170,
                VideoInputs.DisplayPort12_HDMI20,
                DisplayType.IPS,
                AspectRatio._16_9,
                ContrastRatio._1000_1,
                Brightness._250,
                PixelResponseTime._1
            );
        monitorArrayForNomenclature[10] = new N02Products.Monitor
            (
                Brand.ASUS,
                ProductCategory.Monitor,
                "ROG Swift",
                "Gaming Monitor",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                MonitorModel.PG38UQ,
                MonitorScreenSize._38,
                MaxResolution._3840x2160,
                RefreshRate._144,
                VideoInputs.DisplayPort14_HDMI21,
                DisplayType.IPS,
                AspectRatio._16_9,
                ContrastRatio._1000_1,
                Brightness._600,
                PixelResponseTime._1
            );
        monitorArrayForNomenclature[11] = new N02Products.Monitor
            (
                Brand.ASUS,
                ProductCategory.Monitor,
                "ROG Swift OLED",
                "Gaming Monitor",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                MonitorModel.PG32UCDM,
                MonitorScreenSize._31_5,
                MaxResolution._3840x2160,
                RefreshRate._240,
                VideoInputs.DisplayPort14_HDMI20_HDMI21_USBTypeC,
                DisplayType.OLED,
                AspectRatio._16_9,
                ContrastRatio._1500000_1,
                Brightness._1000,
                PixelResponseTime._0_03
            );
        monitorArrayForNomenclature[12] = new N02Products.Monitor
            (
                Brand.ASUS,
                ProductCategory.Monitor,
                "ProArt",
                "Designing Monitor",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                MonitorModel.PA279CRV,
                MonitorScreenSize._27,
                MaxResolution._3840x2160,
                RefreshRate._60,
                VideoInputs.DisplayPort14_HDMI20_USBTypeC,
                DisplayType.IPS,
                AspectRatio._16_9,
                ContrastRatio._1000_1,
                Brightness._400,
                PixelResponseTime._5
            );
        monitorArrayForNomenclature[13] = new N02Products.Monitor
            (
                Brand.ASUS,
                ProductCategory.Monitor,
                "ROG Strix",
                "Gaming Monitor",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                MonitorModel.XG27ACS_W,
                MonitorScreenSize._27,
                MaxResolution._2560x1440,
                RefreshRate._180,
                VideoInputs.DisplayPort14_HDMI20_USBTypeC,
                DisplayType.IPS,
                AspectRatio._16_9,
                ContrastRatio._1000_1,
                Brightness._400,
                PixelResponseTime._1
            );

        // Acer --------------------------

        monitorArrayForNomenclature[14] = new N02Products.Monitor
            (
                Brand.Acer,
                ProductCategory.Monitor,
                "Nitro",
                "Gaming Monitor",
                ReleaseYear._2021,
                UnitOfMeasurement.Pieces,
                MonitorModel.XV272KLVbmiipruzx,
                MonitorScreenSize._27,
                MaxResolution._3840x2160,
                RefreshRate._160,
                VideoInputs.DisplayPort14_HDMI21_USBTypeC,
                DisplayType.IPS,
                AspectRatio._16_9,
                ContrastRatio._1000_1,
                Brightness._600,
                PixelResponseTime._1
            );
        monitorArrayForNomenclature[15] = new N02Products.Monitor
            (
                Brand.Acer,
                ProductCategory.Monitor,
                "CB342CK",
                "Monitor for mixed usage",
                ReleaseYear._2019,
                UnitOfMeasurement.Pieces,
                MonitorModel.CB342CKsmiiphzx,
                MonitorScreenSize._34,
                MaxResolution._3440x1440,
                RefreshRate._75,
                VideoInputs.DisplayPort14_HDMI20,
                DisplayType.IPS,
                AspectRatio._21_9,
                ContrastRatio._1000_1,
                Brightness._250,
                PixelResponseTime._1
            );
        monitorArrayForNomenclature[16] = new N02Products.Monitor
            (
                Brand.Acer,
                ProductCategory.Monitor,
                "Predator",
                "Gaming Monitor",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                MonitorModel.X32Xbmiipphuzx,
                MonitorScreenSize._31_5,
                MaxResolution._3840x2160,
                RefreshRate._240,
                VideoInputs.DisplayPort14_HDMI21_USBTypeC,
                DisplayType.OLED,
                AspectRatio._16_9,
                ContrastRatio._1500000_1,
                Brightness._1000,
                PixelResponseTime._0_03
            );

        // MSI --------------------------

        monitorArrayForNomenclature[17] = new N02Products.Monitor
            (
                Brand.MSI,
                ProductCategory.Monitor,
                "MAG",
                "Gaming Monitor",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                MonitorModel._275QF,
                MonitorScreenSize._27,
                MaxResolution._2560x1440,
                RefreshRate._180,
                VideoInputs.DisplayPort14_HDMI20,
                DisplayType.IPS,
                AspectRatio._16_9,
                ContrastRatio._1000_1,
                Brightness._300,
                PixelResponseTime._1
            );
        monitorArrayForNomenclature[18] = new N02Products.Monitor
            (
                Brand.MSI,
                ProductCategory.Monitor,
                "MPG",
                "Gaming Monitor",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                MonitorModel._321URX_QD_OLED,
                MonitorScreenSize._31_5,
                MaxResolution._3840x2160,
                RefreshRate._240,
                VideoInputs.DisplayPort14a_HDMI21_USBTypeC,
                DisplayType.OLED,
                AspectRatio._16_9,
                ContrastRatio._1500000_1,
                Brightness._1000,
                PixelResponseTime._0_03
            );
        monitorArrayForNomenclature[19] = new N02Products.Monitor
            (
                Brand.MSI,
                ProductCategory.Monitor,
                "MPG",
                "Gaming Monitor",
                ReleaseYear._2024,
                UnitOfMeasurement.Pieces,
                MonitorModel._341CQPX_QD_OLED,
                MonitorScreenSize._34,
                MaxResolution._3440x1440,
                RefreshRate._240,
                VideoInputs.DisplayPort14a_HDMI21_USBTypeC,
                DisplayType.OLED,
                AspectRatio._21_9,
                ContrastRatio._1500000_1,
                Brightness._1000,
                PixelResponseTime._0_03
            );
        monitorArrayForNomenclature[20] = new N02Products.Monitor
            (
                Brand.MSI,
                ProductCategory.Monitor,
                "MEG",
                "Gaming Monitor",
                ReleaseYear._2023,
                UnitOfMeasurement.Pieces,
                MonitorModel._342C_QD_OLED,
                MonitorScreenSize._34,
                MaxResolution._3440x1440,
                RefreshRate._175,
                VideoInputs.DisplayPort14_HDMI21_USBTypeC,
                DisplayType.OLED,
                AspectRatio._21_9,
                ContrastRatio._1000000_1,
                Brightness._1000,
                PixelResponseTime._0_1
            );
        monitorArrayForNomenclature[21] = new N02Products.Monitor
            (
                Brand.MSI,
                ProductCategory.Monitor,
                "Optix",
                "Gaming Monitor",
                ReleaseYear._2021,
                UnitOfMeasurement.Pieces,
                MonitorModel.MPG341QR,
                MonitorScreenSize._34,
                MaxResolution._3440x1440,
                RefreshRate._144,
                VideoInputs.DisplayPort14_HDMI20_USBTypeC,
                DisplayType.IPS,
                AspectRatio._21_9,
                ContrastRatio._1000_1,
                Brightness._550,
                PixelResponseTime._4
            );

        return monitorArrayForNomenclature;
    }






    // RAW DATA FOR THE STOCK -----------------------------------------------------
    // ----------------------------------------------------------------------------

    // Method 3.

    /// <summary>
    /// The method creates an array for the ProductsInStock class
    /// </summary>
    /// <returns>Array of instances of ProductInStock class </returns>
    public static ProductInStock[] CreateProductsForProductsInStock()
    {
        ProductInStock?[] allRawProductsInStock = new ProductInStock[300];

        // LAPTOPS --------------------------
        // ----------------------------------

        // ASUS --------------------------
        allRawProductsInStock[0] = ProductInStock.CheckAndCreateNewProductInStock(1001, ProductCondition.New, 125000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[1] = ProductInStock.CheckAndCreateNewProductInStock(1001, ProductCondition.NewPackageWasOpened, 125000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[2] = ProductInStock.CheckAndCreateNewProductInStock(1001, ProductCondition.Refurbished, 125000, 15, VATPercentage._20, 1, true);

        allRawProductsInStock[3] = ProductInStock.CheckAndCreateNewProductInStock(1002, ProductCondition.New, 220000, 0, VATPercentage._20, 5, true);
        allRawProductsInStock[4] = ProductInStock.CheckAndCreateNewProductInStock(1002, ProductCondition.NewPackageWasOpened, 220000, 5, VATPercentage._20, 1, true);

        allRawProductsInStock[5] = ProductInStock.CheckAndCreateNewProductInStock(1003, ProductCondition.New, 175000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[6] = ProductInStock.CheckAndCreateNewProductInStock(1003, ProductCondition.NewPackageWasOpened, 175000, 5, VATPercentage._20, 1, true);

        allRawProductsInStock[7] = ProductInStock.CheckAndCreateNewProductInStock(1004, ProductCondition.New, 300000, 0, VATPercentage._20, 2, true);

        allRawProductsInStock[8] = ProductInStock.CheckAndCreateNewProductInStock(1005, ProductCondition.New, 280000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[9] = ProductInStock.CheckAndCreateNewProductInStock(1005, ProductCondition.NewPackageWasOpened, 280000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[10] = ProductInStock.CheckAndCreateNewProductInStock(1005, ProductCondition.Refurbished, 280000, 10, VATPercentage._20, 1, true);

        allRawProductsInStock[11] = ProductInStock.CheckAndCreateNewProductInStock(1006, ProductCondition.New, 100000, 0, VATPercentage._20, 20, true);
        allRawProductsInStock[12] = ProductInStock.CheckAndCreateNewProductInStock(1006, ProductCondition.NewPackageWasOpened, 100000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[13] = ProductInStock.CheckAndCreateNewProductInStock(1006, ProductCondition.ForRepacking, 100000, 5, VATPercentage._20, 1, false);
        allRawProductsInStock[14] = ProductInStock.CheckAndCreateNewProductInStock(1006, ProductCondition.ForRefurbishment, 100000, 15, VATPercentage._20, 1, false);

        allRawProductsInStock[15] = ProductInStock.CheckAndCreateNewProductInStock(1007, ProductCondition.New, 165000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[16] = ProductInStock.CheckAndCreateNewProductInStock(1007, ProductCondition.NewPackageWasOpened, 165000, 5, VATPercentage._20, 1, true);
        allRawProductsInStock[17] = ProductInStock.CheckAndCreateNewProductInStock(1007, ProductCondition.Used, 165000, 20, VATPercentage._20, 1, true);

        allRawProductsInStock[18] = ProductInStock.CheckAndCreateNewProductInStock(1008, ProductCondition.New, 250000, 0, VATPercentage._20, 3, true);

        allRawProductsInStock[19] = ProductInStock.CheckAndCreateNewProductInStock(1009, ProductCondition.New, 100000, 0, VATPercentage._20, 15, true);
        allRawProductsInStock[20] = ProductInStock.CheckAndCreateNewProductInStock(1009, ProductCondition.NewPackageWasOpened, 100000, 5, VATPercentage._20, 2, true);

        allRawProductsInStock[21] = ProductInStock.CheckAndCreateNewProductInStock(1010, ProductCondition.New, 235000, 0, VATPercentage._20, 5, true);
        allRawProductsInStock[22] = ProductInStock.CheckAndCreateNewProductInStock(1010, ProductCondition.ForRepacking, 235000, 5, VATPercentage._20, 1, false);

        // Acer --------------------------
        allRawProductsInStock[23] = ProductInStock.CheckAndCreateNewProductInStock(1011, ProductCondition.New, 190000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[24] = ProductInStock.CheckAndCreateNewProductInStock(1011, ProductCondition.NewPackageWasOpened, 190000, 5, VATPercentage._20, 1, true);

        allRawProductsInStock[25] = ProductInStock.CheckAndCreateNewProductInStock(1012, ProductCondition.New, 140000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[26] = ProductInStock.CheckAndCreateNewProductInStock(1012, ProductCondition.Refurbished, 140000, 10, VATPercentage._20, 1, true);

        // MSI --------------------------
        allRawProductsInStock[27] = ProductInStock.CheckAndCreateNewProductInStock(1013, ProductCondition.New, 370000, 0, VATPercentage._20, 2, true);

        allRawProductsInStock[28] = ProductInStock.CheckAndCreateNewProductInStock(1014, ProductCondition.New, 100000, 0, VATPercentage._20, 20, true);
        allRawProductsInStock[29] = ProductInStock.CheckAndCreateNewProductInStock(1014, ProductCondition.NewPackageWasOpened, 100000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[30] = ProductInStock.CheckAndCreateNewProductInStock(1014, ProductCondition.Refurbished, 100000, 15, VATPercentage._20, 1, true);
        allRawProductsInStock[31] = ProductInStock.CheckAndCreateNewProductInStock(1014, ProductCondition.ForRepacking, 100000, 5, VATPercentage._20, 1, false);

        // Lenovo --------------------------
        allRawProductsInStock[32] = ProductInStock.CheckAndCreateNewProductInStock(1015, ProductCondition.New, 210000, 0, VATPercentage._20, 5, true);

        allRawProductsInStock[33] = ProductInStock.CheckAndCreateNewProductInStock(1016, ProductCondition.New, 210000, 0, VATPercentage._20, 5, true);
        allRawProductsInStock[34] = ProductInStock.CheckAndCreateNewProductInStock(1016, ProductCondition.NewPackageWasOpened, 210000, 5, VATPercentage._20, 1, true);

        allRawProductsInStock[35] = ProductInStock.CheckAndCreateNewProductInStock(1017, ProductCondition.New, 430000, 0, VATPercentage._20, 2, true);

        allRawProductsInStock[36] = ProductInStock.CheckAndCreateNewProductInStock(1018, ProductCondition.New, 140000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[37] = ProductInStock.CheckAndCreateNewProductInStock(1018, ProductCondition.NewPackageWasOpened, 140000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[38] = ProductInStock.CheckAndCreateNewProductInStock(1018, ProductCondition.ForRepacking, 140000, 5, VATPercentage._20, 1, false);
        allRawProductsInStock[39] = ProductInStock.CheckAndCreateNewProductInStock(1018, ProductCondition.ForRefurbishment, 140000, 15, VATPercentage._20, 1, false);


        // MONITORS --------------------------
        // -----------------------------------

        // Samsung --------------------------
        allRawProductsInStock[40] = ProductInStock.CheckAndCreateNewProductInStock(5001, ProductCondition.New, 90000, 0, VATPercentage._20, 5, true);
        allRawProductsInStock[41] = ProductInStock.CheckAndCreateNewProductInStock(5001, ProductCondition.NewPackageWasOpened, 90000, 5, VATPercentage._20, 1, true);

        allRawProductsInStock[42] = ProductInStock.CheckAndCreateNewProductInStock(5002, ProductCondition.New, 25000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[43] = ProductInStock.CheckAndCreateNewProductInStock(5002, ProductCondition.ForRepacking, 25000, 5, VATPercentage._20, 1, false);

        allRawProductsInStock[44] = ProductInStock.CheckAndCreateNewProductInStock(5003, ProductCondition.New, 130000, 0, VATPercentage._20, 5, true);
        allRawProductsInStock[45] = ProductInStock.CheckAndCreateNewProductInStock(5003, ProductCondition.NewPackageWasOpened, 130000, 5, VATPercentage._20, 1, true);

        allRawProductsInStock[46] = ProductInStock.CheckAndCreateNewProductInStock(5004, ProductCondition.New, 32000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[47] = ProductInStock.CheckAndCreateNewProductInStock(5004, ProductCondition.NewPackageWasOpened, 32000, 5, VATPercentage._20, 1, true);
        allRawProductsInStock[48] = ProductInStock.CheckAndCreateNewProductInStock(5004, ProductCondition.ForRepacking, 32000, 5, VATPercentage._20, 1, false);
        allRawProductsInStock[49] = ProductInStock.CheckAndCreateNewProductInStock(5004, ProductCondition.ForRefurbishment, 32000, 15, VATPercentage._20, 1, false);

        allRawProductsInStock[50] = ProductInStock.CheckAndCreateNewProductInStock(5005, ProductCondition.New, 45000, 0, VATPercentage._20, 5, true);

        allRawProductsInStock[51] = ProductInStock.CheckAndCreateNewProductInStock(5006, ProductCondition.New, 60000, 0, VATPercentage._20, 2, true);

        // LG --------------------------
        allRawProductsInStock[52] = ProductInStock.CheckAndCreateNewProductInStock(5007, ProductCondition.New, 23000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[53] = ProductInStock.CheckAndCreateNewProductInStock(5007, ProductCondition.NewPackageWasOpened, 23000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[54] = ProductInStock.CheckAndCreateNewProductInStock(5007, ProductCondition.Refurbished, 23000, 15, VATPercentage._20, 1, true);

        allRawProductsInStock[55] = ProductInStock.CheckAndCreateNewProductInStock(5008, ProductCondition.New, 120000, 0, VATPercentage._20, 5, true);

        allRawProductsInStock[56] = ProductInStock.CheckAndCreateNewProductInStock(5009, ProductCondition.New, 150000, 0, VATPercentage._20, 5, true);
        allRawProductsInStock[57] = ProductInStock.CheckAndCreateNewProductInStock(5009, ProductCondition.ForRepacking, 150000, 5, VATPercentage._20, 1, false);

        // ASUS --------------------------
        allRawProductsInStock[58] = ProductInStock.CheckAndCreateNewProductInStock(5010, ProductCondition.New, 35000, 0, VATPercentage._20, 15, true);
        allRawProductsInStock[59] = ProductInStock.CheckAndCreateNewProductInStock(5010, ProductCondition.NewPackageWasOpened, 35000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[60] = ProductInStock.CheckAndCreateNewProductInStock(5010, ProductCondition.ForRepacking, 35000, 5, VATPercentage._20, 1, false);
        allRawProductsInStock[61] = ProductInStock.CheckAndCreateNewProductInStock(5010, ProductCondition.Used, 35000, 20, VATPercentage._20, 1, true);

        allRawProductsInStock[62] = ProductInStock.CheckAndCreateNewProductInStock(5011, ProductCondition.New, 165000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[63] = ProductInStock.CheckAndCreateNewProductInStock(5011, ProductCondition.NewPackageWasOpened, 165000, 5, VATPercentage._20, 1, true);

        allRawProductsInStock[64] = ProductInStock.CheckAndCreateNewProductInStock(5012, ProductCondition.New, 205000, 0, VATPercentage._20, 5, true);

        allRawProductsInStock[65] = ProductInStock.CheckAndCreateNewProductInStock(5013, ProductCondition.New, 60000, 0, VATPercentage._20, 5, true);
        allRawProductsInStock[66] = ProductInStock.CheckAndCreateNewProductInStock(5013, ProductCondition.NewPackageWasOpened, 60000, 5, VATPercentage._20, 1, true);

        allRawProductsInStock[67] = ProductInStock.CheckAndCreateNewProductInStock(5014, ProductCondition.New, 35000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[68] = ProductInStock.CheckAndCreateNewProductInStock(5014, ProductCondition.ForRepacking, 35000, 5, VATPercentage._20, 1, false);

        allRawProductsInStock[69] = ProductInStock.CheckAndCreateNewProductInStock(5015, ProductCondition.New, 60000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[70] = ProductInStock.CheckAndCreateNewProductInStock(5015, ProductCondition.NewPackageWasOpened, 60000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[71] = ProductInStock.CheckAndCreateNewProductInStock(5015, ProductCondition.ForRepacking, 60000, 5, VATPercentage._20, 1, false);
        allRawProductsInStock[72] = ProductInStock.CheckAndCreateNewProductInStock(5015, ProductCondition.Refurbished, 60000, 15, VATPercentage._20, 1, true);
        allRawProductsInStock[73] = ProductInStock.CheckAndCreateNewProductInStock(5015, ProductCondition.Used, 60000, 20, VATPercentage._20, 1, true);

        allRawProductsInStock[74] = ProductInStock.CheckAndCreateNewProductInStock(5016, ProductCondition.New, 40000, 0, VATPercentage._20, 2, true);

        allRawProductsInStock[75] = ProductInStock.CheckAndCreateNewProductInStock(5017, ProductCondition.New, 155000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[76] = ProductInStock.CheckAndCreateNewProductInStock(5017, ProductCondition.NewPackageWasOpened, 155000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[77] = ProductInStock.CheckAndCreateNewProductInStock(5017, ProductCondition.ForRefurbishment, 155000, 15, VATPercentage._20, 1, false);

        // MSI --------------------------
        allRawProductsInStock[78] = ProductInStock.CheckAndCreateNewProductInStock(5018, ProductCondition.New, 24000, 0, VATPercentage._20, 20, true);
        allRawProductsInStock[79] = ProductInStock.CheckAndCreateNewProductInStock(5018, ProductCondition.NewPackageWasOpened, 24000, 5, VATPercentage._20, 2, true);
        allRawProductsInStock[80] = ProductInStock.CheckAndCreateNewProductInStock(5018, ProductCondition.ForRepacking, 24000, 5, VATPercentage._20, 1, false);

        allRawProductsInStock[81] = ProductInStock.CheckAndCreateNewProductInStock(5019, ProductCondition.New, 155000, 0, VATPercentage._20, 5, true);

        allRawProductsInStock[82] = ProductInStock.CheckAndCreateNewProductInStock(5020, ProductCondition.New, 105000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[83] = ProductInStock.CheckAndCreateNewProductInStock(5020, ProductCondition.NewPackageWasOpened, 105000, 5, VATPercentage._20, 2, true);

        allRawProductsInStock[84] = ProductInStock.CheckAndCreateNewProductInStock(5021, ProductCondition.New, 170000, 0, VATPercentage._20, 3, true);

        allRawProductsInStock[85] = ProductInStock.CheckAndCreateNewProductInStock(5022, ProductCondition.New, 70000, 0, VATPercentage._20, 10, true);
        allRawProductsInStock[86] = ProductInStock.CheckAndCreateNewProductInStock(5022, ProductCondition.NewPackageWasOpened, 70000, 5, VATPercentage._20, 1, true);
        allRawProductsInStock[87] = ProductInStock.CheckAndCreateNewProductInStock(5022, ProductCondition.ForRepacking, 70000, 5, VATPercentage._20, 1, false);

        return allRawProductsInStock;
    }







    // RAW DATA ABOUT THE CUSTOMERS ------------------------------------------------
    // -----------------------------------------------------------------------------

    // Method 4.

    /// <summary>
    /// The method creates a new customer for the program test
    /// </summary>
    /// <returns>A new customer with pre-specified data</returns>
    public static IndividualCustomer CreateIndividualCustomerForTest()
    {
        IndividualCustomer individualCustomer = new IndividualCustomer
            (
                "DmitryTest", // Login
                "test12345", // Password
                CustomerStatus.Normal,
                "Dmitry", // Name
                new PhoneNumber(7, 8, 919, 8675562),
                new EMail("dmitry", "homework.com")
            );
        return individualCustomer;
    }







    // RAW DATA FOR THE DELIVERY ---------------------------------------------------
    // -----------------------------------------------------------------------------

    // Method 5.

    /// <summary>
    /// The method creates 2 shops for the program test
    /// </summary>
    /// <returns>The array of 2 shops with pre-specified data</returns>
    public static Shop[] CreateShops()
    {
        Shop[] shops = 
        {
            new Shop
            (
                "Modern Tech",
                new Address("Moscow", "Pyzhevskiy Pereulok", "7"),
                "9:00 - 21:00, 7 days a week"
            ),
            new Shop
            (
                "Cyber Line",
                new Address("Moscow", "Neglinnaya Street", "18/1"),
                "9:00 - 21:00, 7 days a week"
            )
        };
        return shops;
    }

    // Method 6.

    /// <summary>
    /// The method creates 3 pick-up points for the program test
    /// </summary>
    /// <returns>The array of 3 pick-up points with pre-specified data</returns>
    public static PickUpPoint[] CreatePickUpPoints()
    {
        PickUpPoint[] pickUpPoints =
        {
            new PickUpPoint (new Address("Moscow", "Bolshaya Gruzinskaya Street", "20")),
            new PickUpPoint (new Address("Moscow", "Pyatnitskaya Ulitsa", "39")),
            new PickUpPoint (new Address("Moscow", "Myasnitskaya Ulitsa", "6/3, Str. 1"))
        };
        return pickUpPoints;
    }







    // RAW DATA FOR THE ORDERS --------------------------------------------------
    // --------------------------------------------------------------------------

    // Method 7.

    /// <summary>
    /// The method creates an array of orders for the program test
    /// </summary>
    /// <returns>The array of 2 orders with pre-specified data</returns>
    public static Order[] CreateOrdersForTest()
    {
        Order[] orders =
        {
            new Order
            (
                810000,
                new PickUpPointDelivery (PickUpPointDelivery.pickUpPointsForPickUpPointDelivery[0]),
                CommonEnums.PromoCode.DISC5,
                "1st raw data order",
                CommonEnums.PaymentMethod.Cash,
                new ProductInOrder[] { new ProductInOrder (SalesCatalog.getAllProductsForSale[20], 1), new ProductInOrder (SalesCatalog.getAllProductsForSale[55], 1) }
            ),
            new Order
            (
                820000,
                new ShopDelivery (ShopDelivery.shopsForShopDelivery[0]),
                CommonEnums.PromoCode.DISC10,
                "2nd raw data order",
                CommonEnums.PaymentMethod.BankCard,
                new ProductInOrder[] { new ProductInOrder (SalesCatalog.getAllProductsForSale[30], 1), new ProductInOrder (SalesCatalog.getAllProductsForSale[49], 1) }
            ),

        };
        return orders;
    }
}