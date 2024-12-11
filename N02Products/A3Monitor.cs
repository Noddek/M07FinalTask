using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using M07FinalTask.N01RawData.Enumerations;

namespace M07FinalTask.N02Products;

/// <summary>
/// The class for Monitors, derived from the Product class
/// </summary>
public class Monitor : Product<uint>
{
    // FIELDS & PROPERTIES

    private static uint MonitorItemNumberCounter = 5000;
    public override uint ItemNumber { get; protected set; }
    public MonitorEnums.MonitorModel Model { get; private set; }
    public MonitorEnums.MonitorScreenSize ScreenSize { get; private set; }
    public MonitorEnums.MaxResolution MaxResolution { get; private set; }
    public MonitorEnums.RefreshRate RefreshRate { get; private set; }
    public MonitorEnums.VideoInputs VideoInputs { get; private set; }
    public MonitorEnums.DisplayType DisplayType { get; private set; }
    public MonitorEnums.AspectRatio AspectRatio { get; private set; }
    public MonitorEnums.ContrastRatio ContrastRatio { get; private set; }
    public MonitorEnums.Brightness Brightness { get; private set; }
    public MonitorEnums.PixelResponseTime PixelResponseTime { get; private set; }


    // CONSTRUCTORS --- Beginning of the section

    // NOTE. In this class I tried to organize the constructors a little bit differently,
    // but there are still a lot of them, and it's easy to get confused.

    // A. Helper methods for constructors
    private void InitializationItemNumberAndModel(MonitorEnums.MonitorModel model)
    {
        ItemNumber = ++MonitorItemNumberCounter;
        Model = model;
    }

    private void InitializationScreenSize(MonitorEnums.MonitorScreenSize screenSize)
    {
        ScreenSize = screenSize;
    }

    private void InitializationMaxResolution(MonitorEnums.MaxResolution maxResolution)
    {
        MaxResolution = maxResolution;
    }

    private void InitializationRefreshRate(MonitorEnums.RefreshRate refreshRate)
    {
        RefreshRate = refreshRate;
    }

    private void InitializationVideoInputs(MonitorEnums.VideoInputs videoInputs)
    {
        VideoInputs = videoInputs;
    }

    private void InitializationDisplayType(MonitorEnums.DisplayType displayType)
    {
        DisplayType = displayType;
    }

    private void InitializationAspectRatio(MonitorEnums.AspectRatio aspectRatio)
    {
        AspectRatio = aspectRatio;
    }

    private void InitializationContrastRatio(MonitorEnums.ContrastRatio contrastRatio)
    {
        ContrastRatio = contrastRatio;
    }

    private void InitializationBrightness(MonitorEnums.Brightness brightness)
    {
        Brightness = brightness;
    }

    private void InitializationPixelResponseTime(MonitorEnums.PixelResponseTime pixelResponseTime)
    {
        PixelResponseTime = pixelResponseTime;
    }

    // B. Constructors:

    // I. When only the local property Model is specified:

    // 2 parameters: 1 for base property, 1 for local property
    public Monitor(CommonEnums.Brand brand, MonitorEnums.MonitorModel model) : base(brand)
    {
        InitializationItemNumberAndModel(model);
    }

