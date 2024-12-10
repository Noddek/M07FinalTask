using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using M07FinalTask.N01RawData.Enumerations;

namespace M07FinalTask.N02Products;

// Task 1. An example of using INHERITANCE
// Task 16. Using generic inheritance.
/// <summary>
/// The class for Laptops, derived from the Product class
/// </summary>
public class Laptop : Product<uint>
{
    // FIELDS & PROPERTIES

    private static uint LaptopItemNumberCounter = 1000;
    public override uint ItemNumber { get; protected set; } // Typing the abstract property with uint type
    public LaptopEnums.LaptopModel Model { get; private set; }
    public LaptopEnums.LaptopScreenSize ScreenSize { get; private set; }
    public LaptopEnums.LaptopProcessor Processor { get; private set; }
    public LaptopEnums.LaptopRAMSize RAMSize { get; private set; }
    public LaptopEnums.LaptopGPU GPU { get; private set; }
    public LaptopEnums.LaptopOperatingSystem OperatingSystem { get; private set; }
    public LaptopEnums.LaptopStorageType StorageType { get; private set; }
    public LaptopEnums.LaptopStorageCapacity StorageCapacity { get; private set; }

    // CONSTRUCTORS --- Beginning of the section

    // NOTE. Since it results in so many constructors here,
    // creating an abstract class or properties in an abstract class doesn't seem reasonable.
    // I can't find a good way to remove duplicate code without confusing in new code.

