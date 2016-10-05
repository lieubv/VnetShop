namespace VnetShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccReport",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DeviceID = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        TypeID = c.Int(nullable: false),
                        timeDiffMinute = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CarCommandQueue",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DeviceID = c.String(nullable: false, maxLength: 50),
                        CommandText = c.String(nullable: false, maxLength: 200),
                        CreateDate = c.DateTime(nullable: false),
                        IsSend = c.Boolean(nullable: false),
                        SendDate = c.DateTime(nullable: false),
                        IsResponse = c.Boolean(nullable: false),
                        ResponseDate = c.DateTime(nullable: false),
                        ResponseText = c.String(maxLength: 500),
                        CommandName = c.String(maxLength: 200),
                        IsOfflineSend = c.Boolean(nullable: false),
                        Infos = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CommandDictionary",
                c => new
                    {
                        CommandCode = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        CommandName = c.String(maxLength: 50),
                        EnglishName = c.String(maxLength: 50),
                        Description = c.String(maxLength: 200),
                        EnglishDescription = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.CommandCode);
            
            CreateTable(
                "dbo.DeviceProtocol",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProtocolName = c.String(maxLength: 20),
                        Protocol = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        DeviceID = c.Int(nullable: false, identity: true),
                        SerialNumber = c.String(maxLength: 20),
                        DeviceName = c.String(maxLength: 100),
                        DevicePassword = c.String(maxLength: 50),
                        CarUserName = c.String(maxLength: 50),
                        CarNum = c.String(maxLength: 50),
                        CellPhone = c.String(maxLength: 50),
                        Status = c.Int(nullable: false),
                        PhoneNum = c.String(maxLength: 50),
                        Model = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        Created = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        ActiveDate = c.DateTime(nullable: false),
                        HireStartDate = c.DateTime(nullable: false),
                        HireExpireDate = c.DateTime(nullable: false),
                        SpeedLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                        Icon = c.Int(nullable: false),
                        OILCoefficient = c.Single(nullable: false),
                        BSJIP = c.String(maxLength: 50),
                        AddHireDay = c.Int(nullable: false),
                        ServerID = c.Int(nullable: false),
                        AddressKey = c.String(maxLength: 50),
                        IsCn = c.Boolean(nullable: false),
                        TankModel = c.Int(nullable: false),
                        Head = c.String(maxLength: 100, unicode: false),
                        IsFirstKey = c.Boolean(nullable: false),
                        StealOil = c.Single(nullable: false),
                        IsStealOil = c.Boolean(nullable: false),
                        AddOil = c.Single(nullable: false),
                        IsAddOil = c.Boolean(nullable: false),
                        Scope = c.Single(nullable: false),
                        Type = c.Int(nullable: false),
                        AddressKeyTow = c.String(maxLength: 50),
                        AddressKeyThree = c.String(maxLength: 50),
                        LastKeyIndex = c.Int(nullable: false),
                        IsLocation = c.Boolean(nullable: false),
                        SalesTime = c.DateTime(nullable: false),
                        ContractNumber = c.String(maxLength: 500),
                        Lessee = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DeviceID);
            
            CreateTable(
                "dbo.DevicesReport",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DeviceID = c.Int(nullable: false),
                        NowDistance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AllDistance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WarnCount = c.Int(nullable: false),
                        SpeedLimitCount = c.Int(nullable: false),
                        StopCount = c.Int(nullable: false),
                        SerialNumber = c.String(maxLength: 20),
                        CreateTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ExceptionMessage",
                c => new
                    {
                        ExceptionID = c.Int(nullable: false, identity: true),
                        SerialNumber = c.String(maxLength: 20),
                        DeviceID = c.Int(nullable: false),
                        GeoFenceID = c.Int(nullable: false),
                        NotificationType = c.Int(nullable: false),
                        Message = c.String(maxLength: 500),
                        Created = c.DateTime(nullable: false),
                        Deleted = c.Int(nullable: false),
                        ClearDate = c.DateTime(nullable: false),
                        ClearBy = c.Int(nullable: false),
                        Note = c.String(maxLength: 1000),
                        OLat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OLng = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BaiduLat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BaiduLng = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lng = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Power = c.Int(nullable: false),
                        Address = c.String(maxLength: 250),
                        AccON = c.Boolean(nullable: false),
                        EngineON = c.Boolean(nullable: false),
                        OtherStatus = c.String(maxLength: 50),
                        GSM = c.Int(nullable: false),
                        DeviceUTCTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExceptionID);
            
            CreateTable(
                "dbo.GeoFence",
                c => new
                    {
                        GeofenceID = c.Int(nullable: false, identity: true),
                        FenceName = c.String(maxLength: 50),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Entry = c.Boolean(nullable: false),
                        Exit = c.Boolean(nullable: false),
                        Radius = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsInclusion = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Lat1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Lng1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FenceType = c.Int(nullable: false),
                        Width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserID = c.Int(nullable: false),
                        DeviceID = c.Int(nullable: false),
                        Description = c.String(maxLength: 255),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GeofenceID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        GroupName = c.String(maxLength: 50),
                        UserID = c.Int(nullable: false),
                        Username = c.String(maxLength: 50),
                        Description = c.String(maxLength: 255),
                        Created = c.DateTime(nullable: false),
                        GroupType = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.IconType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, unicode: false),
                        Url = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LKLocation",
                c => new
                    {
                        DeviceID = c.Int(nullable: false, identity: true),
                        LocationID = c.Int(nullable: false),
                        LastCommunication = c.DateTime(nullable: false),
                        ServerUtcDate = c.DateTime(nullable: false),
                        DeviceUtcDate = c.DateTime(nullable: false),
                        StopStartUtcDate = c.DateTime(nullable: false),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BaiduLat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BaiduLng = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Address = c.String(maxLength: 500),
                        Speed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Course = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SerialNumber = c.String(maxLength: 20),
                        DataType = c.Int(nullable: false),
                        DataContext = c.String(maxLength: 500),
                        Status = c.Int(nullable: false),
                        SOSTime = c.DateTime(nullable: false),
                        ExceptionTime = c.DateTime(nullable: false),
                        Distance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OLat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OLng = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsStop = c.Int(nullable: false),
                        IsOffline = c.Int(nullable: false),
                        Exception = c.Int(nullable: false),
                        CarStatus = c.Int(nullable: false),
                        IsValid = c.Boolean(nullable: false),
                        DeviceAINFLS = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.DeviceID);
            
            CreateTable(
                "dbo.POI",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        lat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        lng = c.Decimal(nullable: false, precision: 18, scale: 2),
                        name = c.String(maxLength: 50),
                        userID = c.Int(nullable: false),
                        created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SpeedReport",
                c => new
                    {
                        SID = c.Int(nullable: false, identity: true),
                        DeviceID = c.Int(nullable: false),
                        SerialNumber = c.String(maxLength: 20),
                        TypeID = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        OLat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OLng = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Address = c.String(maxLength: 500),
                        UpdateTime = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        TimediffMinute = c.Single(nullable: false),
                        SpeedLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SID);
            
            CreateTable(
                "dbo.UserLog",
                c => new
                    {
                        UserLogID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        LoginTime = c.DateTime(nullable: false),
                        IPAddress = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.UserLogID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        ParentID = c.Int(nullable: false),
                        UserName = c.String(maxLength: 255),
                        LoginName = c.String(maxLength: 255),
                        Password = c.String(maxLength: 255),
                        UserType = c.Int(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        TimeZone = c.String(maxLength: 100),
                        Address1 = c.String(maxLength: 255),
                        Address2 = c.String(maxLength: 255),
                        Country = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        HomePhone = c.String(maxLength: 50),
                        WorkPhone = c.String(maxLength: 50),
                        CellPhone = c.String(maxLength: 50),
                        SMSEmail = c.String(maxLength: 100),
                        PrimaryEmail = c.String(maxLength: 100),
                        SecondaryEmail = c.String(maxLength: 100),
                        Status = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        SuperAdmin = c.Int(nullable: false),
                        AllDeviceCount = c.Int(nullable: false),
                        ActivationCount = c.Int(nullable: false),
                        MoneyCount = c.Int(nullable: false),
                        GuardianName = c.String(maxLength: 50),
                        GuardianPhone = c.String(maxLength: 50),
                        SubUserCount = c.Int(nullable: false),
                        DeviceCount = c.Int(nullable: false),
                        VoiceSwitch = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.WebURL",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        URL = c.String(maxLength: 200),
                        LoginPage = c.String(maxLength: 100),
                        Logo = c.String(maxLength: 500),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WebURL");
            DropTable("dbo.Users");
            DropTable("dbo.UserLog");
            DropTable("dbo.SpeedReport");
            DropTable("dbo.POI");
            DropTable("dbo.LKLocation");
            DropTable("dbo.IconType");
            DropTable("dbo.Groups");
            DropTable("dbo.GeoFence");
            DropTable("dbo.ExceptionMessage");
            DropTable("dbo.DevicesReport");
            DropTable("dbo.Devices");
            DropTable("dbo.DeviceProtocol");
            DropTable("dbo.CommandDictionary");
            DropTable("dbo.CarCommandQueue");
            DropTable("dbo.AccReport");
        }
    }
}