    // 3 parameters: 2 for base properties, 1 for local property
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            MonitorEnums.MonitorModel model
        ) : base(brand, category)
    {
        InitializationItemNumberAndModel(model);
    }

    // 4 parameters: 3 for base properties, 1 for local property
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            MonitorEnums.MonitorModel model
        ) : base(brand, category, itemTitle)
    {
        InitializationItemNumberAndModel(model);
    }

    // 5 parameters: 4 for base properties, 1 for local property
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            MonitorEnums.MonitorModel model
        ) : base(brand, category, itemTitle, description)
    {
        InitializationItemNumberAndModel(model);
    }

    // 6 parameters: 5 for base properties, 1 for local property
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            MonitorEnums.MonitorModel model
        ) : base(brand, category, itemTitle, description, releaseYear)
    {
        InitializationItemNumberAndModel(model);
    }

    // 7 parameters: 6 for base properties, 1 for local property
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            MonitorEnums.MonitorModel model
        ) : base(brand, category, itemTitle, description, releaseYear, unitOfMeasurement)
    {
        InitializationItemNumberAndModel(model);
    }

    // II. When only the local properties Model and ScreenSize are specified:

    // 3 parameters: 1 for base property, 2 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize
        ) : this(brand, model)
    {
        InitializationScreenSize(screenSize);
    }

    // 4 parameters: 2 for base properties, 2 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize
        ) : this(brand, category, model)
    {
        InitializationScreenSize(screenSize);
    }

    // 5 parameters: 3 for base properties, 2 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize
        ) : this(brand, category, itemTitle, model)
    {
        InitializationScreenSize(screenSize);
    }

    // 6 parameters: 4 for base properties, 2 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize
        ) : this(brand, category, itemTitle, description, model)
    {
        InitializationScreenSize(screenSize);
    }

    // 7 parameters: 5 for base properties, 2 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize
        ) : this(brand, category, itemTitle, description, releaseYear, model)
    {
        InitializationScreenSize(screenSize);
    }

    // 8 parameters: 6 for base properties, 2 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize
        ) : this(brand, category, itemTitle, description, releaseYear, unitOfMeasurement, model)
    {
        InitializationScreenSize(screenSize);
    }

    // III. When only the local properties Model, ScreenSize and MaxResolution are specified:

    // 4 parameters: 1 for base property, 3 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution
        ) : this(brand, model, screenSize)
    {
        InitializationMaxResolution(maxResolution);
    }

    // 5 parameters: 2 for base properties, 3 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution
        ) : this(brand, category, model, screenSize)
    {
        InitializationMaxResolution(maxResolution);
    }

    // 6 parameters: 3 for base properties, 3 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution
        ) : this(brand, category, itemTitle, model, screenSize)
    {
        InitializationMaxResolution(maxResolution);
    }

    // 7 parameters: 4 for base properties, 3 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution
        ) : this(brand, category, itemTitle, description, model, screenSize)
    {
        InitializationMaxResolution(maxResolution);
    }

    // 8 parameters: 5 for base properties, 3 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution
        ) : this(brand, category, itemTitle, description, releaseYear, model, screenSize)
    {
        InitializationMaxResolution(maxResolution);
    }

    // 9 parameters: 6 for base properties, 3 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution
        ) : this(brand, category, itemTitle, description, releaseYear, unitOfMeasurement, model, screenSize)
    {
        InitializationMaxResolution(maxResolution);
    }

    // IV. When only the local properties Model, ScreenSize, MaxResolution and RefreshRate are specified:

    // 5 parameters: 1 for base property, 4 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate
        ) : this(brand, model, screenSize, maxResolution)
    {
        InitializationRefreshRate(refreshRate);
    }

    // 6 parameters: 2 for base properties, 4 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate
        ) : this(brand, category, model, screenSize, maxResolution)
    {
        InitializationRefreshRate(refreshRate);
    }

    // 7 parameters: 3 for base properties, 4 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate
        ) : this(brand, category, itemTitle, model, screenSize, maxResolution)
    {
        InitializationRefreshRate(refreshRate);
    }

    // 8 parameters: 4 for base properties, 4 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate
        ) : this(brand, category, itemTitle, description, model, screenSize, maxResolution)
    {
        InitializationRefreshRate(refreshRate);
    }

    // 9 parameters: 5 for base properties, 4 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate
        ) : this(brand, category, itemTitle, description, releaseYear, model, screenSize, maxResolution)
    {
        InitializationRefreshRate(refreshRate);
    }

    // 10 parameters: 6 for base properties, 4 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate
        ) : this(brand, category, itemTitle, description, releaseYear, unitOfMeasurement, model, screenSize, maxResolution)
    {
        InitializationRefreshRate(refreshRate);
    }

    // V. When only the local properties Model, ScreenSize, MaxResolution, RefreshRate and VideoInputs are specified:

    // 6 parameters: 1 for base property, 5 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs
        ) : this(brand, model, screenSize, maxResolution, refreshRate)
    {
        InitializationVideoInputs(videoInputs);
    }

    // 7 parameters: 2 for base properties, 5 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs
        ) : this(brand, category, model, screenSize, maxResolution, refreshRate)
    {
        InitializationVideoInputs(videoInputs);
    }

    // 8 parameters: 3 for base properties, 5 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs
        ) : this(brand, category, itemTitle, model, screenSize, maxResolution, refreshRate)
    {
        InitializationVideoInputs(videoInputs);
    }

    // 9 parameters: 4 for base properties, 5 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs
        ) : this(brand, category, itemTitle, description, model, screenSize, maxResolution, refreshRate)
    {
        InitializationVideoInputs(videoInputs);
    }

    // 10 parameters: 5 for base properties, 5 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs
        ) : this(brand, category, itemTitle, description, releaseYear, model, screenSize, maxResolution, refreshRate)
    {
        InitializationVideoInputs(videoInputs);
    }

    // 11 parameters: 6 for base properties, 5 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs
        ) : this(brand, category, itemTitle, description, releaseYear, unitOfMeasurement, model, screenSize, maxResolution, refreshRate)
    {
        InitializationVideoInputs(videoInputs);
    }

    // VI. When only the local properties Model, ScreenSize, MaxResolution, RefreshRate, VideoInputs and DisplayType are specified:

    // 7 parameters: 1 for base property, 6 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType
        ) : this(brand, model, screenSize, maxResolution, refreshRate, videoInputs)
    {
        InitializationDisplayType(displayType);
    }

    // 8 parameters: 2 for base properties, 6 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType
        ) : this(brand, category, model, screenSize, maxResolution, refreshRate, videoInputs)
    {
        InitializationDisplayType(displayType);
    }

    // 9 parameters: 3 for base properties, 6 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType
        ) : this(brand, category, itemTitle, model, screenSize, maxResolution, refreshRate, videoInputs)
    {
        InitializationDisplayType(displayType);
    }

    // 10 parameters: 4 for base properties, 6 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType
        ) : this(brand, category, itemTitle, description, model, screenSize, maxResolution, refreshRate, videoInputs)
    {
        InitializationDisplayType(displayType);
    }

    // 11 parameters: 5 for base properties, 6 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType
        ) : this(brand, category, itemTitle, description, releaseYear, model, screenSize, maxResolution, refreshRate, videoInputs)
    {
        InitializationDisplayType(displayType);
    }

    // 12 parameters: 6 for base properties, 6 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType
        ) : this(brand, category, itemTitle, description, releaseYear, unitOfMeasurement, model, screenSize, maxResolution, refreshRate, videoInputs)
    {
        InitializationDisplayType(displayType);
    }

    // VII. When only the local properties Model, ScreenSize, MaxResolution, RefreshRate, VideoInputs, DisplayType and AspectRatio are specified:

    // 8 parameters: 1 for base property, 7 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio
        ) : this(brand, model, screenSize, maxResolution, refreshRate, videoInputs, displayType)
    {
        InitializationAspectRatio(aspectRatio);
    }

    // 9 parameters: 2 for base properties, 7 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio
        ) : this(brand, category, model, screenSize, maxResolution, refreshRate, videoInputs, displayType)
    {
        InitializationAspectRatio(aspectRatio);
    }

    // 10 parameters: 3 for base properties, 7 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio
        ) : this(brand, category, itemTitle, model, screenSize, maxResolution, refreshRate, videoInputs, displayType)
    {
        InitializationAspectRatio(aspectRatio);
    }

    // 11 parameters: 4 for base properties, 7 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio
        ) : this(brand, category, itemTitle, description, model, screenSize, maxResolution, refreshRate, videoInputs, displayType)
    {
        InitializationAspectRatio(aspectRatio);
    }

    // 12 parameters: 5 for base properties, 7 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio
        ) : this(brand, category, itemTitle, description, releaseYear, model, screenSize, maxResolution, refreshRate, videoInputs, displayType)
    {
        InitializationAspectRatio(aspectRatio);
    }

    // 13 parameters: 6 for base properties, 7 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio
        ) : this(brand, category, itemTitle, description, releaseYear, unitOfMeasurement, model, screenSize, maxResolution, refreshRate, videoInputs, displayType)
    {
        InitializationAspectRatio(aspectRatio);
    }

    // VIII. When only the local properties Model, ScreenSize, MaxResolution, RefreshRate, VideoInputs, DisplayType, AspectRatio and ContrastRatio are specified:

    // 9 parameters: 1 for base property, 8 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio
        ) : this(brand, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio)
    {
        InitializationContrastRatio(contrastRatio);
    }

    // 10 parameters: 2 for base properties, 8 for local properties
    public Monitor
       (
           CommonEnums.Brand brand,
           CommonEnums.ProductCategory category,
           MonitorEnums.MonitorModel model,
           MonitorEnums.MonitorScreenSize screenSize,
           MonitorEnums.MaxResolution maxResolution,
           MonitorEnums.RefreshRate refreshRate,
           MonitorEnums.VideoInputs videoInputs,
           MonitorEnums.DisplayType displayType,
           MonitorEnums.AspectRatio aspectRatio,
           MonitorEnums.ContrastRatio contrastRatio
       ) : this(brand, category, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio)
    {
        InitializationContrastRatio(contrastRatio);
    }

    // 11 parameters: 3 for base properties, 8 for local properties
    public Monitor
       (
           CommonEnums.Brand brand,
           CommonEnums.ProductCategory category,
           string? itemTitle,
           MonitorEnums.MonitorModel model,
           MonitorEnums.MonitorScreenSize screenSize,
           MonitorEnums.MaxResolution maxResolution,
           MonitorEnums.RefreshRate refreshRate,
           MonitorEnums.VideoInputs videoInputs,
           MonitorEnums.DisplayType displayType,
           MonitorEnums.AspectRatio aspectRatio,
           MonitorEnums.ContrastRatio contrastRatio
       ) : this(brand, category, itemTitle, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio)
    {
        InitializationContrastRatio(contrastRatio);
    }

    // 12 parameters: 4 for base properties, 8 for local properties
    public Monitor
       (
           CommonEnums.Brand brand,
           CommonEnums.ProductCategory category,
           string? itemTitle,
           string? description,
           MonitorEnums.MonitorModel model,
           MonitorEnums.MonitorScreenSize screenSize,
           MonitorEnums.MaxResolution maxResolution,
           MonitorEnums.RefreshRate refreshRate,
           MonitorEnums.VideoInputs videoInputs,
           MonitorEnums.DisplayType displayType,
           MonitorEnums.AspectRatio aspectRatio,
           MonitorEnums.ContrastRatio contrastRatio
       ) : this(brand, category, itemTitle, description, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio)
    {
        InitializationContrastRatio(contrastRatio);
    }

    // 13 parameters: 5 for base properties, 8 for local properties
    public Monitor
       (
           CommonEnums.Brand brand,
           CommonEnums.ProductCategory category,
           string? itemTitle,
           string? description,
           CommonEnums.ReleaseYear releaseYear,
           MonitorEnums.MonitorModel model,
           MonitorEnums.MonitorScreenSize screenSize,
           MonitorEnums.MaxResolution maxResolution,
           MonitorEnums.RefreshRate refreshRate,
           MonitorEnums.VideoInputs videoInputs,
           MonitorEnums.DisplayType displayType,
           MonitorEnums.AspectRatio aspectRatio,
           MonitorEnums.ContrastRatio contrastRatio
       ) : this(brand, category, itemTitle, description, releaseYear, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio)
    {
        InitializationContrastRatio(contrastRatio);
    }

    // 14 parameters: 6 for base properties, 8 for local properties
    public Monitor
       (
           CommonEnums.Brand brand,
           CommonEnums.ProductCategory category,
           string? itemTitle,
           string? description,
           CommonEnums.ReleaseYear releaseYear,
           CommonEnums.UnitOfMeasurement unitOfMeasurement,
           MonitorEnums.MonitorModel model,
           MonitorEnums.MonitorScreenSize screenSize,
           MonitorEnums.MaxResolution maxResolution,
           MonitorEnums.RefreshRate refreshRate,
           MonitorEnums.VideoInputs videoInputs,
           MonitorEnums.DisplayType displayType,
           MonitorEnums.AspectRatio aspectRatio,
           MonitorEnums.ContrastRatio contrastRatio
       ) : this(brand, category, itemTitle, description, releaseYear, unitOfMeasurement, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio)
    {
        InitializationContrastRatio(contrastRatio);
    }

    // IX. When only the local properties Model, ScreenSize, MaxResolution, RefreshRate, VideoInputs, DisplayType, AspectRatio, ContrastRatio and Brightness are specified:

    // 10 parameters: 1 for base property, 9 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio,
            MonitorEnums.Brightness brightness
        ) : this(brand, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio)
    {
        InitializationBrightness(brightness);
    }

    // 11 parameters: 2 for base properties, 9 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio,
            MonitorEnums.Brightness brightness
        ) : this(brand, category, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio)
    {
        InitializationBrightness(brightness);
    }

    // 12 parameters: 3 for base properties, 9 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio,
            MonitorEnums.Brightness brightness
        ) : this(brand, category, itemTitle, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio)
    {
        InitializationBrightness(brightness);
    }

    // 13 parameters: 4 for base properties, 9 for local properties
    public Monitor
       (
           CommonEnums.Brand brand,
           CommonEnums.ProductCategory category,
           string? itemTitle,
           string? description,
           MonitorEnums.MonitorModel model,
           MonitorEnums.MonitorScreenSize screenSize,
           MonitorEnums.MaxResolution maxResolution,
           MonitorEnums.RefreshRate refreshRate,
           MonitorEnums.VideoInputs videoInputs,
           MonitorEnums.DisplayType displayType,
           MonitorEnums.AspectRatio aspectRatio,
           MonitorEnums.ContrastRatio contrastRatio,
           MonitorEnums.Brightness brightness
       ) : this(brand, category, itemTitle, description, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio)
    {
        InitializationBrightness(brightness);
    }

    // 14 parameters: 5 for base properties, 9 for local properties
    public Monitor
       (
           CommonEnums.Brand brand,
           CommonEnums.ProductCategory category,
           string? itemTitle,
           string? description,
           CommonEnums.ReleaseYear releaseYear,
           MonitorEnums.MonitorModel model,
           MonitorEnums.MonitorScreenSize screenSize,
           MonitorEnums.MaxResolution maxResolution,
           MonitorEnums.RefreshRate refreshRate,
           MonitorEnums.VideoInputs videoInputs,
           MonitorEnums.DisplayType displayType,
           MonitorEnums.AspectRatio aspectRatio,
           MonitorEnums.ContrastRatio contrastRatio,
           MonitorEnums.Brightness brightness
       ) : this(brand, category, itemTitle, description, releaseYear, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio)
    {
        InitializationBrightness(brightness);
    }

    // 15 parameters: 6 for base properties, 9 for local properties
    public Monitor
       (
           CommonEnums.Brand brand,
           CommonEnums.ProductCategory category,
           string? itemTitle,
           string? description,
           CommonEnums.ReleaseYear releaseYear,
           CommonEnums.UnitOfMeasurement unitOfMeasurement,
           MonitorEnums.MonitorModel model,
           MonitorEnums.MonitorScreenSize screenSize,
           MonitorEnums.MaxResolution maxResolution,
           MonitorEnums.RefreshRate refreshRate,
           MonitorEnums.VideoInputs videoInputs,
           MonitorEnums.DisplayType displayType,
           MonitorEnums.AspectRatio aspectRatio,
           MonitorEnums.ContrastRatio contrastRatio,
           MonitorEnums.Brightness brightness
       ) : this(brand, category, itemTitle, description, releaseYear, unitOfMeasurement, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio)
    {
        InitializationBrightness(brightness);
    }

    // X. When all local properties are specified: Model, ScreenSize, MaxResolution, RefreshRate, VideoInputs, DisplayType, AspectRatio, ContrastRatio, Brightness and PixelResponseTime.

    // 11 parameters: 1 for base property, 10 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio,
            MonitorEnums.Brightness brightness,
            MonitorEnums.PixelResponseTime pixelResponseTime
        ) : this(brand, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio, brightness)
    {
        InitializationPixelResponseTime(pixelResponseTime);
    }

    // 12 parameters: 2 for base properties, 10 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio,
            MonitorEnums.Brightness brightness,
            MonitorEnums.PixelResponseTime pixelResponseTime
        ) : this(brand, category, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio, brightness)
    {
        InitializationPixelResponseTime(pixelResponseTime);
    }

    // 13 parameters: 3 for base properties, 10 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio,
            MonitorEnums.Brightness brightness,
            MonitorEnums.PixelResponseTime pixelResponseTime
        ) : this(brand, category, itemTitle, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio, brightness)
    {
        InitializationPixelResponseTime(pixelResponseTime);
    }

    // 14 parameters: 4 for base properties, 10 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio,
            MonitorEnums.Brightness brightness,
            MonitorEnums.PixelResponseTime pixelResponseTime
        ) : this(brand, category, itemTitle, description, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio, brightness)
    {
        InitializationPixelResponseTime(pixelResponseTime);
    }

    // 15 parameters: 5 for base properties, 10 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio,
            MonitorEnums.Brightness brightness,
            MonitorEnums.PixelResponseTime pixelResponseTime
        ) : this(brand, category, itemTitle, description, releaseYear, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio, brightness)
    {
        InitializationPixelResponseTime(pixelResponseTime);
    }

    // 16 parameters: 6 for base properties, 10 for local properties
    public Monitor
        (
            CommonEnums.Brand brand,
            CommonEnums.ProductCategory category,
            string? itemTitle,
            string? description,
            CommonEnums.ReleaseYear releaseYear,
            CommonEnums.UnitOfMeasurement unitOfMeasurement,
            MonitorEnums.MonitorModel model,
            MonitorEnums.MonitorScreenSize screenSize,
            MonitorEnums.MaxResolution maxResolution,
            MonitorEnums.RefreshRate refreshRate,
            MonitorEnums.VideoInputs videoInputs,
            MonitorEnums.DisplayType displayType,
            MonitorEnums.AspectRatio aspectRatio,
            MonitorEnums.ContrastRatio contrastRatio,
            MonitorEnums.Brightness brightness,
            MonitorEnums.PixelResponseTime pixelResponseTime
        ) : this(brand, category, itemTitle, description, releaseYear, unitOfMeasurement, model, screenSize, maxResolution, refreshRate, videoInputs, displayType, aspectRatio, contrastRatio, brightness)
    {
        InitializationPixelResponseTime(pixelResponseTime);
    }

    // CONSTRUCTORS --- End of the section






    // METHODS
    
    public override sealed void DisplayFullInfo()
    {
        base.DisplayFullInfo();
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Screen size: {(float)ScreenSize / 10}\"");
        Console.WriteLine($"Maximum resolution: {Convert.ToString((uint)MaxResolution).Substring(0, 4)}x{Convert.ToString((uint)MaxResolution).Substring(4, 4)}");
        Console.WriteLine($"Refresh rate: {(uint)RefreshRate} Hz");
        Console.WriteLine($"Video inputs: {MonitorEnums.VideoInputsToString(VideoInputs)}");
        Console.WriteLine($"Display type: {DisplayType}");
        Console.WriteLine($"Aspect ratio: {MonitorEnums.AspectRatioToString(AspectRatio)}");
        Console.WriteLine($"Contrast ratio: {MonitorEnums.ContrastRatioToString(ContrastRatio)}");
        Console.WriteLine($"Brightness: {(uint)Brightness} nits");
        Console.WriteLine($"Pixel response time: {MonitorEnums.PixelResponseTimeToString(PixelResponseTime)}");
    }

    public override void DisplayShortInfo()
    {
        Console.Write(
            $"Monitor {ItemNumber}: " +
            $"{Brand} {ItemTitle}, " +
            $"{Convert.ToString(Model).Replace("_", " ")}, " +
            $"{(float)ScreenSize / 10}\", " +
            $"{DisplayType}, " +
            $"{Convert.ToString((uint)MaxResolution).Substring(0, 4)}x{Convert.ToString((uint)MaxResolution).Substring(4, 4)}, " +
            $"{(uint)RefreshRate} Hz, {MonitorEnums.PixelResponseTimeToString(PixelResponseTime)}");
    }
}