    // A. Helper methods for constructors
    private void InitializationFirst2Properties(LaptopEnums.LaptopModel model)
    {
        ItemNumber = ++LaptopItemNumberCounter;
        Model = model;
    }
    private void InitializationFirst3Properties(LaptopEnums.LaptopModel model, LaptopEnums.LaptopScreenSize screenSize)
    {
        InitializationFirst2Properties(model);
        ScreenSize = screenSize;
    }
    private void InitializationFirst4Properties
        (
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor
        )
    {
        InitializationFirst3Properties(model, screenSize);
        Processor = processor;
    }
    private void InitializationFirst5Properties
        (
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize
        )
    {
        InitializationFirst4Properties(model, screenSize, processor);
        this.RAMSize = RAMSize;
    }
    private void InitializationFirst6Properties
        (
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU
        )
    {
        InitializationFirst5Properties(model, screenSize, processor, RAMSize);
        this.GPU = GPU;
    }
    private void InitializationFirst7Properties
        (
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem
        )
    {
        InitializationFirst6Properties(model, screenSize, processor, RAMSize, GPU);
        OperatingSystem = operatingSystem;
    }
    private void InitializationFirst8Properties
        (
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType
        )
    {
        InitializationFirst7Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem);
        StorageType = storageType;
    }
    private void InitializationAll9Properties
        (
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType,
            LaptopEnums.LaptopStorageCapacity storageCapacity
        )
    {
        InitializationFirst8Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType);
        StorageCapacity = storageCapacity;
    }

    // B. Constructors:
    // I. When only the local property Model is specified:
    // 2 parameters: 1 for base property, 1 for local property
    public Laptop(CommonEnums.Brand brand, LaptopEnums.LaptopModel model) : base(brand)
    {
        InitializationFirst2Properties(model);
    }
    // 3 parameters: 2 for base properties, 1 for local property
    public Laptop(CommonEnums.Brand brand, CommonEnums.ProductCategory category, LaptopEnums.LaptopModel model) : base(brand, category)
    {
        InitializationFirst2Properties(model);
    }
    // 4 parameters: 3 for base properties, 1 for local property
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            LaptopEnums.LaptopModel model
        ) : base(brand, category, itemTitle)
    {
        InitializationFirst2Properties(model);
    }
    // 5 parameters: 4 for base properties, 1 for local property
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            LaptopEnums.LaptopModel model
        ) : base(brand, category, itemTitle, description)
    {
        InitializationFirst2Properties(model);
    }
    // 6 parameters: 5 for base properties, 1 for local property
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            LaptopEnums.LaptopModel model
        ) : base(brand, category, itemTitle, description, releaseYear)
    {
        InitializationFirst2Properties(model);
    }
    // 7 parameters: 6 for base properties, 1 for local property
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            LaptopEnums.LaptopModel model
        ) : base(brand, category, itemTitle, description, releaseYear, unitOfMeasurement)
    {
        InitializationFirst2Properties(model);
    }

    // II. When only the local properties Model and ScreenSize are specified:
    // 3 parameters: 1 for base property, 2 for local properties
    public Laptop(CommonEnums.Brand brand, LaptopEnums.LaptopModel model, LaptopEnums.LaptopScreenSize screenSize) : base(brand)
    {
        InitializationFirst3Properties(model, screenSize);
    }
    // 4 parameters: 2 for base properties, 2 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize
        ) : base(brand, category)
    {
        InitializationFirst3Properties(model, screenSize);
    }
    // 5 parameters: 3 for base properties, 2 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize
        ) : base(brand, category, itemTitle)
    {
        InitializationFirst3Properties(model, screenSize);
    }
    // 6 parameters: 4 for base properties, 2 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize
        ) : base(brand, category, itemTitle, description)
    {
        InitializationFirst3Properties(model, screenSize);
    }
    // 7 parameters: 5 for base properties, 2 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize
        ) : base(brand, category, itemTitle, description, releaseYear)
    {
        InitializationFirst3Properties(model, screenSize);
    }
    // 8 parameters: 6 for base properties, 2 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize
        ) : base(brand, category, itemTitle, description, releaseYear, unitOfMeasurement)
    {
        InitializationFirst3Properties(model, screenSize);
    }

    // III. When only the local properties Model, ScreenSize and Processor are specified:
    // 4 parameters: 1 for base property, 3 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor
        ) : base(brand)
    {
        InitializationFirst4Properties(model, screenSize, processor);
    }
    // 5 parameters: 2 for base properties, 3 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor
        ) : base(brand, category)
    {
        InitializationFirst4Properties(model, screenSize, processor);
    }
    // 6 parameters: 3 for base properties, 3 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor
        ) : base(brand, category, itemTitle)
    {
        InitializationFirst4Properties(model, screenSize, processor);
    }
    // 7 parameters: 4 for base properties, 3 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor
        ) : base(brand, category, itemTitle, description)
    {
        InitializationFirst4Properties(model, screenSize, processor);
    }
    // 8 parameters: 5 for base properties, 3 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor
        ) : base(brand, category, itemTitle, description, releaseYear)
    {
        InitializationFirst4Properties(model, screenSize, processor);
    }
    // 9 parameters: 6 for base properties, 3 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor
        ) : base(brand, category, itemTitle, description, releaseYear, unitOfMeasurement)
    {
        InitializationFirst4Properties(model, screenSize, processor);
    }

    // IV. When only the local properties Model, ScreenSize, Processor and RAMSize are specified:
    // 5 parameters: 1 for base property, 4 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize
        ) : base(brand)
    {
        InitializationFirst5Properties(model, screenSize, processor, RAMSize);
    }
    // 6 parameters: 2 for base properties, 4 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize
        ) : base(brand, category)
    {
        InitializationFirst5Properties(model, screenSize, processor, RAMSize);
    }
    // 7 parameters: 3 for base properties, 4 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize
        ) : base(brand, category, itemTitle)
    {
        InitializationFirst5Properties(model, screenSize, processor, RAMSize);
    }
    // 8 parameters: 4 for base properties, 4 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize
        ) : base(brand, category, itemTitle, description)
    {
        InitializationFirst5Properties(model, screenSize, processor, RAMSize);
    }
    // 9 parameters: 5 for base properties, 4 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize
        ) : base(brand, category, itemTitle, description, releaseYear)
    {
        InitializationFirst5Properties(model, screenSize, processor, RAMSize);
    }
    // 10 parameters: 6 for base properties, 4 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize
        ) : base(brand, category, itemTitle, description, releaseYear, unitOfMeasurement)
    {
        InitializationFirst5Properties(model, screenSize, processor, RAMSize);
    }

    // V. When only the local properties Model, ScreenSize, Processor, RAMSize and GPU are specified:
    // 6 parameters: 1 for base property, 5 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU
        ) : base(brand)
    {
        InitializationFirst6Properties(model, screenSize, processor, RAMSize, GPU);
    }
    // 7 parameters: 2 for base properties, 5 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU
        ) : base(brand, category)
    {
        InitializationFirst6Properties(model, screenSize, processor, RAMSize, GPU);
    }
    // 8 parameters: 3 for base properties, 5 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU
        ) : base(brand, category, itemTitle)
    {
        InitializationFirst6Properties(model, screenSize, processor, RAMSize, GPU);
    }
    // 9 parameters: 4 for base properties, 5 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU
        ) : base(brand, category, itemTitle, description)
    {
        InitializationFirst6Properties(model, screenSize, processor, RAMSize, GPU);
    }
    // 10 parameters: 5 for base properties, 5 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU
        ) : base(brand, category, itemTitle, description, releaseYear)
    {
        InitializationFirst6Properties(model, screenSize, processor, RAMSize, GPU);
    }
    // 11 parameters: 6 for base properties, 5 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU
        ) : base(brand, category, itemTitle, description, releaseYear, unitOfMeasurement)
    {
        InitializationFirst6Properties(model, screenSize, processor, RAMSize, GPU);
    }

    // VI. When only the local properties Model, ScreenSize, Processor, RAMSize, GPU and OperatingSystem are specified:
    // 7 parameters: 1 for base property, 6 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem
        ) : base(brand)
    {
        InitializationFirst7Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem);
    }
    // 8 parameters: 2 for base properties, 6 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem
        ) : base(brand, category)
    {
        InitializationFirst7Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem);
    }
    // 9 parameters: 3 for base properties, 6 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem
        ) : base(brand, category, itemTitle)
    {
        InitializationFirst7Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem);
    }
    // 10 parameters: 4 for base properties, 6 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem
        ) : base(brand, category, itemTitle, description)
    {
        InitializationFirst7Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem);
    }
    // 11 parameters: 5 for base properties, 6 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem
        ) : base(brand, category, itemTitle, description, releaseYear)
    {
        InitializationFirst7Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem);
    }
    // 12 parameters: 6 for base properties, 6 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem
        ) : base(brand, category, itemTitle, description, releaseYear, unitOfMeasurement)
    {
        InitializationFirst7Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem);
    }

    // VII. When only the local properties Model, ScreenSize, Processor, RAMSize, GPU, OperatingSystem and StorageType are specified:
    // 8 parameters: 1 for base property, 7 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType
        ) : base(brand)
    {
        InitializationFirst8Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType);
    }
    // 9 parameters: 2 for base properties, 7 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType
        ) : base(brand, category)
    {
        InitializationFirst8Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType);
    }
    // 10 parameters: 3 for base properties, 7 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType
        ) : base(brand, category, itemTitle)
    {
        InitializationFirst8Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType);
    }
    // 11 parameters: 4 for base properties, 7 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType
        ) : base(brand, category, itemTitle, description)
    {
        InitializationFirst8Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType);
    }
    // 12 parameters: 5 for base properties, 7 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType
        ) : base(brand, category, itemTitle, description, releaseYear)
    {
        InitializationFirst8Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType);
    }
    // 13 parameters: 6 for base properties, 7 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType
        ) : base(brand, category, itemTitle, description, releaseYear, unitOfMeasurement)
    {
        InitializationFirst8Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType);
    }

    // VIII. When all local properties are specified: Model, ScreenSize, Processor, RAMSize, GPU, OperatingSystem, StorageType, StorageCapacity
    // 9 parameters: 1 for base property, 8 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType,
            LaptopEnums.LaptopStorageCapacity storageCapacity
        ) : base(brand)
    {
        InitializationAll9Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType, storageCapacity);
    }
    // 10 parameters: 2 for base properties, 8 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType,
            LaptopEnums.LaptopStorageCapacity storageCapacity
        ) : base(brand, category)
    {
        InitializationAll9Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType, storageCapacity);
    }
    // 11 parameters: 3 for base properties, 8 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType,
            LaptopEnums.LaptopStorageCapacity storageCapacity
        ) : base(brand, category, itemTitle)
    {
        InitializationAll9Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType, storageCapacity);
    }
    // 12 parameters: 4 for base properties, 8 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType,
            LaptopEnums.LaptopStorageCapacity storageCapacity
        ) : base(brand, category, itemTitle, description)
    {
        InitializationAll9Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType, storageCapacity);
    }
    // 13 parameters: 5 for base properties, 8 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType,
            LaptopEnums.LaptopStorageCapacity storageCapacity
        ) : base(brand, category, itemTitle, description, releaseYear)
    {
        InitializationAll9Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType, storageCapacity);
    }
    // 14 parameters: 6 for base properties, 8 for local properties
    public Laptop
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            LaptopEnums.LaptopModel model,
            LaptopEnums.LaptopScreenSize screenSize,
            LaptopEnums.LaptopProcessor processor,
            LaptopEnums.LaptopRAMSize RAMSize,
            LaptopEnums.LaptopGPU GPU,
            LaptopEnums.LaptopOperatingSystem operatingSystem,
            LaptopEnums.LaptopStorageType storageType,
            LaptopEnums.LaptopStorageCapacity storageCapacity
        ) : base(brand, category, itemTitle, description, releaseYear, unitOfMeasurement)
    {
        InitializationAll9Properties(model, screenSize, processor, RAMSize, GPU, operatingSystem, storageType, storageCapacity);
    }

    // CONSTRUCTORS --- End of the section


    // METHODS

    // ----------------------------------------------
    
    // Task 4.1. An example of using method override. The use of 'sealed' is just an addition.
    public override sealed void DisplayFullInfo()
    {
        base.DisplayFullInfo();
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Screen size: {(float)ScreenSize / 10}\"");
        Console.WriteLine($"Processor: {LaptopEnums.LaptopProcessorToString(Processor)}");
        Console.WriteLine($"RAM: {(byte)RAMSize} GB");
        Console.WriteLine($"GPU: {LaptopEnums.LaptopGPUToString(GPU)}");
        Console.WriteLine($"Operating system: {LaptopEnums.LaptopOperatingSystemToString(OperatingSystem)}");
        Console.WriteLine($"Storage type: {StorageType}");
        Console.WriteLine($"Storage capacity: {(uint)StorageCapacity} GB");
    }

    // We can see the difference if we use method hiding with the 'new' modifier:
    
    //public new void DisplayFullInfo()
    //{
    //    base.DisplayFullInfo();
    //    Console.WriteLine($"Model: {Model}");
    //    Console.WriteLine($"Screen size: {(float)ScreenSize / 10}\"");
    //    Console.WriteLine($"Processor: {LaptopEnums.LaptopProcessorToString(Processor)}");
    //    Console.WriteLine($"RAM: {(byte)RAMSize} GB");
    //    Console.WriteLine($"GPU: {LaptopEnums.LaptopGPUToString(GPU)}");
    //    Console.WriteLine($"Operating system: {LaptopEnums.LaptopOperatingSystemToString(OperatingSystem)}");
    //    Console.WriteLine($"Storage type: {StorageType}");
    //    Console.WriteLine($"Storage capacity: {(uint)StorageCapacity} GB");
    //}
    
    // ----------------------------------------------
    public override void DisplayShortInfo()
    {
        Console.Write(
            $"Laptop {ItemNumber}: " +
            $"{Brand} {ItemTitle} " +
            $"{(float)ScreenSize / 10}\", " +
            $"{Convert.ToString(Model).Replace("_", " ")}, " +
            $"{LaptopEnums.LaptopProcessorToString(Processor)}, " +
            $"{LaptopEnums.LaptopGPUToString(GPU)}, {(byte)RAMSize} GB, {StorageType} {(uint)StorageCapacity} GB, {LaptopEnums.LaptopOperatingSystemToString(OperatingSystem)}");
    }
